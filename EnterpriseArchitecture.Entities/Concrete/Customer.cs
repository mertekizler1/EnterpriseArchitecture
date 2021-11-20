﻿using EnterpriseArchitecture.Core.Entities;

namespace EnterpriseArchitecture.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }

        public string CompanyName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }
    }
}
