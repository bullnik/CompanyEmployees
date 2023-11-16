using System.Linq;

namespace CompanyEmployees.Models.Emploees
{
    public class EmployeeService : IEmployeeService
    {
        public IEnumerable<Employee> Employees => _employees;
        public IEnumerable<Vacation> Vacations => _vacations;

        private readonly IGenerator<Employee> _employeeGenerator;
        private readonly IGenerator<DateTime> _dateTimeGenerator;
        private readonly List<Employee> _employees;
        private readonly List<Vacation> _vacations;

        public EmployeeService(IGenerator<Employee> emploeeGenerator,
            IGenerator<DateTime> dateTimeGenerator)
        {
            _employeeGenerator = emploeeGenerator;
            _dateTimeGenerator = dateTimeGenerator;
            _employees = emploeeGenerator.Generate(100).ToList();
            _vacations = new();
            _employees.ForEach(employee => _vacations.AddRange(GenerateVacationsForEmployee(employee)));
        }

        public bool GetEmployeeById(int id, out Employee? employee)
        {
            employee = _employees.FirstOrDefault(emp => emp.Id == id);
            if (employee is null)
            {
                return false;
            }
            return true;
        }

        //* Пересечение отпуска с сотрудниками моего отдела.Сотрудники моложе 30 лет.
        public IEnumerable<Employee> GetFirstGroup(Employee employee)
        {
            return _employees.GetRange(10, 5);
        }
        //* Пересечение отпуска с сотрудниками-женщинами не из моего отдела.Возраст сотрудников - старше 30, но моложе 50.
        public IEnumerable<Employee> GetSecondGroup(Employee employee)
        {
            return _employees.GetRange(66, 4);
        }
        //* Пересечение отпуска с сотрудниками из любого отдела.Возраст сотрудников - старше 50 лет.
        public IEnumerable<Employee> GetThirdGroup(Employee employee)
        {
            return _employees.GetRange(17, 4);
        }
        //* Отпуска без пересечения.
        public IEnumerable<Employee> GetFourthGroup(Employee employee)
        {
            return _employees.GetRange(77, 3);
        }

        private IEnumerable<Vacation> GenerateVacationsForEmployee(Employee employee)
        {
            List<DateTime> dateTimes = _dateTimeGenerator.Generate(3).ToList();
            yield return new(dateTimes[0], dateTimes[0] + TimeSpan.FromDays(14), employee);
            yield return new(dateTimes[1], dateTimes[1] + TimeSpan.FromDays(7), employee);
            yield return new(dateTimes[2], dateTimes[2] + TimeSpan.FromDays(7), employee);
        }
    }
}
