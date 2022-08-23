using System.Diagnostics;

namespace DependencyInjectionWithMultipleImplementations.Services
{
    public class CRUDRepositoryWithMongoDB:MainCRUD, IMongo
    {       
        public string Type => "Mongo";

        public void MethMongo1()
        {
            Debug.WriteLine("MethMongo1 in MongoDB DataBase");
        }

        public void MethMongo2()
        {
            Debug.WriteLine("MethMongo2 in MongoDB DataBase");
        }
    }
}
