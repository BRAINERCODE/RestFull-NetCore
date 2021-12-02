using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infraestructure.Repositories
{
    public class PostRepository: IPostRepository
    {
        private readonly SocialMediaContext _socialMediaContext;
        public PostRepository(SocialMediaContext socialMedia)
        {
            _socialMediaContext = socialMedia;
        }

        public async Task<Post> GetPost(int id)
        {
            var post = await _socialMediaContext.Post.FirstOrDefaultAsync(x => x.PostId == id);

            return post;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = await _socialMediaContext.Post.ToListAsync();
            return posts;
        }
    }
}




