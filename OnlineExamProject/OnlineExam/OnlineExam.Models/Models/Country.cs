using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Country
    {
  

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int CreateById { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}
