using System;
using System.Collections;
using System.Collections.Generic;

namespace HealthCatalyst.Models
{
    public class Person 
    {
        private List<Person> people;
        public Person()
        {
            people = new List<Person>();
        }

		public int PersonID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Photo { get; set; }
		public int Age { get; set; }
		public string Interests { get; set; }

        //public IEnumerator GetEnumerator()
        //{
        //    return people.GetEnumerator();
        //}

        public IEnumerator<Person> GetEnumerator()
        {
            return people.GetEnumerator();
        }
    }
}
