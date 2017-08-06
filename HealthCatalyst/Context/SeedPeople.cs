using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace HealthCatalyst.Context
{
    public class SeedPeople 
    {
        public void Seed(PersonContext context)
        {
            GetPersons(context);
            context.SaveChanges();
        }

        private void GetPersons(PersonContext context)
        {
            var personJsonAll = GetEmbeddedResourceAsString("HealthCatalyst.Data.seedData.json");

            JArray jsonValSpeakers = JArray.Parse(personJsonAll) as JArray;
            dynamic personsData = jsonValSpeakers;
            // Only seed if the database is brand new
            if (context.Persons.ToList().Count <= 0)
            {
                foreach (dynamic person in personsData)
                {
                    context.Persons.Add(new Models.Person
                    {
                        PersonID = person.personid,
                        Name = person.name,
                        Address = person.address,
                        Age = person.age,
                        Photo = person.photo,
                        Interests = person.interests
                    });
                }
            }
        }

        private string GetEmbeddedResourceAsString(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            //var names = assembly.GetManifestResourceNames();

            string result = "";
            //using (Stream stream = assembly.GetManifestResourceStream(resourceName)) { }
            using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream(resourceName)))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
    }
}