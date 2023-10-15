using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class CottageCheese : Cheese
    {
        private bool isCreamy;
        private bool hasCurds;
        public bool IsCreamy { get => isCreamy; set => isCreamy = value; }
        public bool HasCurds { get => hasCurds; set => hasCurds = value; }
        public CottageCheese(string Name, double Price, DateTime purchaseDay, int ShelfLife, double caloriesPercentage, double lactosePercentage, string brand, string origin, double fatPercentage, bool isCreamy, bool hasCurds)
            : base(Name, Price, purchaseDay, ShelfLife, caloriesPercentage, lactosePercentage, brand, origin, fatPercentage)
        {
            IsCreamy = isCreamy;
            HasCurds = hasCurds;
        }
        public override string print()
        {
            return $"ID:{base.print()}\n\tIs Creamy: {(isCreamy ? "Yes" : "No")}\n\thas Curds: {(hasCurds ? "Yes" : "No")}";
        }
    }
}