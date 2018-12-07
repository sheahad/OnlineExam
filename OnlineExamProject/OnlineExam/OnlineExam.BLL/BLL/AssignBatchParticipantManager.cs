using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
  public  class AssignBatchParticipantManager
    {
      AssignBatchParticipantRepositories _assignBatchParticipantRepositories = new AssignBatchParticipantRepositories();
        public bool Add(AssignBatchParticipant entity)
        {
            return _assignBatchParticipantRepositories.Add(entity);
        }
        public bool Update(AssignBatchParticipant entity)
        {
            return _assignBatchParticipantRepositories.Update(entity);
        }
        public bool Remove(AssignBatchParticipant entity)
        {
            return _assignBatchParticipantRepositories.Remove(entity);
        }
        public List<AssignBatchParticipant> GetAll()
        {
            return _assignBatchParticipantRepositories.GetAll();
        }

        //public AssignBatchParticipant GetById(int id)
        //{
        //    return _assignBatchParticipantRepositories.GetById(id);
        //}

        public void LoadEmloyees(AssignBatchParticipant entity)
        {
            //Explicit loading
            _assignBatchParticipantRepositories.LoadEmloyees(entity);
        }
    


    }
}
