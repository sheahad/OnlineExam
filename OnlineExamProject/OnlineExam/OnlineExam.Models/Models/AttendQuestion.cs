using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class AttendQuestion
    {
 
        public int Id { get; set; }
        public int AttendExamId { get; set; }
        public int QuestionId { get; set; }
        public string Status { get; set; }
        [ForeignKey("User")]
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AttendAnswer> AttendAnswers { get; set; }
        public virtual AttendExam AttendExam { get; set; }
        public virtual User User { get; set; }
        public virtual Question Question { get; set; }
    }
}
