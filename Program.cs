using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CW_30_08
{
    internal class Program
    {


        static void Main(string[] args)
        {
            DbManager db = new DbManager();

            db.AddData();


            List<EventManager> em = db.GetData();
        }
    }


    internal class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();

            // получаем конфигурацию из файла appsettings.json
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();

            // получаем строку подключения из файла appsettings.json
            string connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlite(connectionString);
            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
