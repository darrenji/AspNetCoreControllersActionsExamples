using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreControllersActionsExamples.Controllers
{
    public class DerivedController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Result", $"This is a derived controller");
        }

        public ViewResult Headers()
        {
            //通过Request属性获取到一些表头信息
            return View("DictionaryResult", Request.Headers.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First()));
        }
    }
}
