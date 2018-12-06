using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{


    public class Trainer
    {
        public Trainer()
        {
            this.AssignBatchTrainers = new HashSet<AssignBatchTrainer>();
            this.AssignCourseTrainers = new HashSet<AssignCourseTrainer>();
        }

        public int Id { get; set; }
        public Nullable<int> OrganiaationId { get; set; }
        public string Name { get; set; }
        public string ConatactNo { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Nullable<int> CityId { get; set; }
        public string PostalCode { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual ICollection<AssignBatchTrainer> AssignBatchTrainers { get; set; }
        public virtual ICollection<AssignCourseTrainer> AssignCourseTrainers { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
    }


}
