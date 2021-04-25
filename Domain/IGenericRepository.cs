using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IGenericRepository<T> 
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T t);
        void Edit(T t);
        void Delete(T id);

    }
}
