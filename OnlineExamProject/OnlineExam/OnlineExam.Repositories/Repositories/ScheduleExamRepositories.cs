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
   public class ScheduleExamRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(ScheduleExam entity)
        {
            db.ScheduleExams.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(ScheduleExam entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(ScheduleExam entity)
        {
            db.ScheduleExams.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<ScheduleExam> GetAll()
        {
            return db.ScheduleExams.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public ScheduleExam GetById(int id)
        {
            return db.ScheduleExams.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(ScheduleExam entity)
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
