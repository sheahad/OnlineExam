using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Answer
    {
  

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int Order { get; set; }
        public string Answer1 { get; set; }
        public int Result { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Question Question { get; set; }
        public virtual ICollection<AttendAnswer> AttendAnswers { get; set; }
    }
}
