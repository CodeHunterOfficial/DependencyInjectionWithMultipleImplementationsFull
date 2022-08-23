 namespace DependencyInjectionWithMultipleImplementations.Services
{
    public interface ICRUDRepository
    {
        string Type { get; }
        void Create();
         void Update();
         void Delete();
    }
}
