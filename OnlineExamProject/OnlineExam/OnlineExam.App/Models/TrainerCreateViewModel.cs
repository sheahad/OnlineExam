﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineExam.Models.Models;

namespace OnlineExam.App.Models
{
    public class TrainerCreateViewModel
    {
        public TrainerCreateViewModel()
        {
            Status = "A";
            CreateById = 1;
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
   [Display (Name="Organization")]
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string ConatactNo { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public int CountryId { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public  List<SelectListItem> OrganizationSelectListItems { get; set; }
        public List<SelectListItem> CourseSelectListItems { get; set; }
        public List<SelectListItem> BatchSelectListItems { get; set; }
        public List<SelectListItem> CityListItemList { get; set; }
        public List<SelectListItem> CountryListItem { get; set; }
        public List<Trainer> TrainerList { get; set; }

        public int BatchId { get; set; }
        public int CourseId { get; set; }
        public List<AssignBatchTrainer> AssignBatchTrainers { get; set; }
        public bool Lead { get; set; }
        public List<AssignCourseTrainer> AssignCourseTrainers { get; set; }

    }
}