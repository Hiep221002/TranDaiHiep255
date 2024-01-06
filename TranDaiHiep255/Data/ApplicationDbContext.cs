using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TranDaiHiep255.Models;

namespace Trandaihiep255.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TranDaiHiep255.Models.Person> Person { get; set; } = default!;
        public DbSet<TranDaiHiep255.Models.SinhVien> SinhVien { get; set; } = default!;
    }
}
