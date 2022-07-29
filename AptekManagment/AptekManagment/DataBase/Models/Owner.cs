using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekManagment.Models
{
   public class Owner : User
    {
        public Owner(int id, string name, string surname, string pin) :base(id, name, surname, pin)
        {

        }

    }
}
