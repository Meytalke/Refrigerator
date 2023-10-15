using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Cola : SweetenedBeverage
    {
        private bool hasCaffeine;

        public bool HasCaffeine { get => hasCaffeine; set => hasCaffeine = value; }
        public Cola(string name, double price, DateTime purchaseDay, int shelfLife, double liters, string brand, string flavor, bool isCarbonated, double sugarContent, bool isDiet, bool hasCaffeine)
            : base(name, price, purchaseDay, shelfLife, liters, brand, flavor, isCarbonated, sugarContent, isDiet)
        {
            HasCaffeine = hasCaffeine;
        }

       

        public override string print()
        {
            return $"{base.print()}\n\tHas Caffeine: {(hasCaffeine ? "Yes" : "No")}%";
        }
    }
}
