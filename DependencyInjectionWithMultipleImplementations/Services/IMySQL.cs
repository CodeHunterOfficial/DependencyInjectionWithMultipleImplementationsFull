namespace DependencyInjectionWithMultipleImplementations.Services
{
    public interface IMySQL:ICRUDRepository
    {
        void methMySQL1();
        void methMySQL2();
    }
}
