using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class NewStoryModel
    {
        [Required]
        public string Title { set; get; }

        [Required]
        public string Descript { set; get; }

        [Required]
        public string Genre { set; get; }

        public string Tags { set; get; }
    }
}
