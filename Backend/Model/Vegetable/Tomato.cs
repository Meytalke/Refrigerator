using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Tomato : Vegetable
    {
        private bool isRed;
        private bool isCherry;
        public bool IsRed { get => isRed; set => isRed = value; }
        public bool IsCherry { get => isCherry; set => isCherry = value; }

        public Tomato(string name, double price, DateTime purchaseDay, int shelfLife, bool isOrganic, string color, string size, double weight, string[] vitamins, bool isRed, bool isCherry)
           : base(name, price, purchaseDay, shelfLife, isOrganic, color, size, weight, vitamins)
        {
            IsRed = isRed;
            IsCherry = isCherry;
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs Red: {(isRed ? "Yes" : "No")}\n\tIs Cherry: {(isCherry ? "Yes" : "No")}";
        }
    }
}