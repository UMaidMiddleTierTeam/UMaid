using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }

        public string FullName
        {
            get
            { return $"{LName}, {FName}"; }
        }
    }
}