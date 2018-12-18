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

        
        public string TrainerId { get; set; }

        public string BatchId { get; set; }

        public string CourseId { get; set; }

        public string Lead { get; set; }

        public string TrainerName { get; set; }

        public string ConatactNo { get; set; }
        public string Email { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
        public int CityId { get; set; }
        public int PostalCode { get; set; }

        public int CountryId { get; set; }
        public string Image { get; set; }

        [Display(Name = "Exam Type")]
        public string ExamType { get; set; }
        public string ExamCode { get; set; }
        public string Topic { get; set; }
        [Display(Name = "Full Mark")]
        public int FullMark { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }

        public List<SelectListItem> Tags { get; set; }

        public List<SelectListItem> OrganizationSelectListItems { get; set; }
        public List<CourseTag> CourseTags { get; set; }

        public List<Trainer> TrainerSelectListItems { get; set; }
        public List<SelectListItem> TrainerListItems { get; set; }

        public List<SelectListItem> BatchSelectListItems { get; set; }
        public List<SelectListItem> CityListItemList { get; set; }
        public List<SelectListItem> CountryListItem { get; set; }
        public List<SelectListItem> CourseSelectListItems { get; set; }
        public List<SelectListItem> ExamTypeListItems { get; set; }
    }
}