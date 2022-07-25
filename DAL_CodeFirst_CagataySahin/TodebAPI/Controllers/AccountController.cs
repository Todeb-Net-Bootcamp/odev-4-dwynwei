using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace TodebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var datas = _accountService.getAll();
            return Ok(datas);
        }
        
        [HttpPost]
        public IActionResult Post(Account account)
        {
            var response=_accountService.Insert(account);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Update(Account account)
        {
            var response = _accountService.Update(account);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(Account account)
        {
            var response = _accountService.Delete(account);
            return Ok(response);
        }

    }
}
