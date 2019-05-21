using Mvc_DependencyInjection_IoC.DataModels;
using Mvc_DependencyInjection_IoC.DataModels.Interfaces;
using System.Web.Mvc;

namespace Mvc_DependencyInjection_IoC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Products
        public ActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }

        #region Create

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Add(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }
        #endregion

        #region Update 

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = _productRepository.Get(id);
            return product == null
                ? (ActionResult)RedirectToAction("Index")
                : View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            var successfulUpdate = _productRepository.Update(product);



            return successfulUpdate
                ? (ActionResult)RedirectToAction("Index")
                : View("Error", "Uh oh");
        }

        #endregion

        #region Delete

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var successfulDelete = _productRepository.Delete(id);
            return successfulDelete 
                ? (ActionResult)RedirectToAction("Index")
                : View("Error", "Uh oh");
        }

        #endregion
    }
}