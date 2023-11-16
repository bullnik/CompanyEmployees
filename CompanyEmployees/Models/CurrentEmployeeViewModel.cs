using CompanyEmployees.Models.Emploees;

namespace CompanyEmployees.Models
{
    public class CurrentEmployeeViewModel
    {
        public Employee CurrentEmployee { get; init; }
        //* Пересечение отпуска с сотрудниками моего отдела.Сотрудники моложе 30 лет.
        public IEnumerable<Employee> EmployeesFirstGroup { get; init; }
        //* Пересечение отпуска с сотрудниками-женщинами не из моего отдела.Возраст сотрудников - старше 30, но моложе 50.
        public IEnumerable<Employee> EmployeesSecondGroup { get; init; }
        //* Пересечение отпуска с сотрудниками из любого отдела.Возраст сотрудников - старше 50 лет.
        public IEnumerable<Employee> EmployeesThirdGroup { get; init; }
        //* Отпуска без пересечения.
        public IEnumerable<Employee> EmployeesFourthGroup { get; init; }

        public CurrentEmployeeViewModel(Employee currentEmployee,
            IEnumerable<Employee> firstGroup,
            IEnumerable<Employee> secondGroup,
            IEnumerable<Employee> thirdGroup,
            IEnumerable<Employee> fourthGroup) 
        {
            CurrentEmployee = currentEmployee;
            EmployeesFirstGroup = firstGroup;
            EmployeesSecondGroup = secondGroup;
            EmployeesThirdGroup = thirdGroup;
            EmployeesFourthGroup = fourthGroup;
        }
    }
}
