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
   public class TagRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(Tag entity)
        {
            db.Tags.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(Tag entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(Tag entity)
        {
            db.Tags.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<Tag> GetAll()
        {
            return db.Tags.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        public Tag GetById(int id)
        {
            return db.Tags.FirstOrDefault(c => c.Id == id);
        }

        public void LoadEmloyees(Tag entity)
        {
            //Explicit loading
            //db.Entry(entity).Collection(c => c.AttendTags).Load();

           // db.Entry(entity)
               // .Collection(c => c.AttendTags)
               // .Query()
                //.Where(c => c.Salary > 2100)
                //.Load();
        }
    


    }
}
