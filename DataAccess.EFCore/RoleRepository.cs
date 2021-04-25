using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.EFCore
{
    public class RoleRepository : IGenericRepository<Roles>
    {
        private readonly DB_Context _context;
        public RoleRepository(DB_Context context)
        {
            _context = context;
        }
        public void Add(Roles t)
        {
            _context.Roles.Add(t);
            _context.SaveChanges();
        }

        public void Delete(Roles id)
        {
            _context.Roles.Remove(id);
            _context.SaveChanges();
        }

        public void Edit(Roles t)
        {
            _context.Roles.Update(t);
            _context.SaveChanges();
        }

        public List<Roles> GetAll()
        {
            return _context.Roles.ToList();
        }

        public Roles GetById(int id)
        {
            return _context.Roles.Find(id);
        }
    }
}
