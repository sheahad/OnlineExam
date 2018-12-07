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
   public class AttendAnswerRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(AttendAnswer entity)
        {
            db.AttendAnswers.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(AttendAnswer entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(AttendAnswer entity)
        {
            db.AttendAnswers.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<AttendAnswer> GetAll()
        {
            return db.AttendAnswers.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public AttendAnswer GetById(int id)
        {
            return db.AttendAnswers.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(AttendAnswer entity)
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
