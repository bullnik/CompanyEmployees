namespace CompanyEmployees.Models.Emploees
{
    public class Employee
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string MiddleName { get; init; }
        public Gender Gender { get; init; }
        public Post Post { get; init; }
        public int Age { get; init; }
        public long Id { get; init; }

        private static long _count = 0;

        public Employee(string firstName, string lastName, string middleName,
            Gender gender, Post post, int age)
        {
            _count += 1;
            Id = _count;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Gender = gender;
            Post = post;
            Age = age;
        }
    }
}
