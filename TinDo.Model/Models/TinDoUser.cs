using System;
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
    }
}
