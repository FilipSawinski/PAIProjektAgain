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
    public class StoreController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> userManager;

        public StoreController(ApplicationDbContext _db, UserManager<ApplicationUser> userManager)
        {
            this._db = _db;
            this.userManager = userManager;
        }
        public ActionResult Index(string search)
        {
            List<Product> model = new List<Product>();
            if (string.IsNullOrEmpty(search))
            {
                model = _db.Products.Include(c => c.Category)
                    .Where(d => d.Category.isPublic == true).ToList();
            }
            else
            {
                model = _db.Products.Include(c => c.Category)
                    .Where(s => s.Name.Contains(search) || s.Category.Name.Contains(search))
                    .Where(d => d.Category.isPublic == true).ToList();
            }
            return View(model);
        }

        public ActionResult Kategorie()
        {
            var model = _db.Category.Where(c => c.isPublic == true).ToList();
            return View(model);
        }

        public async Task<ActionResult> Buy(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var model = await _db.Products.Include(c => c.Category).FirstOrDefaultAsync(d => d.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        public async Task<ActionResult> BuyAsUnregistered(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var prod = await _db.Products.Include(b => b.Category).FirstOrDefaultAsync(c => c.Id == id && c.Category.isPublic);
            if (prod == null)
            {
                return NotFound();
            }
            var model = new BuyAsUnregisteredViewModel
            {
                prod = prod,
                prodId = prod.Id
            };
            return View(model);
        }

        [HttpPost, ActionName("BuyAsUnregistered")]
        public async Task<ActionResult> BuyAsUnregisteredConfirmed(BuyAsUnregisteredViewModel model)
        {
            if (ModelState.IsValid)
            {
                var prodlist = new List<Product>();
                var prod = _db.Products.Where(c => c.Id == model.prodId).First();
                prodlist.Add(prod);
                var order = new Order
                {
                    Id = Guid.NewGuid().ToString(),
                    ProductList = prodlist,
                    Adress = model.Adress,
                    Zipcode = model.Zipcode,
                    Status = "Ordered",
                    Price = prod.Price - ((float)prod.Discount / 100 * prod.Price),
                    purchaseDateTime = DateTime.Now
                };
                await _db.Orders.AddAsync(order);
                await _db.SaveChangesAsync();
                return RedirectToAction("ThankYou", order);
            }
            return View(model);
        }

        public async Task<ActionResult> BuyAsRegistered(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var prod = _db.Products.Include(b => b.Category).FirstOrDefault(c => c.Id == id && c.Category.isPublic);
            if (prod == null)
            {
                return NotFound();
            }
            var currentuser = await userManager.FindByNameAsync(User.Identity.Name);
            //zmienić na wywalanie do uzupełnienia adresu
            if (string.IsNullOrEmpty(currentuser.Address) || string.IsNullOrEmpty(currentuser.ZipCode))
            {
                return RedirectToAction("Index", "Home");
            }
            var prodlist = new List<Product>();
            prodlist.Add(prod);
            var order = new Order
            {
                Id = Guid.NewGuid().ToString(),
                Buyer = currentuser,
                ProductList = prodlist,
                Adress = currentuser.Address,
                Zipcode = currentuser.ZipCode,
                Status = "Ordered",
                Price = prod.Price - ((float)prod.Discount / 100 * prod.Price),
                purchaseDateTime = DateTime.Now
            };
            await _db.Orders.AddAsync(order);
            await _db.SaveChangesAsync();
            return RedirectToAction("ThankYou", order);

        }

        public ActionResult ThankYou(Order model)
        {
            return View(model);
        }
    }
}
