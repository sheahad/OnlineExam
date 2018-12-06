using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class User
    {
        public User()
        {
            this.AssignBatchParticipants = new HashSet<AssignBatchParticipant>();
            this.AssignBatchTrainers = new HashSet<AssignBatchTrainer>();
            this.AssignCourseParticipants = new HashSet<AssignCourseParticipant>();
            this.AssignCourseTrainers = new HashSet<AssignCourseTrainer>();
            this.AttendExams = new HashSet<AttendExam>();
            this.AttendQuestions = new HashSet<AttendQuestion>();
            this.Batchs = new HashSet<Batch>();
            this.Cities = new HashSet<City>();
            this.Countries = new HashSet<Country>();
            this.Courses = new HashSet<Cours>();
            this.CourseTags = new HashSet<CourseTag>();
            this.Exams = new HashSet<Exam>();
            this.Organizations = new HashSet<Organization>();
            this.Participants = new HashSet<Participant>();
            this.Questions = new HashSet<Question>();
            this.ScheduleExams = new HashSet<ScheduleExam>();
            this.Tags = new HashSet<Tag>();
            this.Trainers = new HashSet<Trainer>();
            this.Users1 = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> LastLogIn { get; set; }
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
        public virtual ICollection<Cours> Courses { get; set; }
        public virtual ICollection<CourseTag> CourseTags { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ScheduleExam> ScheduleExams { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<User> Users1 { get; set; }
        public virtual User User1 { get; set; }
    }

}
