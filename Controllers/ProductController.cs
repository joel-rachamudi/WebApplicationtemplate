using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
//using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
using Eshop.Context;
using Eshop.Models;
using Eshop.Services;
//using Microsoft.AspNetCore.Http;

namespace Eshop.Controllers
{
    public class ProductController : Controller
    {
        

        

        private readonly IUserDataService _userDataService;

        private readonly UserProductContext ? _userProductContext;
        public ProductController(IUserDataService userDataService,UserProductContext  context)
        {
            _userDataService = userDataService;
            _userProductContext = context;

        }

        [Authorize]
        public IActionResult UserProductView(UserProduct product)

        {
            
            _userDataService.Postdata(product);
            return View();
            
            
        }
        [Authorize]
        public IActionResult ProductsView(UserProduct product)

        { 
            var data = _userProductContext.UserProducts.ToList();  

            return View(data);
        }

           
      


        /* 
         [HttpPost]
       public  IActionResult UserProductView(UserProduct product)
         {
             _userDataService.Getdata(product);
             return RedirectToAction("Index");
         }*/

        /* public IActionResult Productsview()

         {
             string filePath = "C:\\databeat_JOEL\\THE_GOOD_GUY project\\learn\\intern-task2\\WebApplicationtemplate\\jsontext.txt";

             List<Product> myDeserializedClass = JsonConvert.DeserializeObject<List<Product>>(filePath);
             foreach (Product product in myDeserializedClass)
             {
                 Console.WriteLine(product);
             }
             return Ok();
         }*/

    }
}

