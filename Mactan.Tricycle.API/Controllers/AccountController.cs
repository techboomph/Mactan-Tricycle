using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Mactan.Tricycle.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Mactan.Tricycle.Controllers
{
    [Produces("application/json")]
    [Route("api/Account")]
    // [Authorize]
    public class AccountController : Controller
    {
      
        private IConfiguration _configuration;
        public AccountController(IConfiguration configuration)
        {
          _configuration = configuration;
        }

        [Route("login"), HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody]LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
               if(request.username.ToUpper() == "ADMIN" && request.password.ToUpper() == "ADMIN")
               {
                   string token = BuildToken(request.username);
                   return Ok(token);
               }

               return Unauthorized();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private string BuildToken(string user)
        {
            IList<Claim> claims = GetValidClaims(user);

            var token = new JwtSecurityToken(
                issuer: _configuration["Issuer"],
                audience: _configuration["Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(60),
                notBefore: DateTime.Now,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SigningKey"])),
                            SecurityAlgorithms.HmacSha256)
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private IList<Claim> GetValidClaims(string user)
        {
            var claims = new List<Claim>()
            {
                new Claim("UserID", user),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };
            return claims;
        }

        
    }
}