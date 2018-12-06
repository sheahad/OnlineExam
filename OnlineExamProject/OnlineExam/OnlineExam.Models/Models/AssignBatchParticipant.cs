using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class AssignBatchParticipant
    {
        [Key, Column(Order = 0)]
        public int BatchId { get; set; }
        [Key, Column(Order = 1)]
        public int ParticipantId { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual Participant Participant { get; set; }
        public virtual User User { get; set; }
    }
}
