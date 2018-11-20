using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Entities;

namespace Taller2.BusinessLogic
{
    public interface IPatientLogic
    {
        List<Patient> GetPatients(string username);
        List<Patient> GetPatientByName(string username, string name);

        Patient GetPatientById(int id);
        Patient EditPatient(Patient patient);

    }
}
