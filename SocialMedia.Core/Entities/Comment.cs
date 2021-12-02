using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }

        public virtual Post IdPublicacionNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
