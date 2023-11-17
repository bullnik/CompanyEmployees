namespace CompanyEmployees.Models.Emploees
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> Employees { get; }
        IEnumerable<Vacation> Vacations { get; }
        bool GetEmployeeById(int id, out Employee? employee);
        bool InsertNewVacation(int employeeId, DateTime start, int duration, out Vacation? vacation);
        IEnumerable<Vacation> GetVacationsByEmployee(Employee employee);
        IEnumerable<Vacation> GetFirstGroup(Vacation vacation);
        IEnumerable<Vacation> GetSecondGroup(Vacation vacation);
        IEnumerable<Vacation> GetThirdGroup(Vacation vacation);
        IEnumerable<Vacation> GetVacationsWithoutIntersections(Vacation vacation);
    }
}
