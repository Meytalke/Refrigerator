using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Lettuce : Vegetable
    {
        private bool isGreen;
        private bool isCrispy;
        public bool IsGreen { get => isGreen; set => isGreen = value; }
        public bool IsCrispy { get => isCrispy; set => isCrispy = value; }
        public Lettuce(string name, double price, DateTime purchaseDay, int shelfLife, bool isOrganic, string color, string size, double weight, string[] vitamins, bool isGreen, bool isCrispy)
           : base(name, price, purchaseDay, shelfLife, isOrganic, color, size, weight, vitamins)
        {
            IsGreen = isGreen;
            IsCrispy = isCrispy;
        }
        public override string print()
        {
            return $"{base.print()}\n\tIs Green: {(isGreen ? "Yes" : "No")}\n\tIs Crispy: {(isCrispy ? "Yes" : "No")}";
        }
    }
}