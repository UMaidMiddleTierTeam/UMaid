using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Listing
    {
        public string PropertyID { get; set; }
        public string CleaningTime { get; set; }
        public string CleaningLevel { get; set; }

        //Array for multiple pictures
        public List<string> RecentPictures { get; set; }
        public string ListingID { get; set; }
        public string CustomerID { get; set; }
        public string ExpireTime { get; set; }
        public string AdditionalInfo { get; set; }

        public String ListingInfo
        {
            get { return $"{PropertyID},{ListingID}"; }
        }

    }
}
