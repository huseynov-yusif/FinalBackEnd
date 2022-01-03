using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MotiCv.Models.Entitys;

namespace MotiCv.Models.Entities
{
    public class Blog:BaseEntity
    {
        public string MasterName { get; set; }
        public string ImagePath { get; set; }
        public string Feature { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string WorkName { get; set; }
        public string BestLongDescription { get; set; }
        [NotMapped]
        public IFormFile File { get; set; }


    }
}
