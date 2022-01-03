using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotiCv.Models.Entitys
{
    public class ContactPost:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Content { get; set; }
        public string Answer { get; set; }
        public DateTime? AnsweredDate { get; set; } = DateTime.Now;
        public int? AnsweredByUserId { get; set; }
    }
}
