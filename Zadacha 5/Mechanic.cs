using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    internal class Mechanic
    {
        public string MechanicID{ get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }

        public Mechanic(string mechanicID, string fullName, string specialization) 
        {
            MechanicID = mechanicID;
            FullName = fullName;
            Specialization = specialization;

        }
    }
}
