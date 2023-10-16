using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial interface IUserRepository
    {
        AccountsModel Login(string username, string password); 
        bool Signup(AccountsModel model);
    }

}
