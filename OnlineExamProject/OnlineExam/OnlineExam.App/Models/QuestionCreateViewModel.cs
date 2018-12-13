﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineExam.App.Models
{
    public class QuestionCreateViewModel
    {
        public QuestionCreateViewModel()
        {
            Status = "A";
            CreateById = 1;
            CreateDate = DateTime.Now;
        }
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int CourseId { get; set; }
        public int ExamId { get; set; }
        public Nullable<double> Mark { get; set; }
        public int Order { get; set; }
        public string Question1 { get; set; }
        public string QuestionType { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }


    }
}