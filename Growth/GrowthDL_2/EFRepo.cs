using System;
using GrowthModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthDL
{
    public class EFRepo : IEFRepo
    {
        private GrowthDBContext db; // private variable for db

        public EFRepo(GrowthDBContext db) // constructor
        {
            this.db = db;
        }
        public UserAccount AddUser(UserAccount newuser)
        {
            db.Users.Add(newuser);
            db.SaveChanges();
            return newuser;
        }

        public List<UserAccount> GetAllUsers()
        {
            return db.Users.ToList();
        }
    }
}
