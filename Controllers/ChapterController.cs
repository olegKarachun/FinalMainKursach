using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPOI.HSSF.Record;
using WebApplication1.Classes;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class ChapterController : Controller
    {
        ApplicationDbContext db;
        Loader Loader;
        private string connectionString = "DefaultEndpointsProtocol=https;AccountName=olegkarachunn;AccountKey=P3ZTc12NIG0rkgSlgqIvmD02jReKL+nyrSO4wgUlux4cUrYk7vURLYC80tbqcQ1xMTMoYVF+008o4WN/arQJ7Q==;EndpointSuffix=core.windows.net";

        public ChapterController(ApplicationDbContext context)
        {
            db = context;
            Loader = new Loader(connectionString);
        }

        [Authorize(Roles = "Active")]
        public async Task<IActionResult> DeleteChapter(int id, string returnUrl)
        {            
            Chapter chapter = db.Chapters.First(s => s.Id == id);
            await chapter.Delete(db);
            return LocalRedirect(returnUrl);
        }

        [Authorize(Roles = "Active")]
        public IActionResult CreateChapter(int id)
        {            
            Story story = Story.GetById(db, id);
            ViewBag.Story = story;
            return View();
        }

        [Authorize(Roles = "Active")]
        public async Task Create()
        {            
            string title = Request.Form["Title"].ToString();
            string content = Request.Form["Content"].ToString();
            int Id = Convert.ToInt32(Request.Form["storyId"]);            
            Story story = Story.GetById(db, Id);
            if (Request.Form.Files["image"] != null)
            {
                await CreateChapterWithImg(title, content, story);
            }
            else
            {
                await CreateChapterWithoutImg(title, content, story);
            }
        }
        
        private async Task CreateChapterWithImg(string title, string content, Story story)
        {            
            string FileName = Request.Form.Files["image"].FileName;
            string containerName = Loader.CreateContainerName(FileName);            
            db.Chapters.Add(new Chapter { Title = title, Content = content, Story = story, ImageName = containerName });
            await db.SaveChangesAsync();            
            await Loader.Upload(Request.Form.Files["image"], containerName);
        }

        
        private async Task CreateChapterWithoutImg(string title, string content, Story story)
        {            
            db.Chapters.Add(new Chapter { Title = title, Content = content, Story = story });
            await db.SaveChangesAsync();
        }

        [Authorize(Roles = "Active")]
        public IActionResult GoEditChapter(int id)
        {            
            ViewBag.Chapter = db.Chapters.First(c => c.Id == id);
            return View("EditChapter");
        }

        [Authorize(Roles = "Active")]
        public async Task EditChapter()
        {            
            int Id = Convert.ToInt32(Request.Form["chapterId"]);
            Chapter chapter = db.Chapters.First(chapter => chapter.Id == Id);
            if (Request.Form.Files["image"] != null)
            {
                await EditImage(chapter);
            }
            chapter.EditTitleAndContent(Request.Form["Title"], Request.Form["Content"]);            
            await db.SaveChangesAsync();
        }
        
        private async Task EditImage(Chapter chapter)
        {
            string fileName = Request.Form.Files["image"].FileName;
            string containerName = Loader.CreateContainerName(fileName);
            await Loader.DeleteContainer(chapter.ImageName);
            chapter.ImageName = containerName;     
            await Loader.Upload(Request.Form.Files["image"], containerName);
        }     

        public async Task<string> GetImage(string filename)
        {         
            var image = await Loader.GetImage(filename);
            return image;
        }        

        [Authorize(Roles = "Active")]
        public async Task SetLike(int chapterId)
        {     
            User user = UserFinder.GetByEmail(db, User.Identity.Name);
            Chapter chapter = db.Chapters.First(chapter => chapter.Id == chapterId);               
            if(db.ChapterLikes.FirstOrDefault(cl=>cl.user == user && cl.Chapter == chapter) == null)
            {
                await ChapterLike.CreateLike(db, user, chapter);
            }         
        } 
    }
}
