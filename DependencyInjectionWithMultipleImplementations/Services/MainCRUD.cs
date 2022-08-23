using System.Diagnostics;

namespace DependencyInjectionWithMultipleImplementations.Services
{
    public class MainCRUD : ICRUDRepository
    {
        public string Type { get { return "Main"; } }
        

        public void Create()
        {
            Debug.WriteLine("Create in Main");
        }

        public void Delete()
        {
            Debug.WriteLine("Delete on Main");
        }

        public void Update()
        {
            Debug.WriteLine("Update in Main");
        }
    }
}
