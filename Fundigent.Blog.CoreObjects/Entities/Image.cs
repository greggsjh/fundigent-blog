using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fundigent.Blog.CoreObjects.Entities
{
    public class Image
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        [Required]
        public string Src { get; set; }
        public string Alt { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        public Guid PostId { get; set; }
    }
}
