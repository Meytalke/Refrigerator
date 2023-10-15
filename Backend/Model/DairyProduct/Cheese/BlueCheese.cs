using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class BlueCheese : Cheese
    {
        private int agingTime;
        private bool hasMold;

        public int AgingTime { get => agingTime; set => agingTime = value; }
        public bool HasMold { get => hasMold; set => hasMold = value; }

        public BlueCheese(string Name, double Price, DateTime purchaseDay, int ShelfLife, double caloriesPercentage, double lactosePercentage, string brand, string origin, double fatPercentage, int agingTime, bool hasMold)
            : base(Name, Price, purchaseDay, ShelfLife, caloriesPercentage, lactosePercentage, brand, origin, fatPercentage)
        {
            AgingTime = agingTime;
            HasMold = hasMold;
        }
        public override string print()
        {
            return $"{base.print()}\n\tHas Mold:{(hasMold ? "Yes" : "No")}\n\tAging Time: {agingTime}%";
        }
    }
}
