using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Beef : Meat
    {
        private bool isGrassFed;
        private bool isDryAged;

        public bool IsGrassFed { get => isGrassFed; set => isGrassFed = value; }
        public bool IsDryAged { get => isDryAged; set => isDryAged = value; }

        public Beef(string name, double price, DateTime purchaseDay, int shelfLife, double weight, double fatPercentage, bool isKosher, bool isGrassFed, bool isDryAged)
            : base(name, price, purchaseDay, shelfLife, weight, fatPercentage, isKosher)
        {
            IsGrassFed = isGrassFed;
            IsDryAged = isDryAged;
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs GrassFed: {(isGrassFed ? "Yes" : "No")}\n\tIs Dry Aged : {(isDryAged ? "Yes" : "No")}";
        }
        //public override void Cook()
        //{
        //    Console.WriteLine("Cooking beef...");
        //}
    }
}