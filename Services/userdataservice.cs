using Eshop.Models;
using Eshop.Context;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Services
{
    public class UserDataService: IUserDataService
    { 

        public void Postdata(UserProduct model)
        {
            using (var context = new UserProductContext())
            {
                var r = new UserProduct()
                {   
                    property1 = model.property1,
                    property2 = model.property2,
                    property3 = model.property3,
                    property4 = model.property4,
                };

                context.Add(r);
                context.SaveChanges();
            }
        }
        public IEnumerable<UserProduct> Getdata(UserProduct model) 
        {
            var context = new UserProductContext();
            
               

           IEnumerable<UserProduct> entities=context.UserProducts.ToListAsync().GetAwaiter().GetResult();
                
            
            return entities;
        }

        

    }
}
