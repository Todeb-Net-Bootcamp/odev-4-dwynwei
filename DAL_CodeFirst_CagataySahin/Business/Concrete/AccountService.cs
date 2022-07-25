using Business.Abstract;
using Business.Configuration.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountService : IAccountService
    {
        private readonly IAccountService _accountService;

        public AccountService(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public CommandResponse Delete(Account account)
        {
            _accountService.Delete(account);
            return new CommandResponse
            {
                Status = true,
                Message = $"Account Information Has Been Deleted | ID: {account.Id}, Name: {account.Name}, Last Name: {account.LastName}"
            };
        }

        public IEnumerable<Account> getAll()
        {
            return _accountService.getAll();
        }

        public CommandResponse Insert(Account account)
        {
            _accountService.Insert(account);
            return new CommandResponse
            {
                Status = true,
                Message = $"Account Information Has Been Added | ID: {account.Id}, Name: {account.Name}, Last Name: {account.LastName}"
            };
        }

        public CommandResponse Update(Account account)
        {
            _accountService.Update(account);
            return new CommandResponse
            {
                Status = true,
                Message = $"Account Information Has Been Updated | ID: {account.Id}, Name: {account.Name}, Last Name: {account.LastName}"
            };
        }
    }
}
