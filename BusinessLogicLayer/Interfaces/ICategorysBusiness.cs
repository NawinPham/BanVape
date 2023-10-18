using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface ICategorysBusiness
    {
        List<CategorysModel> getList();
        CategorysModel getDataById(int id);
        bool Create(CategorysModel model);
        bool Update(CategorysModel model);
        CategorysModel Delete(int id);

    }
}
