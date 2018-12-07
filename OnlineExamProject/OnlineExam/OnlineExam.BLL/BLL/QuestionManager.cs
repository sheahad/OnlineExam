using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class QuestionManager
    {
       QuestionRepositories _questionRepositories= new QuestionRepositories();
        public bool Add(Question entity)
        {
            return _questionRepositories.Add(entity);
        }
        public bool Update(Question entity)
        {
            return _questionRepositories.Update(entity);
        }
        public bool Remove(Question entity)
        {
            return _questionRepositories.Remove(entity);
        }
        public List<Question> GetAll()
        {
            return _questionRepositories.GetAll();
        }

        public Question GetById(int id)
        {
            return _questionRepositories.GetById(id);
        }

        public void LoadEmloyees(Question entity)
        {
            //Explicit loading
            _questionRepositories.LoadEmloyees(entity);
        }
    


    }
}
