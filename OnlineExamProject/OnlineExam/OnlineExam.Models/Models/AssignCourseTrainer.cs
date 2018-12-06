using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class AssignCourseTrainer
    {
        [Key, Column(Order = 0)]

        public int CourseId { get; set; }
        [Key, Column(Order = 1)]
        public int TrainerId { get; set; }
        public Nullable<int> Lead { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual Cours Cours { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual User User { get; set; }
    }
}
