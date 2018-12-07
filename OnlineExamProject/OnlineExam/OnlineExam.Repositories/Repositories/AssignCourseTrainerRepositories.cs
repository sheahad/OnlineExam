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
   public class AssignCourseTrainerRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(AssignCourseTrainer entity)
        {
            db.AssignCourseTrainers.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(AssignCourseTrainer entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(AssignCourseTrainer entity)
        {
            db.AssignCourseTrainers.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<AssignCourseTrainer> GetAll()
        {
            return db.AssignCourseTrainers.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        //public AssignCourseTrainer GetById(int id)
        //{
        //    return db.AssignCourseTrainers.FirstOrDefault(c => c.Id == id);
        //}

        public void LoadEmloyees(AssignCourseTrainer entity)
        {
            //Explicit loading
            //db.Entry(entity).Collection(c => c.AttendAssignCourseTrainers).Load();

            //db.Entry(entity)
            //    .Collection(c => c.AttendAssignCourseTrainers)
            //    .Query()
            //    //.Where(c => c.Salary > 2100)
            //    .Load();
        }
    


    }
}
