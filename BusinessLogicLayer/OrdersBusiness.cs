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
    public class OrdersBusiness : IOrdersBusiness
    {
        private IOrdersRepository _res;
        public OrdersBusiness(IOrdersRepository res)
        {
            _res = res;
        }
        public List<OrdersModel> GetList()
        {
            return _res.GetList();
        }
        public OrdersModel GetDataById(int id)
        {
            return _res.GetDataById(id);
        }
        public bool Create(OrdersModel orders)
        {
            return _res.Create(orders);
        }
        public bool Update(OrdersModel orders)
        {
            return _res.Update(orders);
        }
        public bool Delete(string id)
        {
            return _res.Delete(id);
        }
    }
}
