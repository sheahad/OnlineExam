using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{


    public class Trainer
    {
  

        public int Id { get; set; }
        public int OrganiaationId { get; set; }
        public string Name { get; set; }
        public string ConatactNo { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public int CountryId { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AssignBatchTrainer> AssignBatchTrainers { get; set; }
        public virtual ICollection<AssignCourseTrainer> AssignCourseTrainers { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
    }


}
