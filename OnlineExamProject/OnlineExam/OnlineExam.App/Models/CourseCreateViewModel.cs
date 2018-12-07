using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExam.App.Models
{
    public class CourseCreateViewModel
    {
        public int Id { get; set; }
        public int OrganiaationId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<double> CourseDuration { get; set; }
        public int Credit { get; set; }
        public Nullable<double> Fee { get; set; }
        public string Outline { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }
    }
}