﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEntityLayer.Concrete
{
   public class Feature2
    {
        [Key]
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string image { get; set; }
        public bool Status { get; set; }
    }
}
