using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDo.Model.Models
{
    class Article
    {
        public int ArticleId { get; set; }

        [StringLength(200)]
        public String Title { get; set; }

        [StringLength(1000)]
        public String Description { get; set; }

        //[AllowHtml] does not support this attribute
        public String Content { get; set; }

        //to store author or source of this article and display at the end of article
        [StringLength(200)]
        public String Author { get; set; }

        [StringLength(200)]
        public String Tags { get; set; }

        public bool Active { get; set; }

        public Int16 Order { get; set; }

        [StringLength(200)]
        public String Avatar { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime PublicDate { get; set; }
        public bool IsDeleted { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
