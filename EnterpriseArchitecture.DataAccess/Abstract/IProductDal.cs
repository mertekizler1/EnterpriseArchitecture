﻿using EnterpriseArchitecture.Core.DataAccess;
using EnterpriseArchitecture.Entities.Concrete;

namespace EnterpriseArchitecture.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}