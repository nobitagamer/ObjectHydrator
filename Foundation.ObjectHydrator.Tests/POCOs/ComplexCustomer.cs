﻿using System;
using System.Collections.Generic;

namespace Foundation.ObjectHydrator.Tests.POCOs
{
	public enum CustomerType
    {
        Lead,
        Prospect,
        Active,
        Inactive
    }

    public class ComplexCustomer
	{
		public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public int Locations { get; set; }
        public DateTime IncorporatedOn { get; set; }
        public double Revenue { get; set; }

        public Address WorkAddress { get; set; }
        public Address HomeAddress { get; set; }
        public IList<Address> Addresses { get; set; }

        

        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string[] PhoneNumbers { get; set; }

        public CustomerType Type { get; set; }

    }
}
