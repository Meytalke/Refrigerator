using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Yogurt : DairyProduct
    {
        private bool isGreekYogurt;
        private string flavor;
        public bool IsGreekYogurt { get => isGreekYogurt; set => isGreekYogurt = value; }
        public string Flavor { get => flavor; set => flavor = value; }

        public Yogurt(string Name, double Price, DateTime purchaseDay, int ShelfLife, double caloriesPercentage, double lactosePercentage, string brand, bool isGreekYogurt, string flavor)
            : base(Name, Price, purchaseDay, ShelfLife, caloriesPercentage, lactosePercentage, brand)
        {
            IsGreekYogurt = isGreekYogurt;
            Flavor = flavor;
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs GreekYogurt: {(isGreekYogurt ? "Yes" : "No")}\n\tFlavor: {flavor}%";
        }
    }
}