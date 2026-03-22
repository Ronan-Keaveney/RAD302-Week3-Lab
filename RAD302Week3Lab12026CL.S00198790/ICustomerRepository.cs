using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace RAD302Week3Lab12026CL.S00198790
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
        void Add(Customer customer);
        void Remove(Customer customer);
    }
}
