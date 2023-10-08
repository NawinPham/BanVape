using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Api.BanHang.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserBusiness _userBusiness;
        public UserController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] AuthenticateModel model)
        {
            var user = _userBusiness.Login(model.Username, model.Password);
            if (user == null)
                return BadRequest(new { message = "Tài khoản hoặc mật khẩu không đúng!" });
            return Ok(new { Username = user.username, Email = user.email, Token = user.token , status = true });
        }
        [AllowAnonymous]
        [Route("Signup")]
        [HttpPost]
        public IActionResult Signup([FromBody] AccountsModel model)
        {
            var result = _userBusiness.Signup(model);
            return Ok(new
            {
                status = result
            });
        }
        [Route("checkaccount")]
        [HttpPost]
        public IActionResult CheckAccount()
        {
            return Ok(new
            {
                status = true
            });
        }

    }
}
