using BusinessLogicLayer;
using DataAccessLayer;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CategorysBusiness : ICategorysBusiness
    {
        private ICategorysRepository _res;
        public CategorysBusiness(ICategorysRepository res)
        {
            _res = res;
        }
        public List<CategorysModel> getList()
        {
            return _res.getList();
        }
        public CategorysModel getDataById(int id)
        {
            return _res.getDataById(id);
        }
        public bool Create(CategorysModel model)
        {
            return _res.Create(model);
        }
        public bool Update(CategorysModel model)
        {
            return _res.Update(model);
        }
        public CategorysModel Delete(int id)
        {
            return _res.Delete(id);
        }

    }
}
