using Business.Configuration.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountService
    {
        public IEnumerable<Account> getAll();
        public CommandResponse Insert(Account account);
        public CommandResponse Update(Account account);
        public CommandResponse Delete(Account account);
    }
}
