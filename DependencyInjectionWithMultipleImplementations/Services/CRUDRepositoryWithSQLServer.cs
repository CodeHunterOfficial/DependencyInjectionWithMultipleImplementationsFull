using System.Diagnostics;

namespace DependencyInjectionWithMultipleImplementations.Services
{
    public class CRUDRepositoryWithSQLServer : MainCRUD, ISQLServer
    {
        public void methSQLServer1()
        {
            Debug.WriteLine("methSQLServer1");
        }

        public void methSQLServer2()
        {
            Debug.WriteLine("methSQLServer2");
        }

        public void methSQLServer3()
        {
            Debug.WriteLine("methSQLServer3");
        }
    }
}
