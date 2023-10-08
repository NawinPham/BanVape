using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.BanHang.Controllers
{
    [Route("Api/[Controller]")]
    [Controller]
    public class ProductsController : ControllerBase
    {
        private IProductsBusiness _productsbusiness;
        public ProductsController(IProductsBusiness productsBusiness)
        {
            _productsbusiness = productsBusiness;
        }
        [AllowAnonymous]
        [Route("getList")]
        [HttpGet]
        public List<ProductsModel> getList()
        {
            return _productsbusiness.getList();
            
        }
        [AllowAnonymous]
        [Route("get-by-id/{id}")]
        [HttpGet]
        public IActionResult getDataById(string id) 
        {
            var result = _productsbusiness.getDataById(id);
            return Ok(new
            {
                status = result
            });
        
        }
        [Route("Create-products")]
        [HttpPost]
        public IActionResult Create([FromBody] ProductsModel model)
        {
            var result = _productsbusiness.Create(model);
            if (result)
            {
                return Ok(new
                {
                    status = true,
                    message = "Thêm sản phẩm thành công!",
                    data = model
                });
            }
            else
            {
                return BadRequest(new
                {
                    status = false,
                    message = "Thêm tài khoản thất bại",
                    data = model
                });
            };
            
        }
        [Route("Update-products")]
        [HttpPost]
        public IActionResult Update([FromBody] ProductsModel model)
        {
            var result = _productsbusiness.Update(model);
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
        [Route("Delete-Products")]
        [HttpPost]
        public IActionResult Delete(string id)
        {
            var result =  _productsbusiness.Delete(id);
            return Ok(new
            {
                status = result
            });
        }
    }
}