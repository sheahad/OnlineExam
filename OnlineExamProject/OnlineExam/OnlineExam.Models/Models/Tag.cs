﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Tag
    {
        public Tag()
        {
            this.CourseTags = new HashSet<CourseTag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual ICollection<CourseTag> CourseTags { get; set; }
        public virtual User User { get; set; }
    }
}
