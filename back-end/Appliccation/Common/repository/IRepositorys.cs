using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * repository générique
 * pour la gestion des entité en Db
 */

namespace Application.Common.repository
{
    public interface IRepositorys<T> where T :class
    {

        Task Create(T item);
        Task Update(int id, T item);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        void Delete(int id);
    }
}
