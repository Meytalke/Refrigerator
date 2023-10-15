using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class FruitPunch : SweetenedBeverage
    {
        private string fruitCombination;
        private bool isPulpFree;

        public string FruitCombination { get => fruitCombination; set => fruitCombination = value; }
        public bool IsPulpFree { get => isPulpFree; set => isPulpFree = value; }
        public FruitPunch(string name, double price, DateTime purchaseDay, int shelfLife, double liters, string brand, string flavor, bool isCarbonated, double sugarContent, bool isDiet, string fruitCombination, bool isPulpFree)
            : base(name, price, purchaseDay, shelfLife, liters, brand, flavor, isCarbonated, sugarContent, isDiet)
        {
            FruitCombination = fruitCombination;
            IsPulpFree = isPulpFree;
        }

        public override string print()
        {
            return $"{base.print()}\n\tFruit Combination: {fruitCombination}%\n\tIs PulpFree: {(IsPulpFree ? "Yes" : "No")}";
        }
    }
}