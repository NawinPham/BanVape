﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace DataAccessLayer
{
    public partial interface IOrdersRepository
    {
        List<OrdersModel> GetList();
        OrdersModel GetDataById(int id);
        bool Create(OrdersModel orders);
        bool Update(OrdersModel orders);
        bool Delete(string id);

    }
}
