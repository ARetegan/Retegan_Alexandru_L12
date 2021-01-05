using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Retegan_Alexandru_L12.Models;

namespace Retegan_Alexandru_L12.Data
{
    public class Retegan_Alexandru_L12Context : DbContext
    {
        public Retegan_Alexandru_L12Context (DbContextOptions<Retegan_Alexandru_L12Context> options)
            : base(options)
        {
        }

        public DbSet<Retegan_Alexandru_L12.Models.ShopList> ShopList { get; set; }
    }
}
