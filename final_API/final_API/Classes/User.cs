namespace final_API.Classes
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public double Salary { get; set; }

        public bool IsBlocked { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public List<Loan> loans { get; set; } = new List<Loan>();
    }
}
