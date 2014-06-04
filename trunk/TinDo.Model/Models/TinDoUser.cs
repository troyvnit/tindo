using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TinDo.Model.Models
{
    public class TinDoUser : IdentityUser
    {
        public TinDoUser()
        {
            CreatedDate = DateTime.Now;
        }   

        public DateTime CreatedDate { get; set; }

        public DateTime? LastLogin { get; set; }

        public bool Activated { get; set; }

        public int RoleId { get; set; }   
    }
}
