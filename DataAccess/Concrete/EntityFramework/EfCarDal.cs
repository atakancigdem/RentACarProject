using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentACarDatabaseContext context = new RentACarDatabaseContext())
            {
                var result = from ca in context.Cars
                    join b in context.Brands on ca.BrandId equals b.BrandId
                    join c in context.Colors on ca.ColorId equals c.ColorId
                    select new CarDetailDto
                    {
                        Id = ca.Id,
                        CarName = ca.CarName,
                        BrandName = b.BrandName,
                        ColorName = c.ColorName,
                        DailyPrice = ca.DailyPrice,
                        ModelYear = ca.ModelYear
                    };
                return result.ToList();
            }
        }
    }
}
