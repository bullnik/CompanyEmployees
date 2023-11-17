using CompanyEmployees.Models.Emploees;

namespace CompanyEmployees.Models
{
    public class VacationIntersectionsViewModel
    {
        //* Пересечение отпуска с сотрудниками моего отдела.Сотрудники моложе 30 лет.
        public IEnumerable<Vacation> EmployeesFirstGroup { get; init; }
        //* Пересечение отпуска с сотрудниками-женщинами не из моего отдела.Возраст сотрудников - старше 30, но моложе 50.
        public IEnumerable<Vacation> EmployeesSecondGroup { get; init; }
        //* Пересечение отпуска с сотрудниками из любого отдела.Возраст сотрудников - старше 50 лет.
        public IEnumerable<Vacation> EmployeesThirdGroup { get; init; }
        //* Отпуска без пересечения.
        public IEnumerable<Vacation> EmployeesFourthGroup { get; init; }

        public VacationIntersectionsViewModel(
            IEnumerable<Vacation> firstGroup,
            IEnumerable<Vacation> secondGroup,
            IEnumerable<Vacation> thirdGroup,
            IEnumerable<Vacation> fourthGroup) 
        {
            EmployeesFirstGroup = firstGroup;
            EmployeesSecondGroup = secondGroup;
            EmployeesThirdGroup = thirdGroup;
            EmployeesFourthGroup = fourthGroup;
        }
    }
}
