﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotiCv.Models.Entitys
{
    public class Skill:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Percent { get; set; }
    }
}
