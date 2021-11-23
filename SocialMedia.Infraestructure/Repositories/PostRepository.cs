﻿using SocialMedia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Infraestructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostId = x,
                Descripcion = $"Descripcion {x}" ,
                Date = DateTime.Now,
                Image = $"https://misapis.com/{x}",
                UserId = x*2
            });
            return posts;
        }
    }
}



