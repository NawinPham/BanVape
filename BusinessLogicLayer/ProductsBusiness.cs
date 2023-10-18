using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class ProductsBusiness : IProductsBusiness
    {
        private IProductsRepository _res;
        public ProductsBusiness(IProductsRepository res)
        {
            _res = res;
        }
        public List<ProductsModel> getList()
        {
            return _res.getList();
        }
        public ProductsModel getDataById(string id)
        {
            return _res.getDataById(id);
        }
        public bool Create(ProductsModel model)
        {
            return _res.Create(model);
        }
        public bool Update(ProductsModel model)
        {
            return _res.Update(model);
        }
        public bool Delete(string id)
        {
            return _res.Delete(id);
        }
    }
}
