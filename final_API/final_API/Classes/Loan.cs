namespace final_API.Classes
{
    public class Loan
    {
        public string LoanID { get; set; }
        
        public string LoanType { get; set; }

        public double Amount { get; set; }

        public string Currency { get; set; }

        public string LoanPeriod { get; set; }

        public string Status { get; set; }

        public User User { get; set; }
    }
}
