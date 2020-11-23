using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class StoryComment
    {
        public int Id { set; get; }
        public User User { set; get; }
        public string UserId { set; get; }
        public Story Story { set; get; }
        public int StoryId { set; get; }        
        public string CommentContent { set; get; }
        public string AuthorEmail { set; get; }        
    }
}
