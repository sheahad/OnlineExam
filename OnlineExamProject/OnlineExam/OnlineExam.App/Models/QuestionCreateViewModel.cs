using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExam.App.Models
{
    public class QuestionCreateViewModel
    {
        public int Id { get; set; }
        public int OrganiaationId { get; set; }
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