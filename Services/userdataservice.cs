using WebApplicationtemplate.Models;
using WebApplicationtemplate.Context;

namespace WebApplicationtemplate.Services
{
    public class UserDataService: IUserDataService
    { 

        public void Getdata(UserProduct model)
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

        

    }
}
