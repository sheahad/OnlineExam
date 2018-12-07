using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class CourseTagManager
    {
        CourseTagRepositories _courseTagRepositories= new CourseTagRepositories();
        public bool Add(CourseTag entity)
        {
            return _courseTagRepositories.Add(entity);
        }
        public bool Update(CourseTag entity)
        {
            return _courseTagRepositories.Update(entity);
        }
        public bool Remove(CourseTag entity)
        {
            return _courseTagRepositories.Remove(entity);
        }
        public List<CourseTag> GetAll()
        {
            return _courseTagRepositories.GetAll();
        }

        //public CourseTag GetById(int id)
        //{
        //    return _courseTagRepositories.GetById(id);
        //}

        public void LoadEmloyees(CourseTag entity)
        {
            //Explicit loading
            _courseTagRepositories.LoadEmloyees(entity);
        }
    


    }
}
