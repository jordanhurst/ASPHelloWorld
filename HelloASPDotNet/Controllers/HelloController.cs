using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNet.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" +
                "<select name='language'>" +
                    "<option value='english'>English</option>" +
                    "<option value='french'>French</option>" +
                    "<option value='spanish'>Spanish</option>" +
                    "<option value='german'>German</option>" +
                    "<option value='latin'>Latin</option>" +
                "<input type='submit' value='Say Hi' />" +
                "</form>";
            return Content(html, "text/html");
        }

        // Post: /helloworld/
        //[HttpGet("/welcome/{name?}")]
        //[HttpPost]
        //public IActionResult Welcome(string name = "World")
        //{
        //    return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        //}

        //Post: /helloWorld/
        [HttpGet("/welcome/{name?}/{language?}")]
        [HttpPost]
        public IActionResult CreateMessage(string name = "World", string language = "english")
        {
            if (String.IsNullOrEmpty(name))
            {
                name = "World";
            }
            if (language == "french")
            {
                return Content("<h1>Bonjour, " + name + "!</h1>", "text/html");
            }

            else if (language == "spanish")
            {
                return Content("<h1>Hola, " + name + "!</h1>", "text/html");
            }

            else if (language == "german")
            {
                return Content("<h1>Hallo, " + name + "!</h1>", "text/html");
            }

            else if (language == "latin")
            {
                return Content("<h1>Salve, " + name + "!</h1>", "text/html");
            }

            else
            {
                return Content("<h1>Hello, " + name + "!</h1>", "text/html");
            }
        }
    }
}
