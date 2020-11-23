using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public enum Genre
    {
        Fantastic,
        Detective,
        Erotic,
        Fantasy,
        Adventure,
        Romance
    }
    public class Story
    {      
        public int Id { set; get; }
        public double Rate { set; get; }
        public string Title { set; get; }
        public string Descript { set; get; }        
        public DateTime ChangeDate { set; get; }
        public string Genre { set; get; }
        public string Tags { set; get; }
        public int TotalLikes { set; get; }
        public User User { set; get; }        
        public string UserId { set; get; }  
        
        public static Story GetById(ApplicationDbContext db, int Id)
        {
            return db.Stories.First(story => story.Id == Id);
        }

        public async Task Delete(ApplicationDbContext db)
        {
            await Chapter.DeleteRange(this.GetChapters(db), db);
            await DeleteRates(db, this);
            db.Stories.Remove(this);            
            await db.SaveChangesAsync();
        }

        private async Task DeleteRates(ApplicationDbContext db, Story story)
        {
            var forDelete = db.StoryRates.Where(rate=>rate.StoryId == story.Id);
            db.StoryRates.RemoveRange(forDelete);
            await db.SaveChangesAsync();
        }
        
        public List<string> GetTags()
        {            
            if (Tags != null)
            {                
                var tags = this.Tags.Split(',', StringSplitOptions.RemoveEmptyEntries);
                return tags.ToList();
            }
            return new List<string>();
        }

        public User GetAuthor(ApplicationDbContext db)
        {
            return db.Users.First(user=>user.Id == UserId);
        }

        public List<Chapter> GetChapters(ApplicationDbContext db)
        {
            return db.Chapters.Where(chapter => chapter.StoryId == Id).ToList();
        }

        public IQueryable<StoryComment> GetComments(ApplicationDbContext db)
        {
            var Comments = db.StoryComments.Where(comment => comment.StoryId == Id);
            return Comments;
        } 
        
        public void SetTotalLikes()
        {
            this.TotalLikes++;
        }

        public async Task SetAverageRate(ApplicationDbContext db)
        {
            this.Rate = Math.Round(db.StoryRates.Where(rate => rate.Story == this).Select(rate => rate.Value).Average(), 2);            
            await db.SaveChangesAsync();
        }

        public void ChangeStory(string title, string desc, string genre, string tags)
        {            
            this.Title = title;
            this.Descript = desc;
            this.Genre = genre;
            this.Tags = tags;
        }

        public static IOrderedQueryable<Story> GetBestStories(ApplicationDbContext db)
        {
            var sortedStories = from story in db.Stories
                                orderby story.Rate descending
                                select story;
            return sortedStories;
        }

        public static IOrderedQueryable<Story> GetNewStories(ApplicationDbContext db)
        {
            var sortedStories = from story in db.Stories
                                orderby story.ChangeDate descending
                                select story;
            return sortedStories;
        }
    }
}
