using Aulfah.BLL.Interfaces;
using Aulfah.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aulfah.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUnitofWork _unitOfWork;

        public HomeController(IUnitofWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var ProductList = _unitOfWork.ProductRepository.GetAll();
            //  var ProductList = _unitOfWork.ProductRepository.GetAll();
            var CategoryList = _unitOfWork.CategoryRepository.GetAll();

            // ViewData["Products"] = ProductList;
            ViewData["Categories"] = CategoryList;

            return View(ProductList);

        }


    }
}