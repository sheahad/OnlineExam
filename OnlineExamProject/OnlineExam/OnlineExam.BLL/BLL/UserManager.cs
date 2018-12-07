using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class UserManager
    {
       UserRepositories _userRepositories = new UserRepositories();
        public bool Add(User entity)
        {
            return _userRepositories.Add(entity);
        }
        public bool Update(User entity)
        {
            return _userRepositories.Update(entity);
        }
        public bool Remove(User entity)
        {
            return _userRepositories.Remove(entity);
        }
        public List<User> GetAll()
        {
            return _userRepositories.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepositories.GetById(id);
        }

        public void LoadEmloyees(User entity)
        {
            //Explicit loading
            _userRepositories.LoadEmloyees(entity);
        }
    


    }
}
