using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmporioDaCarne_POS.Models;

namespace EmporioDaCarne_POS.Data
{
    public class EmporioDaCarne_POSContext : DbContext
    {
        public EmporioDaCarne_POSContext (DbContextOptions<EmporioDaCarne_POSContext> options)
            : base(options)
        {
        }

        public DbSet<EmporioDaCarne_POS.Models.User> User { get; set; } = default!;
    }
}
