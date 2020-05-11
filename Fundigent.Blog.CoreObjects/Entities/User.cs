using System;
using System.ComponentModel.DataAnnotations;

namespace Fundigent.Blog.CoreObjects.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        [Required]
        public int BlogRole { get; set; }
    }
}
