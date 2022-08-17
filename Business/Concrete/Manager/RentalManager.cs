using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete.Manager
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;

        public RentalManager(IRentalDal RentalDal)
        {
            _rentalDal = RentalDal;
        }

        public void Add(Rental Rental)
        {
            _rentalDal.Add(Rental);
        }

        public void Update(Rental Rental)
        {
            _rentalDal.Update(Rental);
        }

        public void Delete(Rental Rental)
        {
            _rentalDal.Delete(Rental);
        }

        public List<Rental> GetAll()
        {
            return _rentalDal.GetAll();
        }

        public List<Rental> GetById(int id)
        {
            return _rentalDal.Get(c => c.Id == id);
        }
    }
}
