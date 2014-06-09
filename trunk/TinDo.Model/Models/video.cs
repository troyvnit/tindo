using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDo.Model.Models
{
    public class Video
    {
        public int VideoId { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Link { get; set; }
        
        [StringLength(200)]
        public string Filename { get; set; }

        public bool IsDeleted { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
