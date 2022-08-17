using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        void Add(Rental rental);
        void Update(Rental rental);
        void Delete(Rental rental);
        List<Rental> GetAll();
        List<Rental> GetById(int id);
    }
}
