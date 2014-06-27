using RadioButtonListLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RadioButtonListLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductModel model = new ProductModel();
            model.ProductId = 2;
            return View(model);
        }


    }
}