using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Organization
    {
       

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string ConatactNo { get; set; }
        public string About { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
        [ForeignKey("User")]
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AttendExam> AttendExams { get; set; }
        public virtual ICollection<Batch> Batchs { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}
