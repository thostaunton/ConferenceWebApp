namespace ConferenceWebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ConferenceWebApp.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<ConferenceWebApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ConferenceWebApp.Models.ApplicationDbContext context) // This method adds the initial entries into the database. 
        {
                  context.Attendees.AddOrUpdate(
                   x => x.Id,
                   new Attendee { Id = 1, name = "Andrew Peters", jobTitle = "Conference Staff", company = "Voiteq", dateOfBirth = "10/06/1996", attended = false },
                   new Attendee { Id = 2, name = "Brice Lambson", jobTitle = "Conference Staff", company = "Voiteq", dateOfBirth = "17/2/1972", attended = false },
                   new Attendee { Id = 3, name = "Rowan Miller", jobTitle = "Conference Staff", company = "Voiteq", dateOfBirth = "8/10/1980", attended = false }
                  );
            
        }
    }
}
