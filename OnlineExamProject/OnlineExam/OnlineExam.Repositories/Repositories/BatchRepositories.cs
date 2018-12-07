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
    public class BatchRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(Batch entity)
        {
            db.Batches.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(Batch entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Batch entity)
        {
            db.Batches.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<Batch> GetAll()
        {
            return db.Batches.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public Batch GetById(int id)
        {
            return db.Batches.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(Batch entity)
        {
            //Explicit loading
            //db.Entry(entity).Collection(c => c.AttendBatchs).Load();

            //db.Entry(entity)
            //    .Collection(c => c.AttendBatchs)
            //    .Query()
            //    //.Where(c => c.Salary > 2100)
            //    .Load();
        }
    


    }
}
