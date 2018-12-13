using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;
using OnlineExam.Models.Models;

namespace OnlineExam.App.Models
{
    public class OrganizationCreateViewModel
    {
        public OrganizationCreateViewModel()
        {
            Status = "A";
            CreateById = 1;
            CreateDate = DateTime.Now;
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Organization Name Is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string ConatactNo { get; set; }
        public string About { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual List<Course> Courses { get; set; }

        public List<SelectListItem> OrganizationList { get; set; }

        public List<Organization> OrganizationItemList { set; get; } 
    }
}