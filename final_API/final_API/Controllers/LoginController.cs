using final_API.Helper;
using final_API.Interfaces;
using final_API.Models;
using final_API.Validations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace final_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserLoginInterface _userService;
        private readonly Appsettings _appSettings;


        public LoginController(IUserLoginInterface userService, IOptions<Appsettings> appsettings)
        {
            _userService = userService;
            _appSettings = appsettings.Value;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            var user = _userService.Login(login);
            
            var Validator = new LoginValidator().Validate(login);
            if (!Validator.IsValid)
            {
                return BadRequest(Validator.Errors[0].ErrorMessage);
            }
            
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            // create JWT token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Name.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);


            return Ok(new
            {
                
                UserName = user.UserName,
                Password = user.Password,
                Token = tokenString
            });
            
         

        }
    }
}
