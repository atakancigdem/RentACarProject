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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarDatabaseContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetail()
        {
            using (RentACarDatabaseContext context = new RentACarDatabaseContext())
            {
                var result = from c in context.Customers
                    join u in context.Users on c.UserId equals u.Id
                    select new CustomerDetailDto
                    {
                        UserName = u.FirstName + " " + u.LastName,
                        Email = u.Email,
                        CompanyName = c.CompanyName
                    };
                return result.ToList();
            }
        }
    }
}
