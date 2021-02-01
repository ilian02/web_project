﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class PostModel
    {
        public int PostID { get; set; }
        public String Title { get; set; }
        public String ImageURL { get; set; }
        public String PosterName { get; set; }
        public String Description { get; set; }
        public double Stars { get; set; }
    }
}
