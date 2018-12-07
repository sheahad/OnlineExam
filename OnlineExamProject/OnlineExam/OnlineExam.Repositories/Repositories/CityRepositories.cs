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
  public class CityRepositories
    {
        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(City entity)
        {
            db.Cities.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(City entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(City entity)
        {
            db.Cities.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<City> GetAll()
        {
            return db.Cities.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public City GetById(int id)
        {
            return db.Cities.FirstOrDefault(c => c.Id == id);
        }

        public void LoadCities(City entity)
        {
            //Explicit loading
            //db.Entry(entity).Collection(c => c.AttendAnswers).Load();

            //db.Entry(entity)
            //    .Collection(c => c.)
            //    .Query()
            //    //.Where(c => c.Salary > 2100)
            //    .Load();
        }
    }
}
