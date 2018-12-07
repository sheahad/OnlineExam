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
   public class ExamRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(Exam entity)
        {
            db.Exams.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(Exam entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Exam entity)
        {
            db.Exams.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<Exam> GetAll()
        {
            return db.Exams.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public Exam GetById(int id)
        {
            return db.Exams.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(Exam entity)
        {
            //Explicit loading
            //db.Entry(entity).Collection(c => c.AttendExams).Load();

            db.Entry(entity)
                .Collection(c => c.AttendExams)
                .Query()
                //.Where(c => c.Salary > 2100)
                .Load();
        }
    


    }
}
