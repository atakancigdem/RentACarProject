using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (RentACarDatabaseContext context = new RentACarDatabaseContext())
            {
                var result = from r in context.Rentals
                    join ca in context.Cars on r.CarId equals ca.Id
                    join c in context.Customers on r.CustomerId equals c.Id
                    join u in context.Users on c.UserId equals u.Id
                    select new RentalDetailDto
                    {
                        Id = r.Id,
                        UserName = u.FirstName + " " + u.LastName,
                        Email = u.Email,
                        CompanyName = c.CompanyName,
                        CarName = ca.CarName,
                        RentDate = r.RentDate,
                        ReturnDate = r.ReturnDate
                    };
                return result.ToList();

            }
        }
    }
}
