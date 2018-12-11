using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string BatchNo { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        [ForeignKey("User")]
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AssignBatchParticipant> AssignBatchParticipants { get; set; }
        public virtual ICollection<AssignBatchTrainer> AssignBatchTrainers { get; set; }
        public virtual Course Course { get; set; }
        //
        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ScheduleExam> ScheduleExams { get; set; }
    }
}
