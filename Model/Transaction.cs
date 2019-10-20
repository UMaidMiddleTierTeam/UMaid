using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Transaction
    {
        public int ListingID { get; set; }
        public int BidID { get; set; }
        public List<int> MaidRating { get; set; }
        public List<int> CustomerRating { get; set; }

        public Transaction()
        {
            MaidRating = new List<int>();
            CustomerRating = new List<int>();
        }

        public int getAverage(List<int> rate)
        {
            if (rate.Count == 0)
            { return 0; }
            else
            {
                int average = 0;
                foreach (int r in rate)
                { average += r; }

                return average / rate.Count;
            }
        }
    }
}
