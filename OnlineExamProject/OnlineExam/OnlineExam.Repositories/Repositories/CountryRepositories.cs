using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DatabaseContext.DatabaseContext;
using OnlineExam.Models.Models;

namespace OnlineExam.Repositories.Repositories
{
   public class CountryRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(Country entity)
        {
            db.Countries.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(Country entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Country entity)
        {
            db.Countries.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<Country> GetAll()
        {
            return db.Countries.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public Country GetById(int id)
        {
            return db.Countries.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(Country entity)
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
