using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class ExamManager
    {
       ExamRepositories _examRepositories = new ExamRepositories();
        public bool Add(Exam entity)
        {
            return _examRepositories.Add(entity);
        }
        public bool Update(Exam entity)
        {
            return _examRepositories.Update(entity);
        }
        public bool Remove(Exam entity)
        {
            return _examRepositories.Remove(entity);
        }
        public List<Exam> GetAll()
        {
            return _examRepositories.GetAll();
        }

        public Exam GetById(int id)
        {
            return _examRepositories.GetById(id);
        }

        public void LoadEmloyees(Exam entity)
        {
            //Explicit loading
            _examRepositories.LoadEmloyees(entity);
        }
    


    }
}
