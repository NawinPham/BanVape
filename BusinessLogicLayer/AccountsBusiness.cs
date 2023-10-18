using BusinessLogicLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class AccountsBusiness : IAccountsBusiness
    {
        IAccountsRepository _res;
        public AccountsBusiness(IAccountsRepository res)
        {
            _res = res;
        }

        public List<AccountsModel> GetList()
        {
            return _res.GetList();
        }
        public AccountsModel GetDataById(int id)
        {
            return _res.GetDataById(id);
        }
        public bool Update(AccountsModel model)
        {
            return _res.Update(model);
        }
        public AccountsModel Delete( int id)
        {
            return _res.Delete(id);
        }
    }
}
