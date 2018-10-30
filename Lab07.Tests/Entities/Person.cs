using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                int Now = DateTime.Now.Year;
                int PersonYear = BirthDate.Year;
                return Now-PersonYear;
            }
        }
    }
}
