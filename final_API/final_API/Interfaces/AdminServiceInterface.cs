using final_API.Classes;

namespace final_API.Interfaces
{
    public interface IAdminServiceInterface
    {
        Loan CheckLoan(int id);
        Loan UpdateLoan();
        Loan DeleteLoan(int id);
        User BlockUser(int id);

    }
}
