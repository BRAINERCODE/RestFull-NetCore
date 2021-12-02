using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IPostRepository
    {
        public Task<IEnumerable<Post>> GetPosts(); 
        public Task<Post> GetPost(int id);

        public Task InsertPost(Post Post);
    }
}
