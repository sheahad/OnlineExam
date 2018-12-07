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
   public class AttendExamRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(AttendExam entity)
        {
            db.AttendExams.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(AttendExam entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(AttendExam entity)
        {
            db.AttendExams.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<AttendExam> GetAll()
        {
            return db.AttendExams.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public AttendExam GetById(int id)
        {
            return db.AttendExams.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(AttendExam entity)
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
