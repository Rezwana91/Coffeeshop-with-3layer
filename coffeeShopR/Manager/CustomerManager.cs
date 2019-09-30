using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coffeeShopR.Repository;
using System.Data;


namespace coffeeShopR.Manager
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Add(string name, string addrs, string cont)
        {
            return _customerRepository.Add(name, addrs, cont);
        }

        public bool IsNameExist(string name)
        {
            return _customerRepository.IsNameExist(name);
        }

        public bool Delete(int id)
        {
            return _customerRepository.Delete(id);
        }

        public bool Update(string name, string addrs, string cont, int id)

        {
            return _customerRepository.Update(name, addrs, cont, id);
        }

        public DataTable Display()
        {
            return _customerRepository.Display();
        }

        public DataTable Search(string name)
        {
            return _customerRepository.Search(name);
        }
    }
}
