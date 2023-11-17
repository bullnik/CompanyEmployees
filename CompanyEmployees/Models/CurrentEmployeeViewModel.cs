using CompanyEmployees.Models.Emploees;

namespace CompanyEmployees.Models
{
    public class CurrentEmployeeViewModel
    {
        public Employee CurrentEmployee { get; init; }
        public IEnumerable<Vacation> Vacations { get; init; }

        public CurrentEmployeeViewModel(Employee currentEmployee,
            IEnumerable<Vacation> vacations) 
        {
            CurrentEmployee = currentEmployee;
            Vacations = vacations;
        }
    }
}
