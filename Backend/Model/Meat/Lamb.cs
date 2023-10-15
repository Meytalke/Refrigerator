using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Lamb : Meat
    {
        private bool isGrassFed;
        private bool isHalalCertified;

        public bool IsGrassFed { get => isGrassFed; set => isGrassFed = value; }
        public bool IsHalalCertified { get => isHalalCertified; set => isHalalCertified = value; }

        public Lamb(string name, double price, DateTime purchaseDay, int shelfLife, double weight, double fatPercentage, bool isKosher, bool isGrassFed, bool isHalalCertified)
            : base(name, price, purchaseDay, shelfLife, weight, fatPercentage, isKosher)
        {
            IsGrassFed = isGrassFed;
            IsHalalCertified = isHalalCertified;
           
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs GrassFed: {(isGrassFed ? "Yes" : "No")}\n\tIs Halal Certified: {(isHalalCertified ? "Yes" : "No")}";
        }
        //public override void Cook()
        //{
        //    Console.WriteLine("Cooking Lamb...");
        //}
    }
}