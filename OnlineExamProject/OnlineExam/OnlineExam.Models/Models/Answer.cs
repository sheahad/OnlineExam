using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Answer
    {
        public Answer()
        {
            this.AttendAnswers = new HashSet<AttendAnswer>();
        }

        public int Id { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public Nullable<int> Order { get; set; }
        public string Answer1 { get; set; }
        public Nullable<int> Result { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<AttendAnswer> AttendAnswers { get; set; }
    }
}
