using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class CommentModel
    {
        [Key]
        public int ID { get; set; }
        public String PosterName { get; set; }
        [StringLength(250, ErrorMessage = "Limit yourself to 250 lenght")]
        public String Description { get; set; }
        [Range(1, 5, ErrorMessage = "Between 1 to 5")]
        public double Stars { get; set; }
        public int PostID { get; set; }
    }
}


