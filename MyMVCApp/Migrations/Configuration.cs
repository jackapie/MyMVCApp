namespace MyMVCApp.Migrations
{
    using MyMVCApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyMVCApp.Models.MyMVCAppDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MyMVCApp.Models.MyMVCAppDb";
        }

        protected override void Seed(MyMVCApp.Models.MyMVCAppDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. 
            //In the code below, it checks to see if the Restaurant exists by Name.
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Sabatino's", City = "Baltimore", Country = "USA" },
                new Restaurant { Name = "Great Lake", City = "Chicago", Country = "USA" },
                new Restaurant
                {
                    Name = "Smaka",
                    City = "Gothenburg",
                    Country = "Sweden",
                    Reviews = new List<RestaurantReview> { new RestaurantReview { Rating = 9, Body = "Great Food", ReviewerName = "Jackie" } }
                });

            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = i.ToString(), City = "Nowhere", Country = "USA" });
            }
        }
    }
}
