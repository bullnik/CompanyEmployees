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
        public Department Department { get; init; }

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
            Department = GetDepartmentFromPost(post);
        }

        private Department GetDepartmentFromPost(Post post)
        {
            return post switch
            {
                Post.Cashier 
                or Post.Administrator 
                or Post.Seller 
                or Post.Merchandiser => Department.TradingFloor,
                Post.Storekeeper 
                or Post.Loader 
                or Post.WarehouseManager => Department.Store,
                Post.Director 
                or Post.Lawyer 
                or Post.Economist => Department.Directorate,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
