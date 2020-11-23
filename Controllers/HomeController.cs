using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebApplication1.Classes;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{        
    public class HomeController : Controller
    {        
        private readonly ApplicationDbContext db;        
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        
        public HomeController(ApplicationDbContext context, SignInManager<User> signInManager, UserManager<User> userManager)
        {            
            db = context;            
            this.signInManager = signInManager;
            this.userManager = userManager;
        }        
        
        public IActionResult Index()
        {            
            ViewBag.Stories = db.Stories;            
            return View();            
        }

        [Authorize (Roles ="Admin")]
        [Authorize(Roles = "Active")]
        public IActionResult AdminPage()
        {
            if (!User.IsInRole("Admin") || !User.IsInRole("Active"))
                return RedirectToAction("Logout");
            ViewBag.Users = db.Users;     
            return View();
        }

        [Authorize (Roles ="Active")]        
        public IActionResult PersonalPage(string id)
        {
            User user = UserFinder.GetByEmail(db, id);                       
            if (CheckOnAccess(user))
            {
                ViewBag.User = user;
                ViewBag.Stories = user.GetStories(db);
                return View();
            }
            return RedirectToAction("UserPage", new { Id = id});            
        }

        private bool CheckOnAccess(User user)
        {            
            if (User.Identity.Name == user.Email || User.IsInRole("Admin"))
            {
                return true;
            }
            return false;
        }

        public IActionResult UserPage(string Id)
        {    
            User user = UserFinder.GetByEmail(db, Id);            
            if (CheckOnAccess(user))
            {
                return RedirectToAction("PersonalPage", new { id = user.Email});
            }
            ViewBag.User = user;
            ViewBag.Stories = user.GetStories(db);
            return View();
        }

        [Authorize(Roles = "Active")]
        [HttpPost]
        public async Task ChangeUserInfo(string newValue, string email)
        {            
            User User = UserFinder.GetByEmail(db, email);
            User.UserInfo = newValue;
            await db.SaveChangesAsync();
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {            
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)));
            return LocalRedirect(returnUrl);
        }

        [HttpGet]
        public string[] GetTags()
        {          
            List<string> tags = new List<string>();
            var allTags = db.Stories.Select(story => story.GetTags());
            foreach (var i in allTags)
            {
                if(i!=null) tags.AddRange(i);
            }    
            return tags.ToArray();
        }

        [HttpGet]
        public string[] GetUserTags(string userId)
        {
            List<string> tags = new List<string>();
            var allTags = db.Stories.Where(story => story.UserId == userId).Select(story => story.GetTags());
            foreach (var i in allTags)
            {
                tags.AddRange(i);
            }
            return tags.ToArray();
        }

        public async Task<IActionResult> Logout()
        {       
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }          
    }
}
