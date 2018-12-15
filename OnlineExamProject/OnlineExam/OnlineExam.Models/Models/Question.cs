using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Question
    {
   

        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int CourseId { get; set; }
        public int ExamId { get; set; }
        public double Mark { get; set; }
        public int QOrder { get; set; }
        public string Question1 { get; set; }
        public string QuestionType { get; set; }
        public string Status { get; set; }
        [ForeignKey("User")]
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<AttendQuestion> AttendQuestions { get; set; }
        public virtual Course Course { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
    }
}
