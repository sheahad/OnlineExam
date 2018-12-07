using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class ScheduleExamManager
    {
       ScheduleExamRepositories _scheduleExamRepositories = new ScheduleExamRepositories();
        public bool Add(ScheduleExam entity)
        {
            return _scheduleExamRepositories.Add(entity);
        }
        public bool Update(ScheduleExam entity)
        {
            return _scheduleExamRepositories.Update(entity);
        }
        public bool Remove(ScheduleExam entity)
        {
            return _scheduleExamRepositories.Remove(entity);
        }
        public List<ScheduleExam> GetAll()
        {
            return _scheduleExamRepositories.GetAll();
        }

        public ScheduleExam GetById(int id)
        {
            return _scheduleExamRepositories.GetById(id);
        }

        public void LoadEmloyees(ScheduleExam entity)
        {
            //Explicit loading
            _scheduleExamRepositories.LoadEmloyees(entity);
        }
    


    }
}
