using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Profile
    {
        public string ProfilePicture { get; set; }
        public string Rating { get; set; }
        public string AccountNumber { get; set; }
    }
}
