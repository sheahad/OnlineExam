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
   public class AssignCourseParticipantRepositories
    {

        OnlineExamDbContext db = new OnlineExamDbContext();
        public bool Add(AssignCourseParticipant entity)
        {
            db.AssignCourseParticipants.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Update(AssignCourseParticipant entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        public bool Remove(AssignCourseParticipant entity)
        {
            db.AssignCourseParticipants.Remove(entity);
            return db.SaveChanges() > 0;
        }
        public List<AssignCourseParticipant> GetAll()
        {
            return db.AssignCourseParticipants.ToList();
            //EgarLoading Include Employee 
            //return db.Departments.Include(c=>c.Employees).ToList();
        }
        //public AssignCourseParticipant GetById(int id)
        //{
        //    return db.AssignCourseParticipants.FirstOrDefault(c => c.Id == id);
        //}

        public void LoadEmloyees(AssignCourseParticipant entity)
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
