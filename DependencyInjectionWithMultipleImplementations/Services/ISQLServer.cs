namespace DependencyInjectionWithMultipleImplementations.Services
{
    public interface ISQLServer:ICRUDRepository
    {
        void methSQLServer1();
        void methSQLServer2();
        void methSQLServer3();
    }
}
