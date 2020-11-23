using Microsoft.AspNetCore.Identity;
using NPOI.HSSF.Record;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using WebApplication1.Interfaces;

namespace WebApplication1.Models
{
    public class User : IdentityUser
    {        
        public string UserInfo { set; get; }
        public bool IsAdmin { set; get; }
        public bool IsBlocked { set; get; }  

        public List<Story> GetStories(ApplicationDbContext db)
        {
            return db.Stories.Where(story=>story.UserId == Id).ToList();
        }        

        public async Task Delete(UserManager<User> userManager, ApplicationDbContext db)
        {
            await DeleteAllUserContent(db);
            await userManager.DeleteAsync(this);            
        }
        
        private async Task DeleteAllUserContent(ApplicationDbContext db)
        {
            await this.DeleteLikes(db);
            await this.DeleteRates(db);
            await this.DeleteComments(db);
            await this.DeleteStories(db);            
        }

        private async Task DeleteStories(ApplicationDbContext db)
        {
            var stories = this.GetStories(db);
            foreach (var story in stories)
            {
                await story.Delete(db);
            }
            await db.SaveChangesAsync();
        }

        private async Task DeleteLikes(ApplicationDbContext db)
        {
            var likes = db.ChapterLikes.Where(like=>like.userId == this.Id);
            db.ChapterLikes.RemoveRange(likes);
            await db.SaveChangesAsync();
        }

        private async Task DeleteRates(ApplicationDbContext db)
        {
            var rates = db.StoryRates.Where(rate => rate.UserId == this.Id);
            db.StoryRates.RemoveRange(rates);
            await db.SaveChangesAsync();
        }

        private async Task DeleteComments(ApplicationDbContext db)
        {
            var comments = db.StoryComments.Where(comment=>comment.UserId == this.Id);
            db.StoryComments.RemoveRange(comments);
            await db.SaveChangesAsync();
        }
    }    
}
