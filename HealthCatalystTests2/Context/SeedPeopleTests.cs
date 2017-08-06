using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using HealthCatalyst.Models;
using System.Data.Entity;

namespace HealthCatalyst.Context.Tests
{
    [TestClass()]
    public class SeedPeopleTests
    {
        [TestMethod()]
        public void SeedTest()
        {
            // Initialize
            SeedPeople seedPeople = new SeedPeople();
            PersonContext context = new PersonContext();

            var returnedName = context.Persons.ToList()[0].Name;

            // Expected 
            string expectedName = "Shelly Skuza";

            Assert.AreEqual(returnedName, expectedName);
        }
    }
}