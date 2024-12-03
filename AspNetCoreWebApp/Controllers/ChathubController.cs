using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AspNetCoreWebApp.Controllers
{
    [Authorize]
    public class ChathubController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}