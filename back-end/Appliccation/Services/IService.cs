using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IService<T> where T : class
    {
        T Get();
        T GetbyId(int id);
        void DeleteById(int id);
        void UpdateById(int id ,T entity);
        void Create(T entity);
    }
}
