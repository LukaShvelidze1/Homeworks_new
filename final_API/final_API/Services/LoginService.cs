using final_API.Classes;
using final_API.Interfaces;
using final_API.Models;


namespace final_API.Services
{
    public class LoginService : IUserLoginInterface
    {
        private readonly UserContext _userContext;
        public LoginService(UserContext userContext)
        {
            _userContext = userContext;
        }

        public User Login(LoginModel user)
        {
            var login = _userContext.Users.Where(x => x.UserName == user.UserName).FirstOrDefault();
            if (login == null )
            {
                return null;
            }

            if (login.Password != user.Password)
                return null;
            return login;
        }
    }
}
