using Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class Service<T> : IService<T> where T : class
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public T Get()
        {
            throw new NotImplementedException();
        }

        public T GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateById(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
