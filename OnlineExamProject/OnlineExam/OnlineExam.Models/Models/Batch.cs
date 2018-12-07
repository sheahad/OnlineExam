using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Batch
    {


        public int Id { get; set; }
        //
        public int OrganizationId { get; set; }
        public int CourseId { get; set; }
        public int BatchNo { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AssignBatchParticipant> AssignBatchParticipants { get; set; }
        public virtual ICollection<AssignBatchTrainer> AssignBatchTrainers { get; set; }
        public virtual Cours Cours { get; set; }
        //
        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ScheduleExam> ScheduleExams { get; set; }
    }
}
