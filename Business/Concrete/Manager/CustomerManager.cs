using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Manager
{
    public class CustomerManager
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer Customer)
        {
            _customerDal.Add(Customer);
        }

        public void Update(Customer Customer)
        {
            _customerDal.Update(Customer);
        }

        public void Delete(Customer Customer)
        {
            _customerDal.Delete(Customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetById(int id)
        {
            return _customerDal.Get(c => c.Id == id);
        }
    }
}
