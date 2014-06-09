using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

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

        [StringLength(200)]
        public String DisplayName { get; set; }

        [StringLength(200)]
        public String Password { get; set; }

        public DateTime? BOD { get; set; }

        [StringLength(200)]
        public string Fullname { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string FacebookId { get; set; }

        [StringLength(200)]
        public string GoogleId { get; set; }

        public Boolean Gender { get; set; }

        /*-------------------Relationship with each other -------------------------*/
        public virtual List<TinDoUser> Follows { get; set; }

        [StringLength(500)] //hobbies & have to enhance to List Of Tag in future
        public string Tags { get; set; }

        [StringLength(500)] //hobbies & have to enhance to List Of Category in future
        public string Favorites { get; set; }

        public virtual List<Post> Posts { get; set; }

    }
}
