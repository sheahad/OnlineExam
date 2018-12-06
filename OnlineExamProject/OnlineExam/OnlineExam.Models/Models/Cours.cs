using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Cours
    {
        public Cours()
        {
            this.AssignCourseParticipants = new HashSet<AssignCourseParticipant>();
            this.AssignCourseTrainers = new HashSet<AssignCourseTrainer>();
            this.AttendExams = new HashSet<AttendExam>();
            this.Batchs = new HashSet<Batch>();
            this.CourseTags = new HashSet<CourseTag>();
            this.Exams = new HashSet<Exam>();
            this.Questions = new HashSet<Question>();
        }

        public int Id { get; set; }
        public Nullable<int> OrganiaationId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<double> CourseDuration { get; set; }
        public Nullable<int> Credit { get; set; }
        public Nullable<double> Fee { get; set; }
        public string Outline { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual ICollection<AssignCourseParticipant> AssignCourseParticipants { get; set; }
        public virtual ICollection<AssignCourseTrainer> AssignCourseTrainers { get; set; }
        public virtual ICollection<AttendExam> AttendExams { get; set; }
        public virtual ICollection<Batch> Batchs { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual ICollection<CourseTag> CourseTags { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
