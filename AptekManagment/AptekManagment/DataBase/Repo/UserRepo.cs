using AptekManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekManagment.DataBase.Repo
{
    public class UserRepo
    {
        private static int _idCounter;

        public static int IdCounter
        {
            get
            {
                _idCounter++;
                return _idCounter;
            }
        }
        private static List<User> Users { get; set; } = new List<User>()
        {
           
        };
       
        public static User AddUser(User user)
        {
            Users.Add(user);
            return user;
        }
       

        public static List<User> GetAll()
        {
            return Users;
        }

        public static List<Owner> GetAllOwners()
        {
            List<Owner> owners = new List<Owner>();
            foreach (User owner in Users)
            {
                if(owner is Owner)
                {
                    owners.Add((Owner)owner);
                }
            }
        }

        public static List<Owner> GetAllDruggists()
        {

            foreach (User druggist in Users)
            {
                if (druggist is Druggists)
                {

                }
            }
        }

        public static void Delete(User user)
        {
            Users.Remove(user);
        }

    }
}
