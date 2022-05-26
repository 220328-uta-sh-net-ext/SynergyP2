using System;
using GrowthModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthDL
{
    public interface IEFRepo
    {
        /// <summary>
        /// will add a user's info to the db
        /// </summary>
        /// <param name="userAccount"></param>
        /// <returns>the new user's info</returns>
        UserAccount AddUser(UserAccount newuser);

        /// <summary>
        /// will return all the users in the db
        /// </summary>
        /// <returns>all the users in the db</returns>
        List<UserAccount> GetAllUsers();
    }
}
