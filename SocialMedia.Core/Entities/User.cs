using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class User
    {
        public User()
        {
            Comment = new HashSet<Comment>();
            Post = new HashSet<Post>();
        }

        public int UserId { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Number { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Post> Post { get; set; }
    }
}
