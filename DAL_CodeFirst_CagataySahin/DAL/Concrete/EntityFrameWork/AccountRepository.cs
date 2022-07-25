using DAL.Abstract;
using DAL.DBContexts;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class AccountRepository : IAccountRepository
    {
        private TODEBAccountDbContext _context;
        public AccountRepository(TODEBAccountDbContext context)
        {
            _context = context;
        }

        public void Delete(Account account)
        {
            _context.Remove(account);
            _context.SaveChanges();
        }

        public IEnumerable<Account> getAll()
        {
            return _context.Accounts.ToList();
        }

        public void Insert(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void Update(Account account)
        {
            _context.Accounts.Update(account);
            _context.SaveChanges();
        }
    }
}
