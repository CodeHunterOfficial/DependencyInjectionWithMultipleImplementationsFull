using DependencyInjectionWithMultipleImplementations.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionWithMultipleImplementations.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {

        private readonly IEnumerable<ICRUDRepository> _crudRepositories;
        public DemoController(IEnumerable<ICRUDRepository> crudRepositories)
        {
            _crudRepositories = crudRepositories; 
        }
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            var crudRepository=_crudRepositories.SingleOrDefault(s=>s.GetType()==typeof(CRUDRepositoryWithMongoDB));
             crudRepository.Create();
            crudRepository.Delete();
            crudRepository.Update();
            return View();
        }

       
        [Route("index2")]
        public IActionResult Index2()
        {
            var crudRepository =(IMySQL) _crudRepositories.SingleOrDefault(s => s.GetType() == typeof(CRUDRepositoryWithMySQL));
            crudRepository.Create();
            crudRepository.Delete();
            crudRepository.Update();
            crudRepository.methMySQL1();
            crudRepository.methMySQL2();
            return View("Index");
        }

        [Route("index3")]
        public IActionResult Index3()
        {
            var crudRepository = (ISQLServer)_crudRepositories.SingleOrDefault(s => s.GetType() == typeof(CRUDRepositoryWithSQLServer));
            crudRepository.Create();
            crudRepository.Delete();
            crudRepository.Update();
            crudRepository.methSQLServer1();
            crudRepository.methSQLServer2();
            crudRepository.methSQLServer3();
            return View("Index");
        }
    }
}
