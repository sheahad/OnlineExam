using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Exam
    {
        public Exam()
        {
            this.AttendExams = new HashSet<AttendExam>();
            this.Questions = new HashSet<Question>();
            this.ScheduleExams = new HashSet<ScheduleExam>();
        }

        public int Id { get; set; }
        public Nullable<int> OrganiaationId { get; set; }
        public Nullable<int> CourseId { get; set; }
        public string ExamType { get; set; }
        public string Code { get; set; }
        public string Topic { get; set; }
        public Nullable<int> FullMark { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual ICollection<AttendExam> AttendExams { get; set; }
        public virtual Cours Cours { get; set; }
        public virtual User User { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ScheduleExam> ScheduleExams { get; set; }
    }
}
