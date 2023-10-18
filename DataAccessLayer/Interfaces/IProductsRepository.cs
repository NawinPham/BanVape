using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataAccessLayer
{
    public partial interface IProductsRepository
    {
        List<ProductsModel> getList();
        ProductsModel getDataById(string id);
        bool Create(ProductsModel model);
        bool Update(ProductsModel model);
        bool Delete(string id);
    }
}
