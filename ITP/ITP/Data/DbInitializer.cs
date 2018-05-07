using ITP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITP.Data
{
    public class DbInitializer
    {
        public static void Initialize(BaseContext context)
        {
            context.Database.EnsureCreated();

            if (context.AboutTable.Any())
            {
                return;   // DB has been seeded
            }

            var signs = new Signup[]
            {
                new Signup { Email = "jakob@bisander.com" },
                new Signup { Email = "abc@123.com" }
            };
            foreach (Signup s in signs)
            {
                context.Signups.Add(s);
            }
            context.SaveChanges();




            context.AboutTable.Add(new About { Name = "Jakob Bisander", Age= 25});
            context.SaveChanges();           
        }
    }
}
