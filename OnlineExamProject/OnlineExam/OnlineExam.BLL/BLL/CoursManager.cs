using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class CoursManager
    {
       CoursRepositories _coursRepositories= new CoursRepositories();
        public bool Add(Course entity)
        {
            return _coursRepositories.Add(entity);
        }
        public bool Update(Course entity)
        {
            return _coursRepositories.Update(entity);
        }
        public bool Remove(Course entity)
        {
            return _coursRepositories.Remove(entity);
        }
        public List<Course> GetAll()
        {
            return _coursRepositories.GetAll();
        }

        public Course GetById(int id)
        {
            return _coursRepositories.GetById(id);
        }

        public void LoadEmloyees(Course entity)
        {
            //Explicit loading
            _coursRepositories.LoadEmloyees(entity);
        }
    


    }
}
