using BusinessLogicLayer;
using DataModel;
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
        [Route("Get-By-Id/{id}")]
        [HttpGet]
        public CategorysModel getDataById(int id)
        {
            return _categorysBusiness.getDataById(id);
        }
        [Route("Categorys-Create")]
        [HttpPost]
        public bool Create(CategorysModel model)
        {
            return _categorysBusiness.Create(model);
        }

    }
}
