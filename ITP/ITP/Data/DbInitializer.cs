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
                new Signup { Email = "john@doe.com" },
                new Signup { Email = "abc@123.com" }
            };
            foreach (Signup s in signs)
            {
                context.Signups.Add(s);
            }
            context.SaveChanges();

            var photos = new Photo[]
{
                new Photo { Url = "http://ichef.bbci.co.uk/wwfeatures/wm/live/1280_640/images/live/p0/5x/h5/p05xh5dx.jpg" },
                new Photo { Url = "https://i.ytimg.com/vi/KGk4b2bBIp4/maxresdefault.jpg" },
                new Photo { Url = "https://orig00.deviantart.net/5248/f/2011/250/6/2/a_see_space_of_purple_by_kkpaw-d496c79.jpg" },
                new Photo { Url = "https://i.ytimg.com/vi/69Zo05WeIF0/maxresdefault.jpg" }
};
            foreach (Photo p in photos)
            {
                context.Photos.Add(p);
            }
            context.SaveChanges();

            context.AboutTable.Add(new About { Name = "Jakob Bisander", Age= 25});

            context.SaveChanges();           
        }
    }
}
