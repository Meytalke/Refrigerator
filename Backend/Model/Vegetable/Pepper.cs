using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Pepper : Vegetable
    {
        private bool isRed;
        private bool isSpicy;
        public bool IsRed { get => isRed; set => isRed = value; }
        public bool IsSpicy { get => isSpicy; set => isSpicy = value; }
        public Pepper(string name, double price, DateTime purchaseDay, int shelfLife, bool isOrganic, string color, string size, double weight, string[] vitamins, bool isRed, bool isSpicy)
           : base(name, price, purchaseDay, shelfLife, isOrganic, color, size, weight, vitamins)
        {
            IsRed = isRed;
            IsSpicy = isSpicy;
            //Id=Id_Generator_Pepper++;
        }
        public override string print()
        {
            return $"{base.print()}\n\tis Red: {(isRed ? "Yes" : "No")}\n\tIs Spicy: {(isSpicy ? "Yes" : "No")}";
        }
    }
}