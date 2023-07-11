using Bacchanalia_Sales.Data;
using Bacchanalia_Sales.Models;
using Bacchanalia_Sales.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql;

namespace Bacchanalia_Sales.Controllers
{
    public class SalesController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;

        public SalesController(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await mvcDemoDbContext.Products.ToListAsync();
            return View(products);
        }
        
        [HttpGet]

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddProduct addProductRequest)
        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Week = addProductRequest.Week,
                Name = addProductRequest.Name,
                Course = addProductRequest.Course,
                MondaySales = addProductRequest.MondaySales,
                TuesdaySales = addProductRequest.TuesdaySales,
                WednesdaySales = addProductRequest.WednesdaySales,
                ThursdaySales = addProductRequest.ThursdaySales,
                FridaySales = addProductRequest.FridaySales,
                SaturdaySales = addProductRequest.SaturdaySales
            };

            await mvcDemoDbContext.Products.AddAsync(product);
            await mvcDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var product = await mvcDemoDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product != null)
            {
                var viewModel = new UpdateProductView()
                {
                    Id = product.Id,
                    Week = product.Week,
                    Name = product.Name,
                    Course = product.Course,
                    MondaySales = product.MondaySales,
                    TuesdaySales = product.TuesdaySales,
                    WednesdaySales = product.WednesdaySales,
                    ThursdaySales = product.ThursdaySales,
                    FridaySales = product.FridaySales,
                    SaturdaySales = product.SaturdaySales
                };
                return await Task.Run(() => View("View", viewModel));
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> View(UpdateProductView model)
        {
            var product = await mvcDemoDbContext.Products.FindAsync(model.Id);

            if (product != null)
            {
                product.Week = model.Week;
                product.Name = model.Name;
                product.Course = model.Course;
                product.MondaySales = model.MondaySales;
                product.TuesdaySales = model.TuesdaySales;
                product.WednesdaySales= model.WednesdaySales;
                product.ThursdaySales = model.ThursdaySales;
                product.FridaySales = model.FridaySales;
                product.SaturdaySales = model.SaturdaySales;

               await mvcDemoDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateProductView model)
            {
            var product = await mvcDemoDbContext.Products.FindAsync(model.Id);
            
                if(product != null)
                {
                mvcDemoDbContext.Products.Remove(product);
                await mvcDemoDbContext.SaveChangesAsync();

                return RedirectToAction("Index");
                }
            return RedirectToAction("Index");
        }

    }
}
