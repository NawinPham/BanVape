using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.BanHang.Controllers
{
    [Route("Api/[Controller]")]
    [Controller]
    public class OrdersController : ControllerBase
    {
        private IOrdersBusiness _IOrdersBusiness;
        public OrdersController(IOrdersBusiness ordersBusiness) 
        {
            _IOrdersBusiness = ordersBusiness;
        }
        [AllowAnonymous]
        [Route("Order-getList")]
        [HttpGet]
        public List<OrdersModel> GetList() 
        {
            return _IOrdersBusiness.GetList();
        }
        [AllowAnonymous]
        [Route("Order-getId/{id}")]
        [HttpGet]
        public IActionResult GetDataById(int id)
        {
            var result = _IOrdersBusiness.GetDataById(id);
            return Ok(new { result });
        }
        [Route("Order-Create")]
        [HttpPost]
        public IActionResult Create([FromBody]OrdersModel orders) 
        {
            var result = _IOrdersBusiness.Create(orders);
            if (result)
            {
                return Ok(new
                {
                    status = true,
                    message = "Thêm đơn hàng thành công!",
                    data = orders
                });
            }
            else
            {
                return BadRequest(new
                {
                    status = false,
                    message = "Thêm đơn hàng thất bại!"
                });
            }
        }
        [Route("Order-Update")]
        [HttpPost]
        public IActionResult Update([FromBody]OrdersModel orders)
        {
            var result = _IOrdersBusiness.Update(orders);
            if (result)
            {
                return Ok(new
                {
                    status = true,
                    message = "Cập nhật đơn hàng thành công!",
                    data = orders
                });
            }
            else
            {
                return BadRequest(new
                {
                    status = false,
                    message = "Cập nhật đơn hàng thất bại!"
                });
            }
        }
        [Route("Order-Delete")]
        [HttpPost]
        public IActionResult Delete(string id)
        {
            var result = _IOrdersBusiness.Delete(id);
            return Ok(new {result});
        }
    }
}
