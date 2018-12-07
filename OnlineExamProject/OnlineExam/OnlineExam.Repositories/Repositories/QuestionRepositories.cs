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
   public class QuestionRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(Question entity)
        {
            db.Questions.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(Question entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Question entity)
        {
            db.Questions.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<Question> GetAll()
        {
            return db.Questions.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public Question GetById(int id)
        {
            return db.Questions.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(Question entity)
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
