using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class EnergyDrink : SweetenedBeverage
    {
        private double caffeineContent;
        public double CaffeineContent { get => caffeineContent; set => caffeineContent = value; }
        public EnergyDrink(string name, double price, DateTime purchaseDay, int shelfLife, double liters, string brand, string flavor, bool isCarbonated, double sugarContent, bool isDiet, double caffeineContent)
            : base(name, price, purchaseDay, shelfLife, liters, brand, flavor, isCarbonated, sugarContent, isDiet)
        {
            CaffeineContent = caffeineContent;
        }

        public override string print()
        {
            return $"{base.print()}\n\tCaffeine Content: {caffeineContent}%";
        }
    }
}