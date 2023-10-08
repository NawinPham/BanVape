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
    public class OrderDetailsBusiness : IOrderDetailsBusiness
    {
        private IOrderDetailsRepository _res;
        public OrderDetailsBusiness(IOrderDetailsRepository res)
        {
            _res = res;
        }
        public List<OrderDetailsModel> GetList()
        {
            return _res.GetList();
        }
        public OrderDetailsModel GetDataById(int id)
        {
            return _res.GetDataById(id);
        }
        public bool Create(OrderDetailsModel orderDetails)
        {
            return _res.Create(orderDetails);
        }
        public bool Update(OrderDetailsModel orderDetails)
        {
            return _res.Update(orderDetails);
        }
        public bool Delete(string id)
        {
            return _res.Delete(id);
        }
    }
}
