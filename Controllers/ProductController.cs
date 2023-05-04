using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplicationtemplate.Context;
using WebApplicationtemplate.Models;

namespace WebApplicationtemplate.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
               public IActionResult UserProduct(UserProduct model)

               {
                 return View();
                 

                    //Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<Database updated>>>>>>>>>>>>>>>>>>>>>>>>>");
                
                }
      
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

