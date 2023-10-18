using BusinessLogicLayer;
using BusinessLogicLayer.Interfaces;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.BanHang.Controllers
{
    [Route("Api/[Controller]")]
    [Controller]
    public class AccountsController : ControllerBase
    {
        private IAccountsBusiness _IAccountsBusiness;
        public AccountsController(IAccountsBusiness accountsBusiness)
        {
            _IAccountsBusiness = accountsBusiness;
        }
        [AllowAnonymous]
        [Route("getList")]
        [HttpGet]
        public List<AccountsModel> getList()
        {
            return _IAccountsBusiness.GetList();
        }
        [AllowAnonymous]
        [Route("Get-By-Id/{id}")]
        [HttpGet]
        public AccountsModel getDataById(int id)
        {
            return _IAccountsBusiness.GetDataById(id);
        }
        [Route("account-update")]
        [HttpPost]
        public IActionResult Update([FromBody] AccountsModel model)
        {
            var result = _IAccountsBusiness.Update(model);
            if (result)
            {
                return Ok(new
                {
                    status = true,
                    message = "Cập nhật thành công!"
                });
            }
            else
            {
                return BadRequest(new
                {
                    status = false,
                    message = "Cập nhật thất bại!"
                });
            }
        }
        [Route("account-delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _IAccountsBusiness.Delete(id);
            return Ok(new
            {
                status = result
            });
        }
    }
}
