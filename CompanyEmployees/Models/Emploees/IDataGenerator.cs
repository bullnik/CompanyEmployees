using System;

namespace CompanyEmployees.Models.Emploees
{
    public interface IDataGenerator
    {
        IEnumerable<Employee> GenerateEmployee(int count);

        Vacation GenerateVacation(Employee employee, int duration);

        Employee GenerateEmployee();
    }
}
