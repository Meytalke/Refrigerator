using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Chicken : Meat
    {
        private bool isOrganic;
        private bool isSkinless;
        public bool IsOrganic { get => isOrganic; set => isOrganic = value; }
        public bool IsSkinless { get => isSkinless; set => isSkinless = value; }

        public Chicken(string name, double price, DateTime purchaseDay, int shelfLife, double weight, double fatPercentage, bool isKosher, bool isOrganic, bool isSkinless)
            : base(name, price, purchaseDay, shelfLife, weight, fatPercentage, isKosher)
        {
            IsOrganic = isOrganic;
            IsSkinless = isSkinless;
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs Organic: {(isOrganic ? "Yes" : "No")}\n\tIs Skinless: {(isSkinless ? "Yes" : "No")}";
        }
        //public override void Cook()
        //{
        //    Console.WriteLine("Cooking Chicken...");
        //}
    }
}