using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebZstone.Models
{
    public class MyDbContext : DbContext 
    {
        public MyDbContext(DbContextOptions<MyDbContext> Op) : base(Op)
        {

        }
        public DbSet<Ville> DbsVille { get; set; }
      
    }
}
