using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class AssignCourseTrainerManager
    {
       AssignCourseTrainerRepositories _assignCourseTrainerRepositories= new AssignCourseTrainerRepositories();
        public bool Add(AssignCourseTrainer entity)
        {
            return _assignCourseTrainerRepositories.Add(entity);
        }
        public bool Update(AssignCourseTrainer entity)
        {
            return _assignCourseTrainerRepositories.Update(entity);
        }
        public bool Remove(AssignCourseTrainer entity)
        {
            return _assignCourseTrainerRepositories.Remove(entity);
        }
        public List<AssignCourseTrainer> GetAll()
        {
            return _assignCourseTrainerRepositories.GetAll();
        }

        //public AssignCourseTrainer GetById(int id)
        //{
        //    return _assignCourseTrainerRepositories.GetById(id);
        //}

        public void LoadEmloyees(AssignCourseTrainer entity)
        {
            //Explicit loading
            _assignCourseTrainerRepositories.LoadEmloyees(entity);
        }
    


    }
}
