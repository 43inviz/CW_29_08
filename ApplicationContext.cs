using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_30_08
{
    internal  class ApplicationContext:DbContext
    {
        public DbSet<EventManager> EventManagers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }



    }
}
