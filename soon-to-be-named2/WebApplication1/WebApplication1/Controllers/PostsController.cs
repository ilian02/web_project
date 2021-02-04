using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        public readonly UserManager<IdentityUser> userManager;

        public readonly IPostServise postServise;

        public PostsController(IPostServise postServise, UserManager<IdentityUser> userManager)
        {
            this.postServise = postServise;
            this.userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost("/Create/Post")]
        public async Task<IActionResult> CreatePost(PostModel postModel)
        {

            var user = await userManager.GetUserAsync(HttpContext.User);
            postModel.PosterName = user.UserName;
            postModel.Stars = 5;

            bool result = await this.postServise.CreatePost(postModel);

            return Redirect("/");
        }

        [Authorize]
        [HttpGet]
        public IActionResult CreateComment()
        {
            return View();
        }

        [HttpPost("/Create/Comment")]
        public async Task<IActionResult> CreateComment(CommentModel commentModel)
        {


            bool result = await this.postServise.CreateComment(commentModel);

            return Redirect("/");
        }

    }
}
