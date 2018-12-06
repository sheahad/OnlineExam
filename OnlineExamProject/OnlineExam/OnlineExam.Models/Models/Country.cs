﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Models
{
    public class Country
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
            this.Participants = new HashSet<Participant>();
            this.Trainers = new HashSet<Trainer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Nullable<int> CreateById { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}
