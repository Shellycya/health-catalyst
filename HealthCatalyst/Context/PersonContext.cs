using System;
using System.Data.Entity;

namespace HealthCatalyst.Context
{
    public class PersonContext : DbContext
	{
        public PersonContext(): base()
        {

        }

        public DbSet<Models.Person> Persons { get; set; }

       
    }
}
