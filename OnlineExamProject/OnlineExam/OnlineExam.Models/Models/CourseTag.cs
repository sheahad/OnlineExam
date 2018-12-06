using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class CourseTag
    {
        [Key, Column(Order = 0)]

        public int TagId { get; set; }
        [Key, Column(Order = 1)]
        public int CourseId { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Cours Cours { get; set; }
        public virtual User User { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
