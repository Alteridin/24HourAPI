﻿using _24Hour.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class PostListItem
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public User Author { get; set; }
    }
}