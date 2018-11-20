using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Entities
{
    public class Record
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public string Description { get; set; }

    }
}