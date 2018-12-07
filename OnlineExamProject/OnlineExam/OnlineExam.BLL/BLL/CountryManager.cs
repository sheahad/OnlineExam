using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;

namespace OnlineExam.BLL.BLL
{
   public class CountryManager
    {
       CountryRepositories _countryRepositories = new CountryRepositories();
        public bool Add(Country entity)
        {
            return _countryRepositories.Add(entity);
        }
        public bool Update(Country entity)
        {
            return _countryRepositories.Update(entity);
        }
        public bool Remove(Country entity)
        {
            return _countryRepositories.Remove(entity);
        }
        public List<Country> GetAll()
        {
            return _countryRepositories.GetAll();
        }

        public Country GetById(int id)
        {
            return _countryRepositories.GetById(id);
        }

        public void LoadEmloyees(Country entity)
        {
            //Explicit loading
            _countryRepositories.LoadEmloyees(entity);
        }
    


    }
}
