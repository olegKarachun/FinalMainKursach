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
    [Authorize(Roles = "Active")]
    public class CommentController : Controller
    {
        ApplicationDbContext db;
        public CommentController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task SendComment(string storyId, string content)
        {            
            User user = UserFinder.GetByEmail(db, User.Identity.Name);            
            Story story = Story.GetById(db, Convert.ToInt32(storyId));            
            db.StoryComments.Add(new StoryComment { User = user, Story = story, CommentContent = content, AuthorEmail = User.Identity.Name });
            await db.SaveChangesAsync();                      
        }
    }
}
