using practiceEF.Models;

namespace practiceEF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<practiceEF.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(practiceEF.Model1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.ManyPeople.AddOrUpdate(
                 
                  new people  {Age = 34,NAME = "samira"},
                  new people {Age  = 32,NAME = "cathal"},
                  new people{ Age = 30,NAME = "divya"}
                );
            context.SaveChanges();
        }
    }
}
