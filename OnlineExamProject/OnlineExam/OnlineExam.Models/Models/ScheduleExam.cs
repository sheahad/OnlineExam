using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class ScheduleExam
    {
        public int Id { get; set; }
        public Nullable<int> BatchId { get; set; }
        public Nullable<int> ExamId { get; set; }
        public Nullable<System.DateTime> ExamDate { get; set; }
        public Nullable<System.TimeSpan> ExamTime { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual User User { get; set; }
    }
}
