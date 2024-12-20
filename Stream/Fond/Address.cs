using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream.Fond
{
    public class Address
    {
        public string? Id { get; set; }
        public string? Country { get; set; }
        public string? CityOrTown { get; set; }
        public string? Street { get; set; }
        public string? Apartment { get; set; }
        public string? PostalCode { get; set; }
        public Address()
        {
            
        }

        public Address(string? id, string? country, string? cityOrTown, string? street, string? apartment, string? postalCode)
        {
            Id = id;
            Country = country;
            CityOrTown = cityOrTown;
            Street = street;
            Apartment = apartment;
            PostalCode = postalCode;
        }
    }
}
