using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
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
        public async Task<IActionResult> CreatePost(PostEntity post)
        {

            bool result = await this.postServise.CreatePost(post);

            return Redirect("/");
        }

        [HttpPost("/Create/Comment")]
        public async Task<IActionResult> CreateComment(PostEntity post)
        {

            bool result = await this.postServise.CreatePost(post);

            return Redirect("/");
        }

    }
}
