using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;


namespace OnlineExam.BLL.BLL
{
    public class AnswerManager
    {
        AnswerRepositories _answerRepositories = new AnswerRepositories();
        public bool Add(Answer entity)
        {
            return _answerRepositories.Add(entity);
        }
        public bool Update(Answer entity)
        {
            return _answerRepositories.Update(entity);
        }
        public bool Remove(Answer entity)
        {
            return _answerRepositories.Remove(entity);
        }
        public List<Answer> GetAll()
        {
            return _answerRepositories.GetAll();
        }

        public Answer GetById(int id)
        {
            return _answerRepositories.GetById(id);
        }

        public void LoadEmloyees(Answer entity)
        {
            //Explicit loading
            _answerRepositories.LoadEmloyees(entity);
        }
    }
}
