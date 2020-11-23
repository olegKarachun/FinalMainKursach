using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class ChapterLike
    {
        public int Id { set; get; }
        public User user { set; get; }
        public string userId { set; get; }
        public Chapter Chapter { set; get; }
        public int ChapterId { set; get; }

        public static async Task CreateLike(ApplicationDbContext db, User user, Chapter chapter)
        {
            db.ChapterLikes.Add(new ChapterLike { user = user, Chapter = chapter });
            chapter.AddRate();
            chapter.GetStory(db).SetTotalLikes();
            await db.SaveChangesAsync();
        }
    }    
}
