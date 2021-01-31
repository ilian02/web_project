using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebSite.Servises
{
    public interface IPostServise
    {
        Task<bool> CreatePost(PostEntity post);
        Task<bool> CreateComment(PostEntity post);
    }
}
