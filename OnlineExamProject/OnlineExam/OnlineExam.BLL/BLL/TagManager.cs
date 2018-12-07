using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
    public class TagManager
    {
        TagRepositories _tagRepositories = new TagRepositories();
        public bool Add(Tag entity)
        {
            return _tagRepositories.Add(entity);
        }
        public bool Update(Tag entity)
        {
            return _tagRepositories.Update(entity);
        }
        public bool Remove(Tag entity)
        {
            return _tagRepositories.Remove(entity);
        }
        public List<Tag> GetAll()
        {
            return _tagRepositories.GetAll();
        }

        public Tag GetById(int id)
        {
            return _tagRepositories.GetById(id);
        }

        public void LoadEmloyees(Tag entity)
        {
            //Explicit loading
            _tagRepositories.LoadEmloyees(entity);
        }
    


    }
}
