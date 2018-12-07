using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
    public class AssignBatchTrainerManager
    {
        AssignBatchTrainerRepositories _assignBatchTrainerRepositories = new AssignBatchTrainerRepositories();
        public bool Add(AssignBatchTrainer entity)
        {
            return _assignBatchTrainerRepositories.Add(entity);
        }
        public bool Update(AssignBatchTrainer entity)
        {
            return _assignBatchTrainerRepositories.Update(entity);
        }
        public bool Remove(AssignBatchTrainer entity)
        {
            return _assignBatchTrainerRepositories.Remove(entity);
        }
        public List<AssignBatchTrainer> GetAll()
        {
            return _assignBatchTrainerRepositories.GetAll();
        }

        //public AssignBatchTrainer GetById(int id)
        //{
        //    return _assignBatchTrainerRepositories.GetById(id);
        //}

        public void LoadEmloyees(AssignBatchTrainer entity)
        {
            //Explicit loading
            _assignBatchTrainerRepositories.LoadEmloyees(entity);
        }
    


    }
}
