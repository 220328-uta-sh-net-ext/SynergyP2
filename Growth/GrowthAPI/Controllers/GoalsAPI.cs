using GrowthAPI.JWT;
using GrowthBL;
using GrowthDL;
using GrowthModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GrowthAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GoalsAPI : Controller
    {
        readonly IEFRepo repo;
        readonly ILogic logic;
        readonly IJWT jwt;

        public GoalsAPI(IEFRepo repo, ILogic logic, IJWT jwt)
        {
            this.repo = repo;
            this.logic = logic;
            this.jwt = jwt;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("CreateProfile")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult AddNewProfile(string Username, string Height, int Weight)
        {
            List<HealthProfile> newList = new List<HealthProfile>();
            newList = logic.GetHealthProfile(Username);
            if (newList.Count > 0)
            {
                return BadRequest($"Profile with {Username} already has a profile");
            }
            HealthProfile newProfile = new HealthProfile();
            newProfile.Username = Username;
            newProfile.Height = Height;
            newProfile.Weight = Weight;
            try
            {
                repo.AddProfile(newProfile);
                return CreatedAtAction("AddNewProfile", newProfile);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }    
}
