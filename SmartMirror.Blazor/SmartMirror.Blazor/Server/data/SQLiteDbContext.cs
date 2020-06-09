using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SmartMirror.Blazor.Server.data
{
    public class SQLiteDbContext : DbContext
    {
        public SQLiteDbContext(DbContextOptions options)
            :base (options)
        {
            
        }

        //public DbSet<CalendarModel>Calendar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source../TestDB.db");

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<CalendarModel>().HasData(LoadData()());
        //}

        //private List<CalendarModel> LoadData()
        //{
        //    return new List<CalendarModel>
        //    {
        //        new CalendarModel() { }
        //    };
        //}
    }
}
