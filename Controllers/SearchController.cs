using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Core.Objects;

namespace WebApplication1.Controllers
{
    public class SearchController : Controller
    {
        ApplicationDbContext db;
        public SearchController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Search(string search)
        {
            if (search != null)
            {
                ViewBag.Stories = SearchStories(search);
            }
            else
            {
                ViewBag.Stories = db.Stories;
            }
            return View("/Views/Home/Index.cshtml");
        }

        private IQueryable<Story> SearchStories(string search)
        {
            IQueryable<Story> allStories = db.Stories;
            var searchStories = allStories.Where(story => story.Title.Contains(search) || story.Tags.Contains(search) || story.Descript.Contains(search)).Select(x => x.Id);
            var ids = searchStories.Union(SearchComments(search)).Union(SearchChapters(search)).ToList();
            var Result = allStories.Where(story => ids.Contains(story.Id));
            return Result;
        }

        private IQueryable<int> SearchComments(string search)
        {
            IQueryable<StoryComment> comments = db.StoryComments;
            var commentss = comments.Where(comment => comment.CommentContent.Contains(search));
            return comments.Select(x => x.StoryId);
        }

        private IQueryable<int> SearchChapters(string search)
        {
            IQueryable<Chapter> chapters = db.Chapters;
            var Chapters = chapters.Where(chapter => chapter.Title.Contains(search) || chapter.Content.Contains(search));
            return Chapters.Select(x => x.StoryId);
        }        
    }
}
