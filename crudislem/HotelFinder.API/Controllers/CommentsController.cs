using hotelFinder.entities;
using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private IcommentService _commentService;

        public CommentsController()
        {
            _commentService = new CommentManager();

        }
        
        [HttpGet]

        public List<Comment> Get()
        {
            return _commentService.GetAllComments();
        }
        [HttpGet("{otelId}")]

        public List<Comment> Get(int otelId)
        {
            return _commentService.GetOneComment(otelId);
        }

        [HttpPost]

        public Comment Post([FromBody] Comment comment)
        {
            return _commentService.CreateComment(comment);
        }

        [HttpPut]

        public Comment Put([FromBody] Comment comment)
        {
            return _commentService.UpdateComment(comment);
        }
        [HttpDelete("{otelId}")]

        public void Delete(int otelId)
        {
            _commentService.DeleteComment(otelId);
        }
    }
}
