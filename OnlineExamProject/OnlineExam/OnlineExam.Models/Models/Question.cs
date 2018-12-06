using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Question
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
            this.AttendQuestions = new HashSet<AttendQuestion>();
        }

        public int Id { get; set; }
        public Nullable<int> OrganiaationId { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> ExamId { get; set; }
        public Nullable<double> Mark { get; set; }
        public Nullable<int> Order { get; set; }
        public string Question1 { get; set; }
        public string QuestionType { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<AttendQuestion> AttendQuestions { get; set; }
        public virtual Cours Cours { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
    }
}
