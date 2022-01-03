using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MotiCv.Models.Entities;

namespace MotiCv.Models.ViewModels
{
    public class ContactPostViewModel
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
        public List<LocationContact> LocationContacts { get; set; }
    }
}
