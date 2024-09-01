using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_30_08
{
    internal class DbManager
    {
        public DbContextOptions<ApplicationContext> GetConectionOptions()
        {

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsetings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            return optionsBuilder.UseSqlServer(connectionString).Options;
        }


        public void AddData()
        {
            using (ApplicationContext db = new ApplicationContext(GetConectionOptions()))
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                List<EventManager> events = new List<EventManager> {
                    new EventManager{
                        EventDateTime = DateTime.Now,
                        Description = "test",
                        EventTitle = "test",
                        
                    },


                    new EventManager{ 
                        EventDateTime= DateTime.Now,
                        Description = "test2",
                        EventTitle = "test2",
                    }
                };
                
            }



           
        }

        public List<EventManager> GetData()
        {
            using (ApplicationContext db = new ApplicationContext(GetConectionOptions())) {
                return db.EventManagers.ToList();
            }
        }

    }


   
}
