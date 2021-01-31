using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebSite.Servises
{
    public class PostServise : Controller
    {
        private readonly ApplicationDbContext AppDbContext;

        public PostServise(ApplicationDbContext appDbContext)
        {
            this.AppDbContext = appDbContext;
        }

        public async Task<bool> CreatePost(PostEntity post)
        {
            bool result = await this.AppDbContext.AddAsync(post) != null;

            await this.AppDbContext.SaveChangesAsync();

            return result;
        }

        public async Task<bool> CreateComment(CommentEntity post)
        {
            bool result = await this.AppDbContext.AddAsync(post) != null;

            await this.AppDbContext.SaveChangesAsync();

            return result;
        }

    }
}
