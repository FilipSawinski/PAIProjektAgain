using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAIProjektAgain.Data;
using PAIProjektAgain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> userManager;

        public OrderController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            this.userManager = userManager;
        }


        [Authorize(Roles = "Administrator, Kierownik, Sprzedawca")]
        public IActionResult Index()
        {
            var model = _db.Orders.Include(c => c.Realizator).OrderByDescending(d => d.purchaseDateTime);
            return View(model);
        }

        [Authorize(Roles = "Administrator, Kierownik, Sprzedawca")]
        public async Task<ActionResult> ClaimOrAdvance(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var model = await _db.Orders.Include(c => c.Realizator).FirstOrDefaultAsync(c => c.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            if (model.Realizator == null)
            {
                var currentuser = await userManager.FindByNameAsync(User.Identity.Name);
                model.Realizator = currentuser;
                model.Status = "Claimed";
            }
            else if (model.Status == "Claimed")
            {
                model.Status = "Shipped";
            }
            _db.Update(model);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Search()
        {
            var model = new SearchByIdViewModel();
            return View(model);
        }

        public async Task<ActionResult> SearchById(SearchByIdViewModel mol)
        {
            var id = mol.Id;
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var model = await _db.Orders.Include(c => c.ProductList).SingleOrDefaultAsync(d => d.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [Authorize]
        public async Task<ActionResult> MyOrders()
        {
            var currentuser = await userManager.FindByNameAsync(User.Identity.Name);
            var model = _db.Orders.Include(c => c.Buyer).Where(d => d.Buyer == currentuser).ToList();
            return View(model);
        }
    }
}

