using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ThemeController : Controller
    {
        public IActionResult ChangeTheme(string returnUrl)
        {
            if(Request.Cookies["theme"] == "dark")
            {
                HttpContext.Response.Cookies.Append("theme", "light");
            }
            else
            {
                HttpContext.Response.Cookies.Append("theme", "dark");
            }            
            return LocalRedirect(returnUrl);
        }
    }
}
