using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LabProcess.Models;


namespace LabProcess.Models
{
    public class dbcontext:DbContext
    {
        public dbcontext(DbContextOptions<dbcontext>options):base(options)
        {
            
        }

        public DbSet<raw> raws {set; get;}
        public DbSet<product> products {set; get;}
        public DbSet<provider> providers {set; get;}
        public DbSet<store> stores {set; get;}
        public DbSet<dependence> dependences {set; get;}
        public DbSet<costumer> costumers {set; get;}

    }
}
