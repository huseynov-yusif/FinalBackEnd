using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MotiCv.Models.Entities;

namespace MotiCv.Models.ViewModels
{
    public class ForBlogViewModel
    {
        public Blog Blogs { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Website { get; set; }
        [Required]
        public string Subject { get; set; }
        public int BlogId { get; set; }
        [Required]
        public string Massage { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
