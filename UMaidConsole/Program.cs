using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace UMaidConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> photographs = new List<string>();
            photographs.Add("firstPic");
            photographs.Add("secondPic");

            PropertyInfo house = new PropertyInfo(1200, 4, 2, photographs);

            Console.WriteLine("This house has " + house.NumberBedrooms + " bedrooms, " + house.NumberBathrooms +
                " bathrooms, and is " + house.Size + " sq. feet.");

            Console.WriteLine("The average cost of a light clean is " + house.PriceLight + ".");
            Console.WriteLine("The average cost of a normal clean is " + house.PriceNormal + ".");
            Console.WriteLine("The average cost of a heavy clean is " + house.PriceHeavy + ".");

            house.setLightAvg(50.00);
            house.setNormalAvg(300.00);
            house.setHeavyAvg(600.00);

            Console.WriteLine("The average cost of a light clean is " + house.PriceLight + ".");
            Console.WriteLine("The average cost of a normal clean is " + house.PriceNormal + ".");
            Console.WriteLine("The average cost of a heavy clean is " + house.PriceHeavy + ".");

            house.setLightAvg(100.00);
            house.setLightAvg(80.00);

            house.setNormalAvg(200.00);
            house.setNormalAvg(300.00);
            house.setNormalAvg(200.00);
            house.setNormalAvg(175.00);

            house.setHeavyAvg(799.00);
            house.setHeavyAvg(650.00);
            
            Console.WriteLine("The average cost of a light clean is " + house.PriceLight  + ".");
            Console.WriteLine("The average cost of a normal clean is " + house.PriceNormal + ".");
            Console.WriteLine("The average cost of a heavy clean is " + house.PriceHeavy + ".");
        }
    }
}
