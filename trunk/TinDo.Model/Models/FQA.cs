using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TinDo.Model.Models
{
   public class FQA
    {
        public int FQAId { get; set; }
        [StringLength(500)]
        public string Question { get; set; }
        [StringLength(200)]
        public string Author { get; set; }
        
        [StringLength(4000)]
        //[AllowHtml] Does not support this attribute 
        public string Description { get; set; }
        [StringLength(200)]
        public string Tags { get; set; }
        
        public int Order { get; set; }

    }
}
