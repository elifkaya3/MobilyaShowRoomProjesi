using Microsoft.AspNetCore.Mvc;
using MobilyaShowRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = Repository.AllProducts();


            return View(products);
        }
        public IActionResult GetProductDetail()
        {
            int id =Convert.ToInt32(ControllerContext.RouteData.Values["ID"]);

            var products = Repository.AllProducts();
            Product resultProduct = null;
            foreach (var product in products)
            {
                if (product.ID==id)
                {   
                    
                    resultProduct = product;
                    break;
                }
                
            }
            ViewBag.Product = resultProduct;
            ViewBag.Title = resultProduct.ProductName + "Ürün Detay Bilgisi" ;
                return View();
            //görüntü katmanı view bag
            /*ViewBag.ID=id;
            return View();*/
        }
    }
}
