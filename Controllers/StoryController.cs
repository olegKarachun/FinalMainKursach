using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Classes;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StoryController : Controller
    {
        readonly ApplicationDbContext db;
        public StoryController(ApplicationDbContext context)
        {
            db = context;
        }
        
        public IActionResult StoryPage(int id)
        {       
            Story story = Story.GetById(db, id);
            ViewBag.Comments = story.GetComments(db);
            ViewBag.Author = story.GetAuthor(db).Email;
            ViewBag.Story = story;            
            List<Chapter> Chapters = story.GetChapters(db);
            return View(Chapters);
        }

        [Authorize(Roles = "Active")]
        public async Task<IActionResult> DeleteStory(int id)
        {            
            Story storyForDel = Story.GetById(db, id);
            await storyForDel.Delete(db);            
            return RedirectToAction("PersonalPage", "Home", new {Id = User.Identity.Name });
        }

        [Authorize(Roles = "Active")]
        public IActionResult EditStory(int id)
        {            
            Story story = Story.GetById(db, id);
            ViewBag.Story = story;            
            ICollection<Chapter> forStory = story.GetChapters(db);            
            return View(forStory);
        }

        [Authorize(Roles = "Active")]
        public async Task SaveChanges(string title, string descript, string genre, string tags, int story)
        {     
            Story currentStory = Story.GetById(db, story);            
            currentStory.ChangeStory(title, descript, genre, GetStringTags(tags));                        
            await db.SaveChangesAsync();
        }        

        [Authorize(Roles = "Active")]
        [HttpPost]
        public async Task<IActionResult> CreateStory(NewStoryModel model, string id)
        {            
            string tags = GetStringTags(model.Tags);            
            User user = UserFinder.GetByEmail(db, id);
            Story newStory = new Story {ChangeDate = DateTime.Now ,Title = model.Title, Genre = model.Genre,
                                        Descript = model.Descript, Tags = tags, User = user};            
            db.Stories.Add(newStory);
            await db.SaveChangesAsync();           
            return RedirectToAction("CreateChapter", "Chapter", new { id = newStory.Id });            
        }

        private string GetStringTags(string tags)
        {
            if (tags != null)
            {
                return CreateStringTags(tags);
            }
            else
            {
                return null;
            }            
        }

        private string CreateStringTags(string tags)
        {
            string stringTags = tags.Replace("\"value\"", "");
            string[] arrayTags = stringTags.Split(new char[] { ',', ':', '{', '}', '[', ']', '"' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(',', arrayTags);
        }

        [Authorize(Roles = "Active")]
        [HttpGet]
        public IActionResult CreateStory(string id)
        {            
            ViewBag.User = UserFinder.GetByEmail(db, id);
            return View("CreateStoryPage");
        }

        [Authorize (Roles ="Active")]
        public async Task SetRate(int value, string storyId)
        {         
            User user = UserFinder.GetByEmail(db, User.Identity.Name);            
            Story story = Story.GetById(db, Convert.ToInt32(storyId));
            if (db.StoryRates.FirstOrDefault(rate=>rate.User == user && rate.Story == story) == null)
            {                
                db.StoryRates.Add(new StoryRate { User = user, Story = story, Value = value });                
            }
            else
            {                
                StoryRate rate = db.StoryRates.First(rate => rate.User == user && rate.Story == story);
                rate.Value = value;
            }
            await db.SaveChangesAsync();
            await story.SetAverageRate(db);                                    
        }        
    }
}
