using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
    public class ParticipantManager
    {
        ParticipantRepositories _participantRepositories= new ParticipantRepositories();
        public bool Add(Participant entity)
        {
            return _participantRepositories.Add(entity);
        }
        public bool Update(Participant entity)
        {
            return _participantRepositories.Update(entity);
        }
        public bool Remove(Participant entity)
        {
            return _participantRepositories.Remove(entity);
        }
        public List<Participant> GetAll()
        {
            return _participantRepositories.GetAll();
        }

        public Participant GetById(int id)
        {
            return _participantRepositories.GetById(id);
        }

        public void LoadEmloyees(Participant entity)
        {
            //Explicit loading
            _participantRepositories.LoadEmloyees(entity);
        }
    


    }
}
