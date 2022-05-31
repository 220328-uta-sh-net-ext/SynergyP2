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
        /*[AllowAnonymous]
        [HttpPost]
        [Route("CreateProfile")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult AddNewProfile([FromQuery][BindRequired]string Username, [BindRequired] int Height, [BindRequired] int Weight)
        {
            List<HealthProfile> newProfile = new List<HealthProfile>();
            newList = 
        }*/
    }    
}
