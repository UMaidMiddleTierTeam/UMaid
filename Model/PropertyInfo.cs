using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PropertyInfo
    {
        public double Size { get; set; }
        public int NumberBedrooms { get; set; }
        public int NumberBathrooms { get; set; }
        public string Description { get; set; }
        public List<string> PropertyPhotos { get; set; }
        public double PriceLight { get; set; }
        public double PriceNormal { get; set; }
        public double PriceHeavy { get; set; }

        public void setLightAvg(double price)
        {
            if (PriceLight != 0)
            { PriceLight = (PriceLight + price) / 2; }
            else
            { PriceLight = price; }
        }

        public void setNormalAvg(double price)
        {
            if (PriceNormal != 0)
            { PriceNormal = (PriceNormal + price) / 2; }
            else
            { PriceNormal = price; }
        }

        public void setHeavyAvg(double price)
        {
            if (PriceHeavy != 0)
            { PriceHeavy = (PriceHeavy + price) / 2; }
            else
            { PriceHeavy = price; }
        }

        public PropertyInfo(double sz, int bed, int bath, List<string> phList)
        {
            Size = sz;
            NumberBedrooms = bed;
            NumberBathrooms = bath;
            Description = "";
            PropertyPhotos = new List<string>();
            for (int i = 0; i < phList.Count; i++)
            {
                PropertyPhotos.Add(phList[i]);
            }
            PriceLight = 0;
            PriceNormal = 0;
            PriceHeavy = 0;
        }

        public PropertyInfo(double sz, int bed, int bath, string d, List<string> phList)
        {
            Size = sz;
            NumberBedrooms = bed;
            NumberBathrooms = bath;
            Description = d;
            PropertyPhotos = new List<string>();
            for (int i = 0; i < phList.Count; i++)
            {
                PropertyPhotos.Add(phList[i]);
            }
            PriceLight = 0;
            PriceNormal = 0;
            PriceHeavy = 0;
        }
    }
}
