namespace CompanyEmployees.Emploees
{
    public class Emploee
    {
        //фио, пол, должность(перечисление 10 должностей), возраст
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string MiddleName { get; init; }
        public Gender Gender { get; init; }
        public Post Post { get; init; }
        public int Age { get; init; }

        public Emploee(string firstName, string lastName, string middleName,
            Gender gender, Post post, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Gender = gender;
            Post = post;
            Age = age;
        }
    }
}
