using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MotiCv.Models.Entitys
{
    public class My:BaseEntity
    {
        public string Name { get; set; }
        public string Degree { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; }
        public string CareerLevel { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string website { get; set; }
        public string Work { get; set; }
    }
}
