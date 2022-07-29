using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekManagment.Models
{
    public class Druggists : User
    {
        public string Education { get; set; }
        public string Experience { get; set; }

        public Druggists(int id, string name, string surname, string pin, string education, string experience) : base(id, name, surname, pin)
        {
            Education = education;
            Experience = experience;
        }
    }
}
