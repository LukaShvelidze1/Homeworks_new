using final_API.Classes;

namespace final_API.Interfaces
{
    public interface IUserServiceInterface
    {
        Loan CheckLoan(int id);
        Loan UpdateLoan();
        Loan DeleteLoan(int id);
    }
}
