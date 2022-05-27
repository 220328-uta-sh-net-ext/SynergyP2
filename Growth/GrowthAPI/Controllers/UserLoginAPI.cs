using GrowthAPI.JWT;
using GrowthBL;
using GrowthDL;
using GrowthModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace GrowthAPI.Controllers
{
    [Route("contoller")]
    [ApiController]
    public class UserLoginAPI : ControllerBase
    {
        readonly IEFRepo repo;
        readonly ILogic logic;
        readonly IJWT jwt;
        public UserLoginAPI(IEFRepo repo, ILogic logic, IJWT jwt)
        {
            this.repo = repo;
            this.logic = logic;
            this.jwt = jwt; 
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
        [AllowAnonymous]
        [HttpPost]
        [Route("Authenticate/User")]
        public IActionResult Authenticate([FromQuery]UserAccount user)
        {
            var auth = jwt.AuthUser(user);
            try
            {
                if (auth == null)
                {
                    return BadRequest("Incorrect Login Credentials");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(auth);
        }
    }
}
