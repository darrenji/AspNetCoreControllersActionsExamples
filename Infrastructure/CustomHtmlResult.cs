using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreControllersActionsExamples.Infrastructure
{
    public class CustomHtmlResult:IActionResult
    {
        public string Content { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            //ActionContext在Action中，通过它可以获取HttpContxt
            context.HttpContext.Response.StatusCode = 200;
            context.HttpContext.Response.ContentType = "text/html";
            byte[] content = Encoding.ASCII.GetBytes(Content);
            return context.HttpContext.Response.Body.WriteAsync(content, 0, content.Length);
        }
    }
}
