using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MotoDB.Models
{
    public class MotoDBContext : DbContext
    {
        public MotoDBContext (DbContextOptions<MotoDBContext> options)
            : base(options)
        {
        }

        public DbSet<MotoDB.Models.Motorcycle> Motorcycle { get; set; }
    }
}
