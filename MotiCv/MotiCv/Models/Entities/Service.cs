using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotiCv.Models.Entitys
{
    public class Service:BaseEntity
    {
        public string IconPath { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
