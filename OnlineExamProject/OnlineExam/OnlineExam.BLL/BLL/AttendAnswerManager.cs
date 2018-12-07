using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
    class AttendAnswerManager
    {
        AttendAnswerRepositories _attendAnswerRepositories = new AttendAnswerRepositories();
        public bool Add(AttendAnswer entity)
        {
            return _attendAnswerRepositories.Add(entity);
        }
        public bool Update(AttendAnswer entity)
        {
            return _attendAnswerRepositories.Update(entity);
        }
        public bool Remove(AttendAnswer entity)
        {
            return _attendAnswerRepositories.Remove(entity);
        }
        //public List<AttendAnswer> GetAll()
        //{
        //    return _attendAnswerRepositories.GetAll();
        //}

        public AttendAnswer GetById(int id)
        {
            return _attendAnswerRepositories.GetById(id);
        }

        public void LoadEmloyees(AttendAnswer entity)
        {
            //Explicit loading
            _attendAnswerRepositories.LoadEmloyees(entity);
        }
    


    }
}
