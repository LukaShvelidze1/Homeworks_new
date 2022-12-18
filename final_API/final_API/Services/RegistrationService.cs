using final_API.Classes;
using final_API.Interfaces;
using final_API.Models;

namespace final_API.Services
{
    public class RegistrationService : IUserRegistrationInterface
    {
        private readonly UserContext _userContext;
        public RegistrationService(UserContext userContext)
        {
            _userContext = userContext;
        }

        public User Registration(RegistrationModel user)
        {
            var userEmail = _userContext.Users.Where(x => x.Email == user.Email).FirstOrDefault();
            if (userEmail == null)
            {
                var newUser = new User();
                newUser.Email = user.Email;
                newUser.Age = user.Age;
                newUser.UserName = user.UserName;
                newUser.Password = new PasswordHashing().HashPassword(user.Password);
                newUser.Name = user.Name;
                newUser.LastName = user.LastName;
                newUser.Salary = user.Salary;

                _userContext.Add(newUser);
                _userContext.SaveChanges();
                return newUser;
            }
            return null;
        }
    }
}
