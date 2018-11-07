﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShaneMaravillo.SchoolFacilities.Web.ViewModels
{
    public class PostViewModel
    {
        public Guid? PostId { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
    }
}