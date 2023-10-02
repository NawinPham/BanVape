using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Orders
    {
        public int id { get; set; }
        public string username { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public List<OrderDetails> List_json_OderDetails { get; set; }

    }
    public class OrderDetails
    {
        public int id { get; set; }
        public int oder_id { get; set; }
        public int product_id { get; set; }
        public int quantily { get; set; }
    }
}
