using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class PostModel
    {
        [Key]
        public int PostID { get; set; }
        [StringLength(1000, ErrorMessage = "Limit yourself to 100 lenght")]

        public String Title { get; set; }
        public String ImageURL { get; set; }
        public DateTime Date { get; set; }
        public String PosterName { get; set; }
        [StringLength(250, ErrorMessage = "Limit yourself to 250 lenght")]
        public String Description { get; set; }
        [Range(1, 5, ErrorMessage = "Between 1 to 5")]
        public double Stars { get; set; }
    }
}
