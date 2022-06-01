using GrowthDL;
using GrowthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthBL
{
    public class Logic : ILogic
    {
        readonly IEFRepo repo;
        public Logic(IEFRepo repo)
        {
            this.repo = repo;
        }
        public List<UserAccount> GetUserAccount(string Username)
        {
            List<UserAccount> users = repo.GetAllUsers();
            var filteredUsers = users.Where(u => u.Username.Equals(Username)).ToList();
            return filteredUsers;
        }
        public List<UserAccount> GetUserPassword(string Password)
        {
            List<UserAccount> passwords = repo.GetAllUsers();
            var filteredPasswords = passwords.Where(u => u.Password.Equals(Password)).ToList();
            return filteredPasswords;
        }
        public List<Goals> GetGoal(string Goal)
        {
            List<Goals> goals = repo.GetAllGoals();
            var filteredgoals = goals.Where(g => g.GoalName.Equals(Goal)).ToList();
            return filteredgoals;
        }
        public List<HealthProfile> GetHealthProfile(string Username)
        {
            List<HealthProfile> profiles = repo.GetHealthProfiles();
            var filteredprofiles = profiles.Where(p => p.Username.Equals(Username)).ToList();
            return filteredprofiles;
        }
        public bool AuthUser(UserAccount user)
        {
            List<UserAccount> users = repo.GetAllUsers();
            if (users.Exists(u => u.Username == user.Username && u.Password == user.Password))
            {
                return true;
            }
            return false;
        }
    }
}
