using GrowthBL;
using GrowthModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GrowthAPI.JWT
{
    public class JWT : IJWT
    {
        readonly IConfiguration config;
        readonly ILogic logic;
        public JWT(IConfiguration config, ILogic logic)
        {
            this.config = config;
            this.logic = logic;
        }

        public Tokens AuthUser(UserAccount user)
        {
            var tokenhander = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.UTF8.GetBytes(config["JWT:Key"]);
            if (logic.AuthUser(user) == false)
            {
                return null;
            }
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.Username)
                    }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256),
            };
            var token = tokenhander.CreateToken(tokenDescriptor);
            return new Tokens { Validation = tokenhander.WriteToken(token) };
        }
    }
}
