using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class SirketDbContext : DbContext
    {
        public SirketDbContext (DbContextOptions<SirketDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Personel> Personel { get; set; }
    }
}
