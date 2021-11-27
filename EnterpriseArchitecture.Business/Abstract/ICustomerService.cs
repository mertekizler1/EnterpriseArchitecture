using EnterpriseArchitecture.Core.Utilities.Results.Common;
using EnterpriseArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseArchitecture.Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();

        IDataResult<Customer> GetById(int customerId);

        IResult Add(Customer customer);

        IResult Delete(Customer customer);
    }
}
