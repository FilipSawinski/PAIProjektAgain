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
    public class TicketController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> userManager;
        public TicketController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            this.userManager = userManager;
        }

        [Authorize(Roles = "Administrator, Kierownik, Sprzedawca")]
        public IActionResult Index()
        {
            var model = _db.Tickets.Include(c => c.User).Include(c => c.Realizator).ToList();

            return View(model);
        }

        [Authorize]
        public ActionResult AddTicket()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> AddTicket(AddTicketViewModel model)
        {
            if (ModelState.IsValid)
            {
                Ticket ticket = new Ticket
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = model.Name,
                    Description = model.Description,
                    User = await userManager.FindByNameAsync(User.Identity.Name),
                    isClosed = false
                };
                await _db.Tickets.AddAsync(ticket);
                await _db.SaveChangesAsync();
                return RedirectToAction("MyTickets");
            }
            return View(model);
        }

        public async Task<ActionResult> MyTickets()
        {
            var currentuser = await userManager.FindByNameAsync(User.Identity.Name);
            var model = _db.Tickets
                .Include(c => c.Realizator).Include(d => d.User)
                .Where(e => e.User == currentuser).ToList();
            return View(model);
        }

        public async Task<ActionResult> ViewTicket(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var model = await _db.Tickets.Include(c => c.Realizator).FirstOrDefaultAsync(d => d.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);

        }
        [Authorize(Roles = "Administrator, Kierownik, Sprzedawca")]
        public async Task<ActionResult> CloseTicket(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var model = await _db.Tickets.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            model.isClosed = true;
            _db.Tickets.Update(model);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrator, Kierownik, Sprzedawca")]
        public async Task<ActionResult> AnswerTicket(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var tick = await _db.Tickets.FindAsync(id);
            if (tick == null)
            {
                return NotFound();
            }
            var model = new AnswerTicketViewModel
            {
                Id = id,
                Description = tick.Description,
                Answer = tick.Answer,
                Name = tick.Name
            };
            return View(model);
        }

        [Authorize(Roles = "Administrator, Kierownik, Sprzedawca")]
        [HttpPost]
        public async Task<ActionResult> AnswerTicket(AnswerTicketViewModel model)
        {
            var tick = await _db.Tickets.Include(c => c.User).Include(c => c.Realizator).FirstOrDefaultAsync(c => c.Id == model.Id);
            tick.Answer = model.Answer;
            tick.Realizator = await userManager.FindByNameAsync(User.Identity.Name);
            _db.Tickets.Update(tick);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
