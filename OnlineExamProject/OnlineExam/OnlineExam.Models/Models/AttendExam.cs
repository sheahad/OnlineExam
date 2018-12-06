using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class AttendExam
    {
        public AttendExam()
        {
            this.AttendQuestions = new HashSet<AttendQuestion>();
        }

        public int Id { get; set; }
        public Nullable<int> OrganiaationId { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> ParticipantId { get; set; }
        public Nullable<int> ExamId { get; set; }
        public Nullable<System.DateTime> AttendExamDate { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public Nullable<double> TotalMarks { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual Cours Cours { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual User User { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Participant Participant { get; set; }
        public virtual ICollection<AttendQuestion> AttendQuestions { get; set; }
    }
}
