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
    public class FilterController : Controller
    {
        ApplicationDbContext db;
        public FilterController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult GetBestStories()
        {         
            ViewBag.Stories = Story.GetBestStories(db);
            return View("/Views/Home/Index.cshtml");
        }

        public IActionResult GetNewStories()
        {            
            ViewBag.Stories = Story.GetNewStories(db);
            return View("/Views/Home/Index.cshtml");
        }

        public IActionResult FilterMainPage(Dictionary<string, bool> check, string tags)
        {            
            var list = check.Keys.ToList();          
            if (tags != null)
            {                
                FilterWithTags(check, tags, list);
            }
            else if (tags == null && check.Count > 1)
            {                
                ViewBag.Stories = db.Stories.ToList().Where(s => list.Contains(s.Genre));
            }
            else
            {                
                ViewBag.Stories = db.Stories;
            }
            return View("/Views/Home/Index.cshtml");
        }

        public IActionResult FilterPersonalPage(Dictionary<string, bool> check, string tags, string Id)
        {            
            var list = check.Keys.ToList();            
            User user = UserFinder.GetById(db, Id);
            ViewBag.User = user;
            if (tags != null)
            {
                FilterWithTags(check, tags, user, list);
            }
            else if (tags == null && check.Count > 1)
            {
                ViewBag.Stories = user.GetStories(db).Where(s => list.Contains(s.Genre));
            }
            else
            {
                ViewBag.Stories = user.GetStories(db);
            }            
            return View("/Views/Home/PersonalPage.cshtml");
        }

        private void FilterWithTags(Dictionary<string, bool> check, string tags, List<string> list)
        {
            string stringTags = tags.Replace("\"value\"", "");
            string[] arrayTags = stringTags.Split(new char[] { ',', ':', '{', '}', '[', ']', '"' }, StringSplitOptions.RemoveEmptyEntries);
            if (check.Count > 1)
            {
                ViewBag.Stories = db.Stories.ToList().Where(s => list.Contains(s.Genre)
                                                            && s.GetTags().Intersect(arrayTags).Count() > 0);
            }
            else
            {                
                ViewBag.Stories = db.Stories.ToList().Where(s => s.GetTags().Intersect(arrayTags).Count() > 0);
            }
        }        

        
        private void FilterWithTags(Dictionary<string, bool> check, string tags, User currentUser, List<string> list)
        {
            string stringTaggs = tags.Replace("\"value\"", "");
            string[] arrayTags = stringTaggs.Split(new char[] { ',', ':', '{', '}', '[', ']', '"' }, StringSplitOptions.RemoveEmptyEntries);
            if (check.Count > 1)
            {
                ViewBag.Stories = currentUser.GetStories(db).Where(s => list.Contains(s.Genre) && s.GetTags().Intersect(arrayTags).Count() > 0);
            }
            else
            {
                ViewBag.Stories = currentUser.GetStories(db).Where(s => s.GetTags().Intersect(arrayTags).Count() > 0);
            }
        }
    }
}
