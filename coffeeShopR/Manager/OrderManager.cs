using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data;
using coffeeShopR.Repository;

namespace coffeeShopR.Manager
{
    public class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();

        public bool Add(int quantity, double totalprice, string name, string iname)
        {
            return _orderRepository.Add(quantity, totalprice, name, iname);
        }

        public bool IsNameExist(string name)
        {
            return _orderRepository.IsNameExist(name);
        }

        public bool Delete(int id)
        {
            return _orderRepository.Delete(id);

        }

        public bool Update(int quantity, double totalprice, string name, string iname, int id)

        {
            return _orderRepository.Update(quantity, totalprice, name, iname, id);

        }

        public DataTable Display()
        {
            return _orderRepository.Display();
        }

        public DataTable Search(string name, string iname)
        {
            return _orderRepository.Search(name, iname);

        }

        //public bool IsInameExist(string name)
        //{
        //    return _orderRepository.IsInameExist(name);
        //}
    }

}
