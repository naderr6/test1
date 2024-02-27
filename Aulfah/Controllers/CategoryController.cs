using Aulfah.BLL.Interfaces;
using Aulfah.DAL.Model;
using Aulfah.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aulfah.PL.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitofWork _unitofWork;

        public CategoryController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public IActionResult Index()
        {
            var products = _unitofWork.CategoryRepository.GetAll();
            return View(products);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var products = _unitofWork.CategoryRepository.Get(id.Value);
            return View(products);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {

            if (ModelState.IsValid)
            {
                _unitofWork.CategoryRepository.Create(category);
                TempData["success"] = "Added Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Update(int id)
        {
            var dep = _unitofWork.CategoryRepository.Get(id);
            return View(dep);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                _unitofWork.CategoryRepository.Update(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public ActionResult Delete(int id)
        {
            var category = _unitofWork.CategoryRepository.Get(id);
            _unitofWork.CategoryRepository.Delete(category);
            return RedirectToAction("Index");
        }
    }
}
