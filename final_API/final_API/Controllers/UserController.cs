using final_API.Helper;
using final_API.Interfaces;
using final_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace final_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserServiceInterface _userService;
        private readonly Appsettings _appSettings;
        
        public UserController(IUserServiceInterface userService, IOptions<Appsettings> appsettings)
        {
            
            _userService = userService;
            _appSettings = appsettings.Value;
        }

  
    }


}
