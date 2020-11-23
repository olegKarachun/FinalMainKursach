using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class StoryRate
    {
        public int Id { set; get; }
        public int Value { set; get; }
        public Story Story { set; get; }
        public int StoryId { set; get; }
        public User User { set; get; }
        public string UserId { set; get; }
    }
}
