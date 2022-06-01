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
        [Route("Create/Profile")]
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
            newProfile.CurrentDate = null;
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
        [AllowAnonymous]
        [HttpGet]
        [Route("Search/Profiles")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<List<HealthProfile>> SearchAllProfiles(string Username)
        {
            List<HealthProfile> usernames = new List<HealthProfile>();
            try
            {
                usernames = logic.GetHealthProfile(Username);
                if (usernames.Count <= 0)
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
        [HttpPost]
        [Route("Create/Goals")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult AddNewGoal(string Goal, string Description, string Habit1, string Habit2, string Habit3)
        {
            List<Goals> newList = new List<Goals>();
            newList = logic.GetGoal(Goal);
            if (newList.Count > 0)
            {
                return BadRequest($"Goal with {Goal} name already created");
            }
            Goals newGoals = new Goals();
            newGoals.GoalName = Goal;
            newGoals.Description = Description;
            newGoals.Habit1 = Habit1;
            newGoals.Habit2 = Habit2;
            newGoals.Habit3 = Habit3;
            try
            {
                repo.AddGoal(newGoals);
                return CreatedAtAction("AddNewGoal", newGoals);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("Search/Goals")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<List<Goals>> SearchAllGoals(string Goal)
        {
            List<Goals> goals = new List<Goals>();
            try
            {
                goals = logic.GetGoal(Goal);
                if (goals.Count <= 0)
                {
                    return NotFound($"No goal with the name {Goal}.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(goals);
        }
    }    
}
