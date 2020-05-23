using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataLibrary.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }

        public AddressModel(int Id, int EmployeeId, string Country, string Region, string City, string StreetAddress, string PostalCode)
        {
            this.Id = Id;
            this.EmployeeId = EmployeeId;
            this.Country = Country;
            this.Region = Region;
            this.City = City;
            this.StreetAddress = StreetAddress;
            this.PostalCode = PostalCode;
        }

        public AddressModel(string Country, string Region, string City, string StreetAddress, string PostalCode)
        {
            this.Country = Country;
            this.Region = Region;
            this.City = City;
            this.StreetAddress = StreetAddress;
            this.PostalCode = PostalCode;
        }
    }
}
