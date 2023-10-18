using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.BanHang.Controllers
{
    [Route("Api/[Controller]")]
    [Controller]
    public class CategorysController : ControllerBase
    {
        private ICategorysBusiness _categorysBusiness;
        public CategorysController(ICategorysBusiness categorysBusiness)
        {
            _categorysBusiness = categorysBusiness;
        }
        [AllowAnonymous]
        [Route("getList")]
        [HttpGet]
        public List<CategorysModel> getList()
        {
            return _categorysBusiness.getList();
        }
        [AllowAnonymous]
        [Route("Get-By-Id/{id}")]
        [HttpGet]
        public CategorysModel getDataById(int id)
        {
            return _categorysBusiness.getDataById(id);
        }
        [Route("Categorys-Create")]
        [HttpPost]
        public IActionResult Create([FromBody] CategorysModel model)
        {
            var result =  _categorysBusiness.Create(model);
            if (result)
            {
                return Ok(new
                {
                    status = true,
                    message = "thêm thành công",
                    data = model
                });
            }
            else
            {
                return BadRequest(new
                {
                    status = false,
                    message = "thêm thất bại",
                    data = model
                });
            }
            
        }
        [Route("Caregorys-Update")]
        [HttpPost]
        public IActionResult Update([FromBody]CategorysModel model)
        {
            var result = _categorysBusiness.Update(model);
            if (result)
            {
                return Ok(new
                {
                    status = true,
                    message = "Cập nhật thành công",
                });
            }
            else
            {
                return BadRequest(new
                {
                    status = false,
                    message = "Cập nhật thất bại",
                });
            }

        }
        [Route("Caregorys-Delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var result = _categorysBusiness.Delete(id);
            return Ok(new
            {
                status = result
            });
        }
    }
}
