using GrowthBL;
using GrowthDL;
using GrowthModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GrowthAPI.Controllers
{
        [Route("[Contoller]")]
        [ApiController]
        public class UserLoginAPI : Controller
        {
            readonly IEFRepo repo;
            readonly ILogic logic;
            public UserLoginAPI(IEFRepo repo, ILogic logic)
            {
                this.repo = repo;
                this.logic = logic;
            }
            [AllowAnonymous]
            [HttpPost]
            [Route("CreateAccount")]
            [ProducesResponseType(201)]
            [ProducesResponseType(400)]
            public ActionResult AddNewAccount([FromQuery][BindRequired] string Username, [BindRequired][DataType(DataType.Password)] string Password, [BindRequired] string Email, string? PhoneNumber)
            {
                List<UserAccount> newList = new List<UserAccount>();
                newList = logic.GetUserAccount
            }
        }
    }
}
