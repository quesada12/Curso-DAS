using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birthdate.Year;
            }
        }
        public string BloodType { get; set; }
        public List<Record> ConsultationRecords { get; set; }
        public List<Test> TestsHistory { get; set; }
        public List<Medication> ActiveMedications { get; set; }

        




    }
}
