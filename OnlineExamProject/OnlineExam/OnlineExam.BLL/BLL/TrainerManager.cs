using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class TrainerManager
    {
       TrainerRepositories trainerRepositories = new TrainerRepositories();
        public bool Add(Trainer entity)
        {
            return trainerRepositories.Add(entity);
        }
        public bool Update(Trainer entity)
        {
            return trainerRepositories.Update(entity);
        }
        public bool Remove(Trainer entity)
        {
            return trainerRepositories.Remove(entity);
        }
        public List<Trainer> GetAll()
        {
            return trainerRepositories.GetAll();
        }

        public Trainer GetById(int id)
        {
            return trainerRepositories.GetById(id);
        }

        public void LoadEmloyees(Trainer entity)
        {
            //Explicit loading
            trainerRepositories.LoadEmloyees(entity);
        }
    


    }
}
