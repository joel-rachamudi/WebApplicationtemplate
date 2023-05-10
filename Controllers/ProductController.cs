using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
//using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
using WebApplicationtemplate.Context;
using WebApplicationtemplate.Models;
using WebApplicationtemplate.Services;
//using Microsoft.AspNetCore.Http;

namespace WebApplicationtemplate.Controllers
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
            //ViewBag.statuscode=HttpContext.HttpResponse.StatusDescription;
            _userDataService.Postdata(product);
            return View();
            
            //Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<Database updated>>>>>>>>>>>>>>>>>>>>>>>>>");
        }
        [Authorize]
        public IActionResult ProductsView(UserProduct product)

        {
            
            return View();

            //Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<Database updated>>>>>>>>>>>>>>>>>>>>>>>>>");
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

