using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class BatchManager
    {
       BatchRepositories _batchRepositories = new BatchRepositories();
        public bool Add(Batch entity)
        {
            return _batchRepositories.Add(entity);
        }
        public bool Update(Batch entity)
        {
            return _batchRepositories.Update(entity);
        }
        public bool Remove(Batch entity)
        {
            return _batchRepositories.Remove(entity);
        }
        public List<Batch> GetAll()
        {
            return _batchRepositories.GetAll();
        }

        public Batch GetById(int id)
        {
            return _batchRepositories.GetById(id);
        }

        public void LoadEmloyees(Batch entity)
        {
            //Explicit loading
            _batchRepositories.LoadEmloyees(entity);
        }
    


    }
}
