using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataAccess.EFCore
{
    public class UserRepository : IGenericRepository<User> 
    {
        private readonly DB_Context _context;
        public UserRepository(DB_Context context)
        {
            _context = context;
        }
        public void Add(User t)
        {
            _context.Users.Add(t);
            _context.SaveChanges();
            //throw new NotImplementedException();
            ////okay ?
        }

        public void Delete(User id)
        {

            _context.Users.Remove(id);
            _context.SaveChanges();
          //  throw new NotImplementedException();
        }

        public void Edit(User t)
        {
            _context.Users.Update(t);
            _context.SaveChanges();  
            //hrow new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
           // throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
            //throw new NotImplementedException();
        }
    }
}
