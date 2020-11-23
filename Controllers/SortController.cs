using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Classes;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SortController : Controller
    {
        ApplicationDbContext db;        
        public SortController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult GetMostRate(string id)
        {            
            User user = UserFinder.GetById(db, id);
            var sortedStories = user.GetStories(db).OrderByDescending(story => story.Rate).Select(story => story);
            ViewBag.Stories = sortedStories;
            ViewBag.User = user;
            return View("/Views/Home/PersonalPage.cshtml");
        }        

        public IActionResult GetLowRate(string id)
        {            
            User user = UserFinder.GetById(db, id);            
            var sortedStories = user.GetStories(db).OrderBy(story => story.Rate).Select(story=>story);            
            ViewBag.Stories = sortedStories;
            ViewBag.User = user;
            return View("/Views/Home/PersonalPage.cshtml");
        }

        public IActionResult GetNewStory(string id)
        {
            User user = UserFinder.GetById(db, id);
            var sortedStories = user.GetStories(db).Where(story => story.UserId == id).ToArray().Reverse();
            ViewBag.Stories = sortedStories;
            ViewBag.User = user;
            return View("/Views/Home/PersonalPage.cshtml");
        }

        public IActionResult GetOldStory(string id)
        {
            User user = UserFinder.GetById(db, id);
            var sortedStories = user.GetStories(db).Where(story => story.UserId == id);
            ViewBag.Stories = sortedStories;
            ViewBag.User = user;
            return View("/Views/Home/PersonalPage.cshtml");
        }

        public IActionResult GetMostLike(string id)
        {            
            User user = UserFinder.GetById(db, id);            
            var sortedStories = user.GetStories(db).OrderByDescending(story => story.TotalLikes).Select(story => story);
            ViewBag.Stories = sortedStories;
            ViewBag.User = user;
            return View("/Views/Home/PersonalPage.cshtml");
        }        

        public IActionResult GetLowLike(string id)
        {            
            User user = UserFinder.GetById(db, id);
            var sortedStories = user.GetStories(db).OrderBy(story => story.TotalLikes).Select(story => story);
            ViewBag.Stories = sortedStories;
            ViewBag.User = user;
            return View("/Views/Home/PersonalPage.cshtml");
        }        
    }
}
