using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class AttendAnswer
    {
        public int Id { get; set; }
        public int AttendQuestionId { get; set; }
        public int AnswerId { get; set; }
        public int AttendAnswer1 { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Answer Answer { get; set; }
        public virtual AttendQuestion AttendQuestion { get; set; }
    }
}
