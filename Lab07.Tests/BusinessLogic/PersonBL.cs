using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PersonBL
    {

        List<Person> persons = new List<Person>();

        /// <summary>
        /// Add a person to the list
        /// </summary>
        /// <param name="person"></param>
        public void Create(Person person)
        {
            if (string.IsNullOrEmpty(person.Name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            persons.Add(person);
        }

        /// <summary>
        /// Finds the one item with the right id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person GetById(int id)
        {
            foreach (var Person in persons)
            {
                if (id == Person.Id)
                {
                    return Person;
                }
            }
            return null;
        }

        public void GetAge(DateTime birthDate)
        {
            throw new NotImplementedException();
        }
    }
}
