using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fundigent.Blog.CoreObjects.Entities
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("UserId")]
        [Required]
        public User User { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        public Guid PostId { get; set; }
        [MaxLength(140)]
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}
