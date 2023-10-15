using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class MozzarellaCheese : Cheese
    {
        private bool isFresh;
        private bool isStretchy;
        public bool IsFresh { get => isFresh; set => isFresh = value; }
        public bool IsStretchy { get => isStretchy; set => isStretchy = value; }

        public MozzarellaCheese(string Name, double Price, DateTime purchaseDay, int ShelfLife, double caloriesPercentage, double lactosePercentage, string brand, string origin, double fatPercentage, bool isFresh, bool isStretchy)
            : base(Name, Price, purchaseDay, ShelfLife, caloriesPercentage, lactosePercentage, brand, origin, fatPercentage)
        {
            IsFresh = isFresh;
            IsStretchy = isStretchy;
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs Fresh: {(isFresh ? "Yes" : "No")}\n\tIs Stretchy: {(isStretchy ? "Yes" : "No")}";
        }
    }
}