using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MotiCv.Models.Entitys;

namespace MotiCv.Models.Entities
{
    public class Comment:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Website { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Massage { get; set; }
        public int BlogId { get; set; }
        public int? AnsweredByUserId { get; set; }
    }
}
