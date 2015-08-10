namespace PersonInfo.Migrations
{
    using PersonInfo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PersonInfo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PersonInfo.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.People.AddOrUpdate(p => p.Name,
                new Person
                {
                    Name = "Gousheng Zhang",
                    Address = "1234 Main St",
                    City = "Redmond",
                    State = "WA",
                    Zip = "10999",
                    Email = "gousheng@example.com"
                },
                new Person
                {
                    Name = "Erya Wang",
                    Address = "6327 Main St",
                    City = "Redmond",
                    State = "WA",
                    Zip = "10299",
                    Email = "erya@example.com"
                },
                new Person
                {
                    Name = "GouDan Wang",
                    Address = "6327 Main St",
                    City = "Redmond",
                    State = "WA",
                    Zip = "10299",
                    Email = "goudan@example.com"
                },
                new Person
                {
                    Name = "Cuihua Liu",
                    Address = "6327 Redway St",
                    City = "Redmond",
                    State = "WA",
                    Zip = "10239",
                    Email = "cuihua@example.com"
                },
                new Person
                {
                    Name = "Tiedan Tan",
                    Address = "3124 Old Scaff St",
                    City = "Redmond",
                    State = "WA",
                    Zip = "40239",
                    Email = "tiedan@example.com"
                }
            );
        }
    }
}
