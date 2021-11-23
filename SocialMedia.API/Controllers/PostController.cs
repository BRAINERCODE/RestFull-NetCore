 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        public PostController(IPostRepository repository)
        {
            _postRepository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var posts = await  _postRepository.GetPosts() ;
            return Ok (posts)  ;
        }
    }
}
