using MarketViewer.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketObserver.Database
{
    public class MarketObserverDbContext : DbContext, IDbContext
    {

        public MarketObserverDbContext(DbContextOptions<MarketObserverDbContext> options) : base(options)
        {
            //Database.SetInitializer<MarketObserverDbContext>(new UniDBInitializer<MarketObserverDbContext>());

            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //private class UniDBInitializer<T> : DropCreateDatabaseAlways<MarketObserverDbContext>
        //{

        //    protected override void Seed(MarketObserverDbContext context)
        //    {

        //        var user1 = new User()
        //        {
        //            FirstName = "Cooper",
        //            LastName = "Leibow",
        //            Email = "leibowcooper@gmail.com",
        //            ZipCode = "77007",
        //            PhoneNumber = "2144040949"
        //        };


        //        context.Users.Add(user1);
        //        context.SaveChanges();
        //        base.Seed(context);
        //    }
        //}


    }
}
