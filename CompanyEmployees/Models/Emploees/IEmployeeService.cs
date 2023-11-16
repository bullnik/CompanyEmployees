namespace CompanyEmployees.Models.Emploees
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> Employees { get; }
        IEnumerable<Vacation> Vacations { get; }
        bool GetEmployeeById(int id, out Employee? employee);
        IEnumerable<Employee> GetFirstGroup();
        IEnumerable<Employee> GetSecondGroup();
        IEnumerable<Employee> GetThirdGroup();
        IEnumerable<Employee> GetFourthGroup();
    }
}
