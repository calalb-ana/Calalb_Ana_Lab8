using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Calalb_Ana_Lab8.Models;

namespace Calalb_Ana_Lab8.Data
{
    public class Calalb_Ana_Lab8Context : DbContext
    {
        public Calalb_Ana_Lab8Context (DbContextOptions<Calalb_Ana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Calalb_Ana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Calalb_Ana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Calalb_Ana_Lab8.Models.Category> Category { get; set; }
    }
}
