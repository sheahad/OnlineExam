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
   public class CourseTagRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(CourseTag entity)
        {
            db.CourseTags.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(CourseTag entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(CourseTag entity)
        {
            db.CourseTags.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<CourseTag> GetAll()
        {
            return db.CourseTags.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        //public CourseTag GetById(int id)
        //{
        //   // return db.CourseTags.FirstOrDefault(c => c.Id == id);
        //    return;
        //}

        public void LoadEmloyees(CourseTag entity)
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
