using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class OrganizationManager
    {
        OrganizationRepositories _organizationRepositories= new OrganizationRepositories();
        public bool Add(Organization entity)
        {
            return _organizationRepositories.Add(entity);
        }
        public bool Update(Organization entity)
        {
            return _organizationRepositories.Update(entity);
        }
        public bool Remove(Organization entity)
        {
            return _organizationRepositories.Remove(entity);
        }
        public List<Organization> GetAll()
        {
            return _organizationRepositories.GetAll();
        }

        public Organization GetById(int id)
        {
            return _organizationRepositories.GetById(id);
        }

        public void LoadEmloyees(Organization entity)
        {
            //Explicit loading
            _organizationRepositories.LoadEmloyees(entity);
        }
    


    }
}
