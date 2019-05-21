using Mvc_DependencyInjection_IoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_DependencyInjection_IoC.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository productRepository;

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
    }
}