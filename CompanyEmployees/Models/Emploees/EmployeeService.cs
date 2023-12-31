﻿using System.Linq;

namespace CompanyEmployees.Models.Emploees
{
    public class EmployeeService : IEmployeeService
    {
        public IEnumerable<Employee> Employees => _employees;
        public IEnumerable<Vacation> Vacations => _vacations;

        private readonly List<Employee> _employees;
        private readonly List<Vacation> _vacations;

        public EmployeeService(IDataGenerator dataGenerator)
        {
            _employees = dataGenerator.GenerateEmployee(100).ToList();
            _vacations = new();
            _employees.ForEach(employee =>
            {
                _vacations.Add(dataGenerator.GenerateVacation(employee, 14));
                _vacations.Add(dataGenerator.GenerateVacation(employee, 7));
                _vacations.Add(dataGenerator.GenerateVacation(employee, 7));
            });
        }

        //* Пересечение отпуска с сотрудниками моего отдела.Сотрудники моложе 30 лет.
        public IEnumerable<Vacation> GetVacationIntersectionsWithSameDepartmentAndUnderThirtyYears(Vacation vacation)
        {
            return from vac in _vacations
                   where vac.Employee.Age < 30
                   where vac.Employee.Department == vacation.Employee.Department
                   where !(vac.EndDate < vacation.StartDate 
                        || vac.StartDate > vacation.EndDate)
                   where vac.Employee.Id != vacation.Employee.Id
                   select vac;
        }

        //* Пересечение отпуска с сотрудниками-женщинами не из моего отдела.Возраст сотрудников - старше 30, но моложе 50.
        public IEnumerable<Vacation> GetVacationIntersectionsWithFemalesDifferentDepartmentBetweenThirtyAndFiftyYears(Vacation vacation)
        {
            return from vac in _vacations
                   where vac.Employee.Gender == Gender.Female
                   where vac.Employee.Department != vacation.Employee.Department
                   where vac.Employee.Age > 30 && vac.Employee.Age < 50
                   where !(vac.EndDate < vacation.StartDate
                        || vac.StartDate > vacation.EndDate)
                   where vac.Employee.Id != vacation.Employee.Id
                   select vac;
        }

        //* Пересечение отпуска с сотрудниками из любого отдела.Возраст сотрудников - старше 50 лет.
        public IEnumerable<Vacation> GetVacationIntersectionsWithEmployeesAboveFiftyYears(Vacation vacation)
        {
            return from vac in _vacations
                   where vac.Employee.Age > 50
                   where !(vac.EndDate < vacation.StartDate
                        || vac.StartDate > vacation.EndDate)
                   where vac.Employee.Id != vacation.Employee.Id
                   select vac;
        }

        //* Отпуска без пересечения.
        public IEnumerable<Vacation> GetVacationsWithoutIntersections(Vacation vacation)
        {
            return from vac in _vacations
                   where vac.Employee.Id != vacation.Employee.Id
                   where vac.EndDate < vacation.StartDate
                        || vac.StartDate > vacation.EndDate
                   select vac;
        }

        public bool InsertNewVacation(int employeeId, DateTime start, int duration, out Vacation? vacation)
        {
            if (!GetEmployeeById(employeeId, out Employee? employee) 
                || employee is null)
            {
                vacation = null;
                return false;
            }
            vacation = new(start, start + TimeSpan.FromDays(duration - 1), employee);
            _vacations.Add(vacation);
            return true;
        }

        public bool GetEmployeeById(int id, out Employee? employee)
        {
            employee = _employees.FirstOrDefault(emp => emp.Id == id);
            return employee is not null;
        }

        public IEnumerable<Vacation> GetVacationsByEmployee(Employee employee)
        {
            return _vacations.Where(vacation => vacation.Employee == employee);
        }
    }
}
