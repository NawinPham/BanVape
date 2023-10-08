using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface IOrderDetailsBusiness
    {
        List<OrderDetailsModel> GetList();
        OrderDetailsModel GetDataById(int id);
        bool Create(OrderDetailsModel orderDetails);
        bool Update(OrderDetailsModel orderDetails);
        bool Delete(string id);
    }
}
