using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineExam.Models.Models;

namespace OnlineExam.App.Models
{
    public class CourseCreateViewModel
    {
        public CourseCreateViewModel()
        {
            Status = "A";
            CreateById = 1;
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        [Required(ErrorMessage = "Course Name Is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<double> CourseDuration { get; set; }
        public int Credit { get; set; }
        public Nullable<double> Fee { get; set; }
        public string Outline { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public string Tag { get; set; }
        public string TagId { get; set; }

        public List<SelectListItem> Tags { get; set; }

        public List<SelectListItem> OrganizationSelectListItems { get; set; }
        public List<CourseTag> CourseTags { get; set; }

        public List<Trainer> TrainerSelectListItems { get; set; } 
    }
}