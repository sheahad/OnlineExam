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
    public class AssignBatchTrainerRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(AssignBatchTrainer entity)
        {
            db.AssignBatchTrainers.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(AssignBatchTrainer entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(AssignBatchTrainer entity)
        {
            db.AssignBatchTrainers.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<AssignBatchTrainer> GetAll()
        {
            return db.AssignBatchTrainers.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        //public AssignBatchTrainer GetById(int id)
        //{
        //    return db.AssignBatchTrainers.FirstOrDefault(c => c.Id == id);
        //}

        public void LoadEmloyees(AssignBatchTrainer entity)
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
