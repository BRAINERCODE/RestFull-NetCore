using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        public PostController(IPostRepository repository, IMapper mapper)
        {
            _postRepository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var posts = await  _postRepository.GetPosts() ;
            var postsDTO = _mapper.Map<IEnumerable<PostDto>>(posts);
            return Ok (postsDTO)  ;
        }

        [HttpGet("{id}")]
        public  async Task<IActionResult> GetPostById(int id)
        {
            var post = await _postRepository.GetPost(id);
            var postDTO = _mapper.Map<PostDto>(post);
            return Ok (postDTO) ;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
             await _postRepository.InsertPost(post);

            return Ok(post);
        }
    }
}
