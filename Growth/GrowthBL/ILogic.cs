using GrowthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowthBL
{
    public interface ILogic
    {
        List<UserAccount> GetUserPassword(string Password);
        List<UserAccount> GetUserAccount(string Username);
        bool AuthUser(UserAccount user);
        List<HealthProfile> GetHealthProfile(string Username);
        List<Goals> GetGoal(string Goal);
    }
}
