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
    public class OrganizationRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(Organization entity)
        {
            db.Organizations.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(Organization entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Organization entity)
        {
            db.Organizations.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<Organization> GetAll()
        {
            return db.Organizations.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public Organization GetById(int id)
        {
            return db.Organizations.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(Organization entity)
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
