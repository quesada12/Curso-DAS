using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Entities;

namespace Taller2.BusinessLogic
{
    public interface IAuthenticator
    {
        User Log(string username, string password);
    }
}
