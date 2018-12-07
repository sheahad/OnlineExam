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
    public class AnswerRepositories
    {
        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(Answer entity)
        {
            db.Answers.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(Answer entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Answer entity)
        {
            db.Answers.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<Answer> GetAll()
        {
            return db.Answers.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public Answer GetById(int id)
        {
            return db.Answers.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(Answer entity)
        {
            //Explicit loading
            //db.Entry(entity).Collection(c => c.AttendAnswers).Load();

            db.Entry(entity)
                .Collection(c => c.AttendAnswers)
                .Query()
                //.Where(c => c.Salary > 2100)
                .Load();
        }
    }
}
