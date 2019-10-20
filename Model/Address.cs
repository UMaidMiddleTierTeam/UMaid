using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(string line1, string line2, string c, string s, string z)
        {
            AddressLine1 = line1;
            AddressLine2 = line2;
            City = c;
            State = s;
            ZipCode = z;
        }
    }

}
