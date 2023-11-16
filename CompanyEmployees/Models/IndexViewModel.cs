using CompanyEmployees.Models.Emploees;

namespace CompanyEmployees.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Vacation> Vacations { get; set; }

        public IndexViewModel(IEnumerable<Employee> employees,
            IEnumerable<Vacation> vacations)
        {
            Employees = employees;
            Vacations = vacations;
        }
    }
}
