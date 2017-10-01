using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using AspNetCoreControllersActionsExamples.Infrastructure;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreControllersActionsExamples.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("SimpleForm");
        }

        //使用HttpRequest接收数据
        //public ViewResult ReceiveForm()
        //{
        //    var name = Request.Form["name"];
        //    var city = Request.Form["city"];
        //    return View("Result", $"{name} lives in {city}");
        //}

        
        //使用方法参数接受数据
        //public ViewResult ReceiveForm(string name, string city)
        //{
        //    return View("Result", $"{name} lives in {city}");
        //}


        //使用HttpResonse返回给前端数据
        //public void ReceiveForm(string name, string city)
        //{
        //    Response.StatusCode = 200;
        //    Response.ContentType = "text/html";
        //    byte[] content = Encoding.ASCII.GetBytes($"<html><body>{name} lives in {city}</body></html>");
        //    Response.Body.WriteAsync(content, 0, content.Length);
        //}


        //使用自定义的IActionResult返回给前端数据
        //public IActionResult ReceiveForm(string name, string city)
        //{
        //    return new CustomHtmlResult
        //    {
        //        Content = $"{name} lives in {city}"
        //    };
        //}

        
        //最正常的写法
        public ViewResult ReceiveForm(string name, string city)
        {
            return View("Result", $"{name} lives in {city}");
        }
    }
}
