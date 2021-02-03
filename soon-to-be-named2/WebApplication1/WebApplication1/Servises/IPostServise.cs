﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebSite.Models;

namespace WebSite.Servises
{
    public interface IPostServise
    {
        Task<bool> CreatePost(PostModel postModel);
        Task<bool> CreateComment(CommentModel commentModel);
    }
}
