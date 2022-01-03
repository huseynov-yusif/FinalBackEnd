using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotiCv.Models.Entitys
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DeletedDate { get; set; }
        public int? CreatedByUserId { get; set; }
        public int? DeletedByUserId { get; set; }
    }
}
