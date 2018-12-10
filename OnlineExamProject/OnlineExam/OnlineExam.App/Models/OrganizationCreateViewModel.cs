using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string ConatactNo { get; set; }
        public string About { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

    }
}