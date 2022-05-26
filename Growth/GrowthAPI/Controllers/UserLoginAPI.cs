using GrowthBL;
using GrowthDL;
using GrowthModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

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
            newList = logic.GetUserAccount(Username);
            if (newList.Count > 0 )
            {
                return BadRequest($"{Username} in use, try a different Username");
            }
            UserAccount newUser = new UserAccount();
            newUser.Username = Username;
            newUser.Password = Password;
            newUser.Email = Email;
            newUser.PhoneNumber = PhoneNumber;
            try
            {
                repo.AddUser(newUser);
                return CreatedAtAction("AddNewAccount", newUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
