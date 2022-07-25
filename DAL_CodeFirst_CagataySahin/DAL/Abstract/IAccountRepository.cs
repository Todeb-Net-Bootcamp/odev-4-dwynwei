using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IAccountRepository
    {
        public IEnumerable<Account> getAll();
        public void Insert(Account account);
        public void Update(Account account);
        public void Delete(Account account);
    }
}
