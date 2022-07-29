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
            foreach (User user in Users)
            {
                Owner owner = user as Owner;
                if(user !=null)
                {
                    owners.Add((Owner)owner);
                }
            }

            return owners;
        }

        public static List<Druggists> GetAllDruggists()
        {
            List<Druggists> druggists = new List<Druggists>();
            foreach (User druggist in Users)
            {
                if (druggist is Druggists)
                {
                    druggists.Add((Druggists)druggist);
                }
            }

            return druggists;
        }

        public static void Delete(User user)
        {
            Users.Remove(user);
        }

    }
}
