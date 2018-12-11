using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public int OrganizationId { get; set; }
        public int CourseId { get; set; }
        public int BatchNo { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

    }
}