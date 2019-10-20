using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bid
    {
        public int BidID { get; set; }
        public int ListingID { get; set; }
        public int UserID { get; set; }
        public float BidPrice { get; set; }
        public string TimeOfBid { get; set; }
        public string BidExpires { get; set; }
        public bool IsAccepted { get; set; }

        public Bid()
        { SetBid(0, 0, 0, 0, "", "", false); }

        public void SetBid(int bidId, int listId, int userId, float price, string startT, string endT, bool accepted)
        {
            BidID = bidId;
            ListingID = listId;
            UserID = userId;
            BidPrice = price;
            TimeOfBid = startT;
            BidExpires = endT;
            IsAccepted = accepted;
        }
    }
}
