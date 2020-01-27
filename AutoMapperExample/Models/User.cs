namespace AutoMapperExample.Models
{
    public class User
    {
        public User(int id, string firstName, string lastName, string emailAddress, bool? admin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Admin = admin;
        }

        public int Id { get;}
        public string FirstName { get; }
        public string LastName { get; }
        public string EmailAddress { get; }
        public bool ?Admin { get; set; }
    }
}
