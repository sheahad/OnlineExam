using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.Models.Models;
using OnlineExam.Repositories.Repositories;


namespace OnlineExam.BLL.BLL
{
   public class CityManager
    {
       CityRepositories _cityRepositories = new CityRepositories();
        public bool Add(City entity)
        {
            return _cityRepositories.Add(entity);
        }
        public bool Update(City entity)
        {
            return _cityRepositories.Update(entity);
        }
        public bool Remove(City entity)
        {
            return _cityRepositories.Remove(entity);
        }
        public List<City> GetAll()
        {
            return _cityRepositories.GetAll();
        }

        public City GetById(int id)
        {
            return _cityRepositories.GetById(id);
        }

        public void LoadEmloyees(City entity)
        {
            //Explicit loading
           // _cityRepositories.LoadEmloyees(entity);
        }
    }
}
