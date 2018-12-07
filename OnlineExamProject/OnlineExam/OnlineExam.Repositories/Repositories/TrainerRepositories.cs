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
   public class TrainerRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(Trainer entity)
        {
            db.Trainers.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(Trainer entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Trainer entity)
        {
            db.Trainers.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<Trainer> GetAll()
        {
            return db.Trainers.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public Trainer GetById(int id)
        {
            return db.Trainers.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(Trainer entity)
        {
            //Explicit loading
            //db.Entry(entity).Collection(c => c.AttendTrainers).Load();

            //db.Entry(entity)
            //    .Collection(c => c.AttendTrainers)
            //    .Query()
            //    //.Where(c => c.Salary > 2100)
            //    .Load();
        }
    


    }
}
