namespace DSS.Models2
{
    public enum Gender {Male, Female};

    public class Man
    {
        public string LastName = "";

        public string FirstName = "";

        public Gender Gender = Gender.Male;

        public string Nationality = "";

        
        public PostalAdress Adress = new PostalAdress()
        {
            Street = "",
            City = "",
            PostalCode = "",
            State = "",

        };

    }
}