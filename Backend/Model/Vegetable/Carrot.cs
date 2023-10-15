using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Carrot : Vegetable
    {
        private bool isOrange;
        private bool isSweet;
        public bool IsOrange { get => isOrange; set => isOrange = value; }
        public bool IsSweet { get => isSweet; set => isSweet = value; }
        public Carrot(string name, double price, DateTime purchaseDay, int shelfLife, bool isOrganic, string color, string size, double weight, string[] vitamins, bool isOrange, bool isSweet)
           : base(name, price, purchaseDay, shelfLife, isOrganic, color, size, weight, vitamins)
        {
            IsSweet = IsSweet;
            IsOrange = IsOrange;
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs Orange: {(isOrange ? "Yes" : "No")}\n\tIs Sweet: {(isSweet ? "Yes" : "No")}";
        }
    }
}