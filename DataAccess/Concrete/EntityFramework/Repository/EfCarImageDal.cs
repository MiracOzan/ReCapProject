using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage,RentACarContext>, ICarImageDal
    {
    }
}
