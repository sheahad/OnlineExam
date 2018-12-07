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
        public bool Add(Cours entity)
        {
            return _coursRepositories.Add(entity);
        }
        public bool Update(Cours entity)
        {
            return _coursRepositories.Update(entity);
        }
        public bool Remove(Cours entity)
        {
            return _coursRepositories.Remove(entity);
        }
        public List<Cours> GetAll()
        {
            return _coursRepositories.GetAll();
        }

        public Cours GetById(int id)
        {
            return _coursRepositories.GetById(id);
        }

        public void LoadEmloyees(Cours entity)
        {
            //Explicit loading
            _coursRepositories.LoadEmloyees(entity);
        }
    


    }
}
