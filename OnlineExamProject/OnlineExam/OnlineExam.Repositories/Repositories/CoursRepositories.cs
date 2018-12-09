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
    public class CoursRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(Course entity)
        {
            db.Courses.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(Course entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Course entity)
        {
            db.Courses.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<Course> GetAll()
        {
            return db.Courses.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public Course GetById(int id)
        {
            return db.Courses.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(Course entity)
        {
            //Explicit loading
            //db.Entry(entity).Collection(c => c.AttendCourss).Load();

            //db.Entry(entity)
            //    .Collection(c => c.AttendCourss)
            //    .Query()
            //    //.Where(c => c.Salary > 2100)
            //    .Load();
        }
    


    }
}
