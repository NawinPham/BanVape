using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public partial interface IAccountsBusiness
    {
        List<AccountsModel> GetList();
        AccountsModel GetDataById(int id);
        bool Update(AccountsModel model);
        AccountsModel Delete( int id);

    }
}
