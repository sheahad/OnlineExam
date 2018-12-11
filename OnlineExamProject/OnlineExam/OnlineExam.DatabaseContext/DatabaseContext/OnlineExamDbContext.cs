using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;

namespace OnlineExam.DatabaseContext.DatabaseContext
{
    public class OnlineExamDbContext : DbContext
    {
        public OnlineExamDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }

        //public DbSet<Answer> Employees { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AssignBatchParticipant> AssignBatchParticipants { get; set; }
        public DbSet<AssignBatchTrainer> AssignBatchTrainers { get; set; }
        public DbSet<AssignCourseParticipant> AssignCourseParticipants { get; set; }
        public DbSet<AssignCourseTrainer> AssignCourseTrainers { get; set; }
        public DbSet<AttendAnswer> AttendAnswers { get; set; }
        public DbSet<AttendExam> AttendExams { get; set; }
        public DbSet<AttendQuestion> AttendQuestions { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ScheduleExam> ScheduleExams { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<User> Users { get; set; }



       
    }
}
