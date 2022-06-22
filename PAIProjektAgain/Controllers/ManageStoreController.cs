using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PAIProjektAgain.Data;
using PAIProjektAgain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Controllers
{
    [Authorize(Roles = "Administrator, Kierownik")]
    public class ManageStoreController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment hostEnvironment;
        public ManageStoreController(UserManager<ApplicationUser> userManager, ApplicationDbContext _db, IWebHostEnvironment hostEnvironment)
        {
            this.userManager = userManager;
            this._db = _db;
            this.hostEnvironment = hostEnvironment;
        }

        public ActionResult Categories()
        {
            var model = _db.Category.ToList();
            return View(model);
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddCategory(Category model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid().ToString();
                await _db.Category.AddAsync(model);
                await _db.SaveChangesAsync();
                return RedirectToAction("Categories");
            }
            return View(model);
        }

        public async Task<ActionResult> EditCategory(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = await _db.Category.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> EditCategory(Category model)
        {
            if (ModelState.IsValid)
            {
                Category kat = await _db.Category.FindAsync(model.Id);
                kat.Name = model.Name;
                kat.isPublic = model.isPublic;
                _db.Category.Update(kat);
                await _db.SaveChangesAsync();
                return RedirectToAction("Categories");
            }
            return View(model);
        }

        public async Task<ActionResult> DeleteCategory(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = await _db.Category.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        [HttpPost, ActionName("DeleteCategory")]
        public async Task<ActionResult> DeleteCategoryConfirmed(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = await _db.Category.FindAsync(id);
            if (model == null)
            {
                return BadRequest();
            }
            //znajdź wszystkie produkty z usuwaną kategorią i przestaw im kategorie
            var products = _db.Products.Where(c => c.Category == model);
            foreach (var p in products)
            {
                p.Category = null;
                _db.Products.Update(p);
            }
            _db.Category.Remove(model);
            await _db.SaveChangesAsync();
            return RedirectToAction("Categories");
        }

        public async Task<ActionResult> Products()
        {
            var products = _db.Products.Include(x => x.Category).ToList();
            List<ProductViewModel> model = new List<ProductViewModel>();
            foreach (var p in products)
            {
                var pro = new ProductViewModel();
                pro.Id = p.Id;
                pro.Name = p.Name;
                pro.Price = p.Price;
                pro.Discount = p.Discount;
                pro.AvailableNumber = p.AvailableNumber;
                pro.PriceAfterDiscount = pro.Price - (float)pro.Discount / 100 * pro.Price;
                if (p.Category != null)
                {
                    pro.CategoryName = p.Category.Name;
                }
                else
                {
                    pro.CategoryName = "Brak, dodaj w panelu 'Edytuj'";
                }
                model.Add(pro);
            }
            return View(model);
        }

        public async Task<ActionResult> AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid().ToString();
                await _db.Products.AddAsync(model);
                await _db.SaveChangesAsync();
                return RedirectToAction("Products");
            }
            return View(model);
        }

        public async Task<ActionResult> EditProduct(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _db.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var model = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Discount = product.Discount,
                PriceAfterDiscount = product.Price - (float)product.Discount / 100 * product.Price,
                AvailableNumber = product.AvailableNumber,
                Categories = _db.Category.Select(c => new SelectListItem { Text = c.Name, Value = c.Id }),
                isHighlited = product.isHighlighted
            };
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> EditProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var producttoupdate = await _db.Products.FindAsync(model.Id);
                producttoupdate.Name = model.Name;
                producttoupdate.Description = model.Description;
                producttoupdate.Price = model.Price;
                producttoupdate.Discount = model.Discount;
                producttoupdate.Category = await _db.Category.FindAsync(model.CategoryId);
                producttoupdate.AvailableNumber = model.AvailableNumber;
                producttoupdate.isHighlighted = model.isHighlited;
                _db.Products.Update(producttoupdate);
                await _db.SaveChangesAsync();
                return RedirectToAction("Products");
            }
            return View(model);
        }

        public async Task<ActionResult> DeleteProduct(string id)
        {
            if (id == null)
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

        [HttpPost, ActionName("DeleteProduct")]
        public async Task<ActionResult> DeleteProductConfirmed(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = await _db.Products.FindAsync(id);
            if (model == null)
            {
                return NotFound();
            }
            var orders = _db.Orders.Include(c => c.ProductList).ToList();
            foreach (var o in orders)
            {
                if (o.ProductList.Contains(model))
                {
                    _db.Orders.Remove(o);
                }
            }
            _db.Products.Remove(model);
            await _db.SaveChangesAsync();
            return RedirectToAction("Products");
        }

        public async Task<ActionResult> AddPhoto(string id)
        {
            var prod = _db.Products.Where(c => c.Id == id).FirstOrDefault();
            var model = new AddPhotoViewModel
            {
                Id = id
            };
            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> AddPhoto(AddPhotoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var prod = await _db.Products.FindAsync(model.Id);
                if (!string.IsNullOrEmpty(prod.photoPath))
                {
                    string pathtodelete = Path.Combine(hostEnvironment.WebRootPath, "imgs", "products", prod.photoPath);
                    FileInfo ftod = new FileInfo(pathtodelete);
                    ftod.Delete();
                }
                string fileName = Guid.NewGuid().ToString() + ".jpg";
                string path = Path.Combine(hostEnvironment.WebRootPath, "imgs", "products", fileName);
                model.photo.CopyTo(new FileStream(path, FileMode.Create));


                prod.photoPath = fileName;
                _db.Products.Update(prod);
                await _db.SaveChangesAsync();
                return RedirectToAction("EditProduct", new { id = model.Id });
            }
            return View();
        }

    }
}
