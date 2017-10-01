using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreControllersActionsExamples.Controllers
{
    public class ExampleController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Message = "Hello";

            ViewBag.Date = DateTime.Now;
            return View(DateTime.Now);
        }

        public ViewResult Result()
        {
            //把字符串转换成对象传递给前端视图
            return View((object)"Hello World");
        }

        //使用字符串转向
        //public RedirectResult Redirect()
        //{
        //    return RedirectPermanent("/Example/Index");
        //}


        //转向到路由
        //public RedirectToRouteResult Redirect()
        //{
        //    return RedirectToRoute(new { controller="Example",action="Index", ID="MyID"});
        //}

        //转向到Action
        public RedirectToActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
