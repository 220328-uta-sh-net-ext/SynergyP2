using GrowthBL;
using GrowthDL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GrowthModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GrowthAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminAPI : Controller
    {
        readonly ILogic logic;
        readonly IEFRepo repo;
        public AdminAPI(ILogic logic, IEFRepo repo)
        {
            this.logic = logic;
            this.repo = repo;
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("Search/Users")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<List<UserAccount>> SearchAllUsers([BindRequired]string Username)
        {
            List<UserAccount> usernames = new List<UserAccount>();
            try
            {
                usernames = logic.GetUserAccount(Username);
                if(usernames.Count <= 0)
                {
                    return NotFound($"No users with the name {Username}.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(usernames);
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("SeeAll/Users")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<List<UserAccount>> SeeAllUsers()
        {
            List<UserAccount> usernames = repo.GetAllUsers();
            try
            {
                if(usernames.Count <= 0)
                {
                    return NotFound("No users showing from database");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(usernames);
        }
    }
}
