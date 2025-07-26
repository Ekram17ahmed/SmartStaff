using Microsoft.EntityFrameworkCore;
using SmartStaff.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStaff.DAL.DataBase
{
    public class SmartStaffDbContext :DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3JA9N1H\\SQLEXPRESS;Database=MVCday3;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<Employee> employees { get; set; }
    }
}
