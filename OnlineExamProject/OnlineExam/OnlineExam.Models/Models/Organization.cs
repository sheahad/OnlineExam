﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Organization
    {
        public Organization()
        {
            this.AttendExams = new HashSet<AttendExam>();
            this.Batchs = new HashSet<Batch>();
            this.Courses = new HashSet<Cours>();
            this.Exams = new HashSet<Exam>();
            this.Participants = new HashSet<Participant>();
            this.Questions = new HashSet<Question>();
            this.Trainers = new HashSet<Trainer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string ConatactNo { get; set; }
        public string About { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual ICollection<AttendExam> AttendExams { get; set; }
        public virtual ICollection<Batch> Batchs { get; set; }
        public virtual ICollection<Cours> Courses { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}
