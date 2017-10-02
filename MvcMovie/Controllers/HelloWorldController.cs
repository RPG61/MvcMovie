using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // Get: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int numTimes = 1) => HtmlEncoder.Default.Encode($"Hello {name}, Numtimes is: {numTimes}");
    }
}