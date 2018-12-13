using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineExam.App.Models
{
    public class ExamCreateViewModel
    {

        public ExamCreateViewModel()
        {
            Status = "A";
            CreateById = 1;
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
    [Display(Name = "Organization")]
        public int OrganizationId { get; set; }
        public int CourseId { get; set; }
        [Display(Name = "Exam Type")]
        public string ExamType { get; set; }
        public string Code { get; set; }
        public string Topic { get; set; }
        [Display(Name = "Full Mark")]
        public int FullMark { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public List<SelectListItem> OrganizationSelectListItems { get; set; }
        public List<SelectListItem> CourseSelectListItems { get; set; }
        public List<SelectListItem> ExamTypeListItems { get; set; }
    }
}