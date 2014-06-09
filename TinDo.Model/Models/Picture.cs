using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinDo.Model.Models
{
    class Picture
    {
        public int PictureId { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Src { get; set; }
        [StringLength(200)]
        public string Tags { get; set; }
        public bool IsCover { get; set; }
        [StringLength(1000)]
        public string MoreInfo { get; set; }
        public bool IsDeleted { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
