using Microsoft.EntityFrameworkCore;
using SomeGoroscopes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SomeGoroscopes.Models
{
    public class HoroscopeContext : DbContext
    {
        public DbSet<Prediction> Prediction { get; set; }
        public DbSet<ZSign> ZSign { get; set; }

        public HoroscopeContext(DbContextOptions<HoroscopeContext> options)
             : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
// background-image: url(https://cdn.wallpapersafari.com/99/4/xNDGun.jpg)
//                          