using System;
using System.Collections.Generic;

namespace AddressDetails.Db.Ef.Models
{
    public partial class Location
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
