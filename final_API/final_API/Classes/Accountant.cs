namespace final_API.Classes
{
    public class Accountant
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
