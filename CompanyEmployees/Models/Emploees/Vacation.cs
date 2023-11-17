namespace CompanyEmployees.Models.Emploees
{
    public class Vacation
    {
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public Employee Employee { get; set; }

        public Vacation(DateTime startDate, DateTime endDate, Employee emploee)
        {
            StartDate = startDate;
            EndDate = endDate;
            Employee = emploee;
        }
    }
}
