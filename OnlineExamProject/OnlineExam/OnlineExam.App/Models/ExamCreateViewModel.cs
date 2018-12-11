using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public int OrganiaationId { get; set; }
        public int CourseId { get; set; }
        public string ExamType { get; set; }
        public string Code { get; set; }
        public string Topic { get; set; }
        public int FullMark { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }
    }
}