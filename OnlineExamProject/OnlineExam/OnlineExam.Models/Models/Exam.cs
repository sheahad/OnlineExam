using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Exam
    {
     

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

        public virtual ICollection<AttendExam> AttendExams { get; set; }
        public virtual Cours Cours { get; set; }
        public virtual User User { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ScheduleExam> ScheduleExams { get; set; }
    }
}
