using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Classes;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class Chapter
    {
        private string connectionString = "DefaultEndpointsProtocol=https;AccountName=olegkarachunn;AccountKey=P3ZTc12NIG0rkgSlgqIvmD02jReKL+nyrSO4wgUlux4cUrYk7vURLYC80tbqcQ1xMTMoYVF+008o4WN/arQJ7Q==;EndpointSuffix=core.windows.net";

        public int Id { set; get; }
        public int Rate { set; get; }
        public string Title { set; get; }
        public string Content { set; get; }        
        public string ImageName { set; get; }
        public int StoryId { set; get; }
        public Story Story { set; get;}
        
        public void EditTitleAndContent(string title, string content)
        {  
            this.Title = title;
            this.Content = content;     
        }

        public Story GetStory(ApplicationDbContext db)
        {
            return db.Stories.First(story=>story.Id == this.StoryId);
        }

        public static async Task DeleteRange(IEnumerable<Chapter> chapters, ApplicationDbContext db) 
        {
            foreach(Chapter chapter in chapters)
            {
                await chapter.Delete(db);
            }           
            await db.SaveChangesAsync();
        }

        public async Task Delete(ApplicationDbContext db)
        {
            DeleteLikes(db, this);
            db.Chapters.Remove(this);
            await this.DeleteContainer();
            await db.SaveChangesAsync();
        }

        private void DeleteLikes(ApplicationDbContext db, Chapter chapter)
        {
            var onDelete = db.ChapterLikes.Where(like=>like.ChapterId == chapter.Id);
            db.ChapterLikes.RemoveRange(onDelete);
        }

        private async Task DeleteContainer()
        {
            Loader loader = new Loader(connectionString);
            await loader.DeleteContainer(this.ImageName);
        }

        public void AddRate()
        {
            this.Rate++;
        }
    }
}
