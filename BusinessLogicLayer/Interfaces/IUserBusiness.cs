using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface IUserBusiness
    {
        AccountsModel Login(string username, string password);
        bool Signup(AccountsModel model);

    }
}
