using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebSite.Models;
using WebSite.Servises;

namespace WebSite.Controllers
{
    public class PostsController : Controller
    {

        public readonly IPostServise postServise;

        public PostsController(IPostServise postServise)
        {
            this.postServise = postServise;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Create/Post")]
        public async Task<IActionResult> CreatePost(PostModel postModel)
        {

            bool result = await this.postServise.CreatePost(postModel);

            return Redirect("/");
        }

        [HttpPost("/Create/Comment")]
        public async Task<IActionResult> CreateComment(CommentModel commentModel)
        {

            bool result = await this.postServise.CreatePost(commentModel);

            return Redirect("/");
        }

    }
}
