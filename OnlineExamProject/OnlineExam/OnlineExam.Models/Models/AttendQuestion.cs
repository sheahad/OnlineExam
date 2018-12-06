using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class AttendQuestion
    {
        public AttendQuestion()
        {
            this.AttendAnswers = new HashSet<AttendAnswer>();
        }

        public int Id { get; set; }
        public Nullable<int> AttendExamId { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual ICollection<AttendAnswer> AttendAnswers { get; set; }
        public virtual AttendExam AttendExam { get; set; }
        public virtual User User { get; set; }
        public virtual Question Question { get; set; }
    }
}
