using Aulfah.BLL.Interfaces;
using Aulfah.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aulfah.PL.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        public ProductController(IUnitofWork unitofWork)
        {
             _unitofWork = unitofWork;
        }
        public IActionResult Index()
        {
            var products = _unitofWork.ProductRepository.GetAll();
            return View(products);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var products = _unitofWork.ProductRepository.Get(id.Value);
            return View(products);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {

            if (ModelState.IsValid)
            {
                _unitofWork.ProductRepository.Create(product);
                TempData["success"] = "Added Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Update(int id)
        {
            var dep = _unitofWork.ProductRepository.Get(id);
            return View(dep);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitofWork.ProductRepository.Update(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public ActionResult Delete(int id)
        {
            var dep = _unitofWork.ProductRepository.Get(id);
            _unitofWork.ProductRepository.Delete(dep);
            return RedirectToAction("Index");
        }
    }
}
