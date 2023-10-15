using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public abstract class SweetenedBeverage : Beverage
    {
        private double sugarContent;
        private bool isDiet;

        public double SugarContent { get => sugarContent; set => sugarContent = value; }
        public bool IsDiet { get => isDiet; set => isDiet = value; }

        public SweetenedBeverage(string name, double price, DateTime purchaseDay, int shelfLife, double liters, string brand, string flavor, bool isCarbonated, double sugarContent, bool isDiet)
          : base(name, price, purchaseDay, shelfLife, liters, brand, flavor, isCarbonated)
        {
            SugarContent = sugarContent;
            IsDiet = isDiet;
        }

        public override string print()
        {
            return $"{base.print()}\n\tSugar Content: {sugarContent}%\n\tIs Diet: {(isDiet ? "Yes" : "No")}";
        }
    }
}