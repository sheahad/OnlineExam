using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineExam.Models.Models;

namespace OnlineExam.App.Models
{
    public class QuestionAnswerCreateViewModel
    {
        public QuestionAnswerCreateViewModel()
        {
            Status = "A";
            CreateById = 1;
            CreateDate = DateTime.Now;

            OrganizationSelectListItems = new List<SelectListItem>()
            {
                new SelectListItem(){Value = "", Text = "---Select--"}
            };
            CourseSelectListItems = new List<SelectListItem>()
            {
                new SelectListItem(){Value = "", Text = "---Select--"}
            };
            ExamSelectListItems = new List<SelectListItem>()
            {
                new SelectListItem(){Value = "", Text = "---Select--"}
            };
        }
        public int Id { get; set; }
        [Display(Name = "Organization")]
        public int OrganizationId { get; set; }
        [Display(Name = "Course")]
        public int CourseId { get; set; }
        [Display(Name = "Exam")]
        public int ExamId { get; set; }
        public double Mark { get; set; }
        public int QOrder { get; set; }
        public string Question1 { get; set; }
        public string QuestionType { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        
        public List<SelectListItem> OrganizationSelectListItems { get; set; }
        public List<SelectListItem> CourseSelectListItems { get; set; }
        public List<SelectListItem> ExamSelectListItems { get; set; }

        public ICollection<Answer> Answers { get; set; }




    }
}