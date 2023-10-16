using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataAccessLayer.Interfaces
{
    public partial interface IAccountsRepository
    {
        List<AccountsModel> GetList();
        AccountsModel GetDataById(int id);
        bool Update(AccountsModel model);
        AccountsModel Delete( int id);
    }
}
