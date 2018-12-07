using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DatabaseContext.DatabaseContext;
using OnlineExam.Models.Models;

namespace OnlineExam.Repositories.Repositories
{
   public class ParticipantRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(Participant entity)
        {
            db.Participants.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(Participant entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Participant entity)
        {
            db.Participants.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<Participant> GetAll()
        {
            return db.Participants.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public Participant GetById(int id)
        {
            return db.Participants.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(Participant entity)
        {
            //Explicit loading
            //db.Entry(entity).Collection(c => c.AttendAnswers).Load();

            //db.Entry(entity)
            //    .Collection(c => c.AttendAnswers)
            //    .Query()
            //    //.Where(c => c.Salary > 2100)
            //    .Load();
        }
    


    }
}
