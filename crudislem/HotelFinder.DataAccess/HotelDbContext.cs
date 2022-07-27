using hotelFinder.entities;
using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("************************************************");

        }
        public DbSet<Hotel> Hotels {get; set;}

        public DbSet<Comment>  Comments { get; set; }
    }
}
