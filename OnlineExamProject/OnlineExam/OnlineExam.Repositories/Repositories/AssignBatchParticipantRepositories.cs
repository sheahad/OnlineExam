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
   public class AssignBatchParticipantRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(AssignBatchParticipant entity)
        {
            db.AssignBatchParticipants.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(AssignBatchParticipant entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(AssignBatchParticipant entity)
        {
            db.AssignBatchParticipants.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<AssignBatchParticipant> GetAll()
        {
            return db.AssignBatchParticipants.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        //public AssignBatchParticipant GetById(int id)
        //{
        //    //return db.AssignBatchParticipants.FirstOrDefault(c => c.Id == id);
        //}

        public void LoadEmloyees(AssignBatchParticipant entity)
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
