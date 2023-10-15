using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class LabnehCheese : Cheese
    {
        private bool isStrained;
        private string herb;
        public bool IsStrained { get => isStrained; set => isStrained = value; }
        public string Herb { get => herb; set => herb = value; }

        public LabnehCheese(string Name, double Price, DateTime purchaseDay, int ShelfLife, double caloriesPercentage, double lactosePercentage, string brand, string origin, double fatPercentage, bool isStrained, string herb)
            : base(Name, Price, purchaseDay, ShelfLife, caloriesPercentage, lactosePercentage, brand, origin, fatPercentage)
        {
            IsStrained = isStrained;
            Herb = herb;
        }
        public override string print()
        {
            return $"{base.print()}\n\tIs Strained: {(isStrained ? "Yes" : "No")}\n\therb: {herb}";
        }
    }
}