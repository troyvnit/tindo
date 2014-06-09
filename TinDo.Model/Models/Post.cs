using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDo.Model.Models
{
    class Post
    {
        public int PostId { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(200)]
        public string Tags { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        public int NumofViews { get; set; }
        public int NumofLikes { get; set; }
        public int NumofFollows { get; set; }
        public int NumofComments { get; set; }

        
        /*-------- Relationship with each other one to many and many to many -------------*/
        public int TinDoUserId { get; set; }
        public TinDoUser TinDoUser { get; set; }

        public virtual List<Picture> Pictures { get; set; }
        public virtual List<Video> Videos { get; set; }
        public virtual List<Category> Categories { get; set; }
    }
}
