using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        //[ForeignKey("User")]
        public int CreateById { get; set; }
        public DateTime LastLogIn { get; set; }
        public string Status { get; set; }

        public virtual ICollection<AssignBatchParticipant> AssignBatchParticipants { get; set; }
        public virtual ICollection<AssignBatchTrainer> AssignBatchTrainers { get; set; }
        public virtual ICollection<AssignCourseParticipant> AssignCourseParticipants { get; set; }
        public virtual ICollection<AssignCourseTrainer> AssignCourseTrainers { get; set; }
        public virtual ICollection<AttendExam> AttendExams { get; set; }
        public virtual ICollection<AttendQuestion> AttendQuestions { get; set; }
        public virtual ICollection<Batch> Batchs { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<CourseTag> CourseTags { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ScheduleExam> ScheduleExams { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
    }

}
