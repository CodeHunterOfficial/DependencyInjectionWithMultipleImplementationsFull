using System.Diagnostics;

namespace DependencyInjectionWithMultipleImplementations.Services
{
    public class CRUDRepositoryWithMySQL:MainCRUD, IMySQL
    {
         public void methMySQL1()
        {
            Debug.WriteLine("meth1");
        }

        public void methMySQL2()
        {
            Debug.WriteLine("meth2");
        }

    }
}
