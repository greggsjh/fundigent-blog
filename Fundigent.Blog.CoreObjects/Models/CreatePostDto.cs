using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fundigent.Blog.CoreObjects.Models
{
    public class CreatePostDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string BlogCategory { get; set; }
        public ICollection<ImageDto> Images { get; set; }
    }
}
