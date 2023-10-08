using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.BanHang.Controllers
{
    [Route("Api/[Controller]")]
    [Controller]
    public class OrderDetailsController : ControllerBase
    {
        private IOrderDetailsBusiness _orderdetailsBusiness;
        public OrderDetailsController(IOrderDetailsBusiness orderdetailsBusiness)
        {
            _orderdetailsBusiness = orderdetailsBusiness;
        }
        [AllowAnonymous]
        [Route("OrderDetails-GetList")]
        [HttpGet]
        public List<OrderDetailsModel> GetList()
        {
            return _orderdetailsBusiness.GetList();
        }
        [AllowAnonymous]
        [Route("OrderDetails-Get-By-Id/{id}")]
        [HttpGet]
        public IActionResult GetDataByID(int id)
        {
            var result = _orderdetailsBusiness.GetDataById(id);
            return Ok(new { result });
        }
        [Route("OrderDetails-Create")]
        [HttpPost]
        public IActionResult Create([FromBody] OrderDetailsModel orderDetails)
        {
            var result = _orderdetailsBusiness.Create(orderDetails);
            if (result)
            {
                return Ok(new 
                { 
                    status = true,
                    message = "Thêm đơn hàng thành công!",
                    data = orderDetails
                });
            }
            else
            {
                return BadRequest(new
                {
                    status = false,
                    message = "Thêm đơn hàng thất bại!",
                });
            }
        }
        [Route("OrderDetails-Update")]
        [HttpPost]
        public IActionResult Update([FromBody] OrderDetailsModel orderDetails)
        {
            var result = _orderdetailsBusiness.Update(orderDetails);
            if (result)
            {
                return Ok(new
                {
                    status = true,
                    message = "Cập nhật đơn hàng thành công!",
                    data = orderDetails
                });
            }
            else
            {
                return BadRequest(new
                {
                    status = false,
                    message = "Cập nhật đơn hàng thất bại!",
                });
            }
        }
        [Route("OrderDetails-Delete")]
        [HttpPost]
        public IActionResult Delete(string id) 
        {
            var result = _orderdetailsBusiness.Delete(id);
            return Ok(new { result });
        }
    }
}
