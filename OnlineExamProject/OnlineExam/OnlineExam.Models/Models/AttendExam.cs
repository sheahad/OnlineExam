using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class AttendExam
    {
   

        public int Id { get; set; }
        public int OrganizationId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public int ParticipantId { get; set; }
        public int ExamId { get; set; }
        public DateTime AttendExamDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public double TotalMarks { get; set; }
        public string Status { get; set; }
        [ForeignKey("User")]
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Course Course { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual User User { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Participant Participant { get; set; }
        public virtual ICollection<AttendQuestion> AttendQuestions { get; set; }
    }
}
