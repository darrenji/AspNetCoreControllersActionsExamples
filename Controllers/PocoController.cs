using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ModelBinding;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreControllersActionsExamples.Controllers
{
    public class PocoController 
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View("Result","This is a POCO controller");
        //}

        public ViewResult Index()
        {
            return new ViewResult() {
                ViewName="Result",

                //视图页需要拿到一个Model属性，原来这个属性是在ViewData中的
                //视图页拿到的数据是一个ViewDataDictionary类型
                //而ViewDatDictionary的形成与元数据提供者ModelMetadataProvider和模型状态ModelStateDictionary有关
                ViewData= new ViewDataDictionary(
                        new EmptyModelMetadataProvider(),
                        new ModelStateDictionary())
                {
                    Model = $"This is a POCO controller"
                }
            };
        }

        [ControllerContext]
        public ControllerContext ControllerContext { get; set; }

        public ViewResult Headers()
        {
            return new ViewResult() {
                ViewName= "DictionaryResult",
                ViewData=new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary()) {
                    Model = ControllerContext.HttpContext.Request.Headers.ToDictionary(kvp => kvp.Key, kvp=>kvp.Value.First())
                }
            };
        }
    }
}
