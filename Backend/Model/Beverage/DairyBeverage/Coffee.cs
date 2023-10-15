using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Coffee : DairyBeverage
    {
        public Coffee(string name, double price, DateTime purchaseDay, int shelfLife, double liters, string brand, string flavor, bool isCarbonated, string milkType, bool isLactoseFree, bool isVegan, bool isAlmondMilkBeverage, double fatPercentage)
                : base(name, price, purchaseDay, shelfLife, liters, brand, flavor, isCarbonated, milkType, isLactoseFree, isVegan, isAlmondMilkBeverage, fatPercentage)
        {

        }


        public override string print()
        {
            return $"{base.print()}";
        }
    }
}
