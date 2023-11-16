namespace CompanyEmployees.Emploees
{
    public class Vacation
    {
        public DateOnly StartDate { get; init; }
        public DateOnly EndDate { get; init; }
        public Emploee Emploee { get; init; }

        public Vacation() 
        {

        }
    }
}
