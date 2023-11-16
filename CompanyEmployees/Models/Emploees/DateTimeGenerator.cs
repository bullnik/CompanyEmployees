namespace CompanyEmployees.Models.Emploees
{
    public class DateTimeGenerator : IGenerator<DateTime>
    {
        private readonly Random _random = new();

        public IEnumerable<DateTime> Generate(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return Generate();
            }
        }

        public DateTime Generate()
        {
            return new DateTime(DateTime.Now.Year, 1, 1)
                + TimeSpan.FromDays(_random.Next(365));
        }
    }
}
