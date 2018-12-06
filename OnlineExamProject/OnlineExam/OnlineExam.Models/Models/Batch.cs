using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Batch
    {
        public Batch()
        {
            this.AssignBatchParticipants = new HashSet<AssignBatchParticipant>();
            this.AssignBatchTrainers = new HashSet<AssignBatchTrainer>();
            this.ScheduleExams = new HashSet<ScheduleExam>();
        }

        public int Id { get; set; }
        public Nullable<int> OrganiaationId { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> BatchNo { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual ICollection<AssignBatchParticipant> AssignBatchParticipants { get; set; }
        public virtual ICollection<AssignBatchTrainer> AssignBatchTrainers { get; set; }
        public virtual Cours Cours { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ScheduleExam> ScheduleExams { get; set; }
    }
}
