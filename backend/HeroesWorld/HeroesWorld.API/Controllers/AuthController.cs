using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace HeroesWorld.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        [HttpGet]
        [Route("login")]
        public IActionResult LogIn(string name, string password)
        {
            if(name == "a" && password == "a")
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, "a"),
                                                new Claim(ClaimTypes.Role, "admin")};
                var jwt = new JwtSecurityToken(
            issuer: AuthConfigs.ISSUER,
            audience: AuthConfigs.AUDIENCE,
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(1)),
            signingCredentials: new SigningCredentials(AuthConfigs.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            string finalRoken = new JwtSecurityTokenHandler().WriteToken(jwt);
            this.HttpContext.Response.Cookies.Append("jwtToken", finalRoken);
            return StatusCode(200);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("logout")]
        public IActionResult LogOut()
        {
            this.HttpContext.Response.Cookies.Delete("jwtToken");
            return StatusCode(200);
        }

        [HttpGet]
        [Route("test")]
        [Authorize]
        public async Task<IActionResult> TestFunc()
        {
            return StatusCode(200);
        }
    }
}
