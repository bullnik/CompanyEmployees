namespace CompanyEmployees.Models.Emploees
{
    public interface IGenerator<T>
    {
        IEnumerable<T> Generate(int count);
        T Generate();
    }
}
