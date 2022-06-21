using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PAIProjektAgain.Data;
using PAIProjektAgain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext _db;

        public AdminController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext _db)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this._db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Users()
        {
            var users = userManager.Users.ToList();
            List<UsersViewModel> model = new List<UsersViewModel>();
            foreach (var u in users)
            {
                UsersViewModel vm = new UsersViewModel();
                vm.Email = u.Email;
                vm.Id = u.Id;
                vm.Name = u.Name;
                vm.Surname = u.Surname;
                vm.isAdmin = userManager.IsInRoleAsync(u, "Administrator").Result;
                model.Add(vm);
            }
            return View(model);
        }

        public async Task<ActionResult> Edituser(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ApplicationUser user = userManager.FindByIdAsync(id).Result;
            if (user == null)
            {
                return NotFound();
            }
            var model = new UsersViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname,
                isAdmin = userManager.IsInRoleAsync(user, "Administrator").Result
            };
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Edituser(UsersViewModel user)
        {
            if (ModelState.IsValid)
            {
                var usertoupdate = userManager.FindByIdAsync(user.Id).Result;
                usertoupdate.Email = user.Email;
                usertoupdate.UserName = user.Email;
                usertoupdate.Name = user.Name;
                usertoupdate.Surname = user.Surname;
                await userManager.UpdateAsync(usertoupdate);
                return RedirectToAction("Users");
            }
            return View(user);
        }

        public ActionResult Deleteuser(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ApplicationUser user = userManager.FindByIdAsync(id).Result;
            if (user == null)
            {
                return NotFound();
            }
            var model = new UsersViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
                Surname = user.Surname
            };
            return View(model);
        }

        [HttpPost, ActionName("Deleteuser")]
        public async Task<ActionResult> DeleteuserConfirmed(string Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }
            var usertodelete = userManager.FindByIdAsync(Id).Result;
            if (usertodelete == null)
            {
                return NotFound();
            }
            await userManager.DeleteAsync(usertodelete);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Manageroles(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewBag.user = user;
            var model = new List<UserRolesViewModel>();
            foreach (var role in roleManager.Roles)
            {
                var modelelement = new UserRolesViewModel();
                modelelement.RoleId = role.Id;
                modelelement.RoleName = role.Name;
                if (userManager.IsInRoleAsync(user, role.Name).Result)
                {
                    modelelement.isSelected = true;
                }
                else
                {
                    modelelement.isSelected = false;
                }
                model.Add(modelelement);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Manageroles(List<UserRolesViewModel> roleslist, string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            var roles = await userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                await userManager.RemoveFromRoleAsync(user, role);
            }
            foreach (var role in roleslist)
            {
                if (role.isSelected)
                {
                    await userManager.AddToRoleAsync(user, role.RoleName);
                }
            }
            return RedirectToAction("Edituser", "Admin", new { id = user.Id });
        }
    }
}
