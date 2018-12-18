using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineExam.Models.Models;

namespace OnlineExam.App.Models
{
    public class BatchCreateViewModel
    {
        public BatchCreateViewModel()
        {
            Status = "A";
            CreateById = 1;
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        //
         [Display(Name = "Organization")]
        public int OrganizationId { get; set; }
         [Display(Name = "Course")]
        public int CourseId { get; set; }
        [Display(Name = "Batch No")]
        public int BatchNo { get; set; }
        public string Description { get; set; }
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
         [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }
       
        public int BatchId { get; set; }
        public string ParticipentName { get; set; }
         public string RegNo { get; set; }
        [Required(ErrorMessage = "Contact Number Is Required 11 Digit")]
        [StringLength(11, MinimumLength = 11)]
        [Display(Name = "Conatact No")]
        public string ConatactNo { get; set; }
        public string Email { get; set; }
         [Display(Name = "Address")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Display(Name = "City")]
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        [Display(Name = "Country")]
        public int CountryId { get; set; }
        public string Profession { get; set; }
        public string HighestAcademic { get; set; }
        public string Image { get; set; }
        public string CourseTrainer { get; set; }
        [Display(Name = "Trainer Name")]
        public string TrainerName { get; set; }
        public List<SelectListItem> OrganizationSelectListItems { get; set; }

        public List<SelectListItem> CourseSelectListItems { get; set; }
        public List<SelectListItem> BatchSelectListItems { get; set; }
        public List<SelectListItem> CityListItemList { get; set; }
        public List<SelectListItem> CountryListItem { get; set; }
        public List<SelectListItem> ParticipentListItem { get; set; }
        public List<SelectListItem> TrainerListItems { get; set; }
        public List<Trainer> TrainerList { get; set; }
    }
}