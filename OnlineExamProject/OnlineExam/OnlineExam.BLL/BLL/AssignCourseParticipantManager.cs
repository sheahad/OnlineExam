using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class AssignCourseParticipantManager
    {
       AssignCourseParticipantRepositories _assignCourseParticipantRepositories = new AssignCourseParticipantRepositories();
        public bool Add(AssignCourseParticipant entity)
        {
            return _assignCourseParticipantRepositories.Add(entity);
        }
        public bool Update(AssignCourseParticipant entity)
        {
            return _assignCourseParticipantRepositories.Update(entity);
        }
        public bool Remove(AssignCourseParticipant entity)
        {
            return _assignCourseParticipantRepositories.Remove(entity);
        }
        public List<AssignCourseParticipant> GetAll()
        {
            return _assignCourseParticipantRepositories.GetAll();
        }

        //public AssignCourseParticipant GetById(int id)
        //{
        //    return _assignCourseParticipantRepositories.GetById(id);
        //}

        public void LoadEmloyees(AssignCourseParticipant entity)
        {
            //Explicit loading
            _assignCourseParticipantRepositories.LoadEmloyees(entity);
        }
    


    }
}
