﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Entities;
using WebSite.Models;

namespace WebSite.Servises
{
    public class PostServise : IPostServise
    {
        private readonly ApplicationDbContext AppDbContext;

        public PostServise(ApplicationDbContext appDbContext)
        {
            this.AppDbContext = appDbContext;
        }

        public List<PostModel> GetAllPosts()
        {
            var entities = AppDbContext.Posts.OrderByDescending(c => c.Date).ToList();

            List<PostModel> result = new List<PostModel>();

            foreach (PostEntity post in entities)
            {
                PostModel postModel = new PostModel
                {
                    Title = post.Title,
                    PosterName = post.PosterName,
                    Description = post.Description,
                    Date = post.Date,
                    Stars = post.Stars,
                    ImageURL = post.ImageURL
                };

                result.Add(postModel);
            }

            return result;
        }

        public async Task<bool> CreatePost(PostModel postModel)
        {
            PostEntity postEntity = new PostEntity
            {
                Title = postModel.Title,
                PosterName = postModel.PosterName,
                ImageURL = postModel.ImageURL,
                Description = postModel.Description,
                Stars = postModel.Stars,
                Date = DateTime.Now
            };


            bool result = await this.AppDbContext.AddAsync(postEntity) != null;

            await this.AppDbContext.SaveChangesAsync();

            return result;
        }

        public async Task<bool> CreateComment(CommentModel commentModel)
        {
            CommentEntity commentEntity = new CommentEntity
            {
                Description = commentModel.Description,
                PosterName = commentModel.PosterName,
                Stars = commentModel.Stars,
                Date = DateTime.Now
            };


            bool result = await this.AppDbContext.AddAsync(commentEntity) != null;

            await this.AppDbContext.SaveChangesAsync();

            return result;
        }

    }
}
