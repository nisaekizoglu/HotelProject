using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Context
{
    public class ApiContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AFU114N\\SQLEXPRESS;initial Catalog=HotelProjectDb;integrated Security=true;TrustServerCertificate=True");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
