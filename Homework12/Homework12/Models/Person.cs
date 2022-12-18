namespace Homework12.Models
{
    public class Person
    {
       public DateTime CreateDate { get; set; }
        
       public string Firstname { get; set; }

       public string Lastname { get; set; }

       public string JobPosition { get; set; }

       public double Salary { get; set; }

       public double Workexperience { get; set; }

       public Adress PersonAdress { get; set;}

    }

    public class Adress
    {
        public string Country { get; set; }

        public string City { get; set; }

        public double HomeNumber { get; set; }
    }
}
