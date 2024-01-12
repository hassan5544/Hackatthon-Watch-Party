﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class WatchParty
    {
        public Guid id { get; set; }
        public string MovieTitle { get; set; }
        public Video Video { get; set; }
    }
}
