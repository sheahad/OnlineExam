using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
    public class AttendExamManager
    {
        AttendExamRepositories _attendExamRepositories = new AttendExamRepositories();
        public bool Add(AttendExam entity)
        {
            return _attendExamRepositories.Add(entity);
        }
        public bool Update(AttendExam entity)
        {
            return _attendExamRepositories.Update(entity);
        }
        public bool Remove(AttendExam entity)
        {
            return _attendExamRepositories.Remove(entity);
        }
        public List<AttendExam> GetAll()
        {
            return _attendExamRepositories.GetAll();
        }

        public AttendExam GetById(int id)
        {
            return _attendExamRepositories.GetById(id);
        }

        public void LoadEmloyees(AttendExam entity)
        {
            //Explicit loading
            _attendExamRepositories.LoadEmloyees(entity);
        }
    


    }
}
