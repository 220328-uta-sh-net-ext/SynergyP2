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
        public HealthProfile AddProfile(HealthProfile newProfile)
        {
            db.HealthProfiles.Add(newProfile);
            db.SaveChanges();
            return newProfile;
        }
        public Goals AddGoal(Goals newGoal)
        {
            db.Goals.Add(newGoal);
            db.SaveChanges();
            return newGoal;
        }
        public List<HealthProfile> GetHealthProfiles()
        {
            return db.HealthProfiles.ToList();
        }
        public List<Goals> GetAllGoals()
        {
            return db.Goals.ToList();
        }
    }
}
