using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Cucumber : Vegetable
    {

        private bool isGreen;
        private bool isCrunchy;

        public bool IsGreen { get => isGreen; set => isGreen = value; }
        public bool IsCrunchy { get => isCrunchy; set => isCrunchy = value; }
        public Cucumber(string name, double price, DateTime purchaseDay, int shelfLife, bool isOrganic, string color, string size, double weight, string[] vitamins, bool isGreen, bool isCrunchy)
           : base(name, price, purchaseDay, shelfLife, isOrganic, color, size, weight, vitamins)
        {
            IsGreen = isGreen;
            IsCrunchy = isCrunchy;
            //Id=Id_Generator_Cucumber++;
        }
        public override string print()
        {
            return $"{base.print()}\n\tIs Green: {(isGreen ? "Yes" : "No")}\n\tIs Crunchy: {(isCrunchy ? "Yes" : "No")}";
        }
    }
}