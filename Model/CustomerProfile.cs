using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CustomerProfile : Profile
    {
        public string CustomerID { get; set; }
        public List<string> PropertyIDs { get; set; }
    }
}
