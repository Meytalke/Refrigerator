using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public abstract class Beverage : Product
    {
        private string brand;
        private string flavor;
        private bool isCarbonated;
        public string Brand { get => brand; set => brand = value; }
        public string Flavor { get => flavor; set => flavor = value; }
        public bool IsCarbonated { get => isCarbonated; set => isCarbonated = value; } // that which contains gases

        public Beverage(string name, double price, DateTime purchaseDay, int shelfLife, double liters, string brand, string flavor, bool isCarbonated)
           : base(name, price, purchaseDay, shelfLife)
        {
            Brand = brand;
            Flavor = flavor;
            IsCarbonated = isCarbonated;
            Liters = liters;
        }

        public override string print()
        {
            return $"{base.print()}\n\tBrand: {brand}\n\tFlavor: {flavor}\n\tIs Carbonated: {(isCarbonated ? "Yes" : "No")}";
        }
    }
}