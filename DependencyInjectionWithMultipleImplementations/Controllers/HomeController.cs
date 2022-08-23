using DependencyInjectionWithMultipleImplementations.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionWithMultipleImplementations.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {       
        private readonly Func<int, ICRUDRepository> _crudRepositories;
        public HomeController(Func<int, ICRUDRepository> crudRepositories)
        {
            _crudRepositories = crudRepositories;
        }
        [Route("index")]
        public IActionResult Index()
        {        
            _crudRepositories(1).Create();
            _crudRepositories(1).Update();
            _crudRepositories(1).Delete();
            return View("Index");
        }
    }
}
