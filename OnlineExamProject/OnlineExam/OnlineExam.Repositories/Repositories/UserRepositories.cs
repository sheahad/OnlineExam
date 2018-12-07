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
   public class UserRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(User entity)
        {
            db.Users.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(User entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(User entity)
        {
            db.Users.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<User> GetAll()
        {
            return db.Users.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public User GetById(int id)
        {
            return db.Users.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(User entity)
        {
            //Explicit loading
            //db.Entry(entity).Collection(c => c.AttendUsers).Load();

            //db.Entry(entity)
            //    .Collection(c => c.AttendUsers)
            //    .Query()
            //    //.Where(c => c.Salary > 2100)
            //    .Load();
        }
    


    }
}
