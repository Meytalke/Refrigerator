using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Apple : Fruit
    {
        private string variety;
        private bool hasSeeds;
        public string Variety { get => variety; set => variety = value; }
        public bool HasSeeds { get => hasSeeds; set => hasSeeds = value; }

        public Apple(string name, double price, DateTime purchaseDay, int shelfLife, double weight, string size, string color, string[] vitamins, string taste, string variety, bool hasSeeds)
           : base(name, price, purchaseDay, shelfLife, weight, size, color, vitamins,  taste)
        {
            Variety = variety;
            HasSeeds = hasSeeds;
        }

        public override string print()
        {
            return $"{base.print()}\n\tvariety: {variety}\n\tHas Seeds : {(hasSeeds ? "Yes" : "No")}";
        }

        //public override void Peel()
        //{
        //    Console.WriteLine("Peeling an Apple...");
        //}
    }
}