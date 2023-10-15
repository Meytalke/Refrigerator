using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Grapes : Fruit
    {
        private bool isGreen;
        private bool hasSeeds;

        public bool IsGreen { get => isGreen; set => isGreen = value; }
        public bool HasSeeds { get => hasSeeds; set => hasSeeds = value; }
        public Grapes(string name, double price, DateTime purchaseDay, int shelfLife, double weight, string size, string color, string[] vitamins, string taste, bool isGreen, bool hasSeeds)
           : base(name, price, purchaseDay, shelfLife, weight, size, color,  vitamins,  taste)
        {
            IsGreen = isGreen;
            HasSeeds = hasSeeds;
        }
        public override string print()
        {
            return $"{base.print()}\n\tIs Green: {(isGreen ? "Yes" : "No")}\n\tHas Seeds: {(hasSeeds ? "Yes" : "No")}";
        }

        //public override void Peel()
        //{
        //    Console.WriteLine("Peeling an Grapes...");
        //}
    }
}