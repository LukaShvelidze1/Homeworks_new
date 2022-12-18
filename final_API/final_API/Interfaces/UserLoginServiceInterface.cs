using final_API.Classes;
using final_API.Models;

namespace final_API.Interfaces
{
    public interface IUserLoginInterface
    {
        User Login(LoginModel user);
    }
}
