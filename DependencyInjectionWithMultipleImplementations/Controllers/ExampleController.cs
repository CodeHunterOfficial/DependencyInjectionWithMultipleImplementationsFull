using DependencyInjectionWithMultipleImplementations.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionWithMultipleImplementations.Controllers
{
    [Route("example")]
    public class ExampleController : Controller
    {
        private ICRUDRepository _cRUDRepository;

        public ExampleController(IEnumerable<ICRUDRepository> cRUDRepositories)
        {
            _cRUDRepository=cRUDRepositories.FirstOrDefault(x => x.Type == "Mongo");
            
        }
        [Route("index")]
        public IActionResult Index()
        {
            var crudRepository = (IMongo)_cRUDRepository;
            crudRepository.Create();
            crudRepository.Delete();
            crudRepository.Update();
            crudRepository.MethMongo1();
            crudRepository.MethMongo2();
            return View("Index");
        }
    }
}
