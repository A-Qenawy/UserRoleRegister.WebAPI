using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace DataAccess.EFCore
{
    class UserRoleRepository : IGenericRepository<UserRole>
    {
        private readonly DB_Context _context;
        public UserRoleRepository(DB_Context context)
        {
            _context = context;
        }
        public void Add(UserRole t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserRole id)
        {
            throw new NotImplementedException();
        }

        public UserRole Edit(UserRole t)
        {
            throw new NotImplementedException();
        }

        public List<UserRole> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserRole GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<UserRole>.Edit(UserRole t)
        {
            throw new NotImplementedException();
        }
    }
}
