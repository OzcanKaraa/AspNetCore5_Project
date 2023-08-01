using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfExperienceDal : GenericRepository<Exception>, IExperienceDal
    {
        public void Delete(Experience t)
        {
            throw new NotImplementedException();
        }

        public void Insert(Experience t)
        {
            throw new NotImplementedException();
        }

        public void Update(Experience t)
        {
            throw new NotImplementedException();
        }

        Experience IGenericDal<Experience>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<Experience> IGenericDal<Experience>.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
