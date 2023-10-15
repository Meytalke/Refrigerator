using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Peach : Fruit
    {
        private bool isRipe;
        private bool hasSeeds;
        public bool IsRipe { get => isRipe; set => isRipe = value; }
        public bool HasSeeds { get => hasSeeds; set => hasSeeds = value; }

        public Peach(string name, double price, DateTime purchaseDay, int shelfLife, double weight, string size, string color, string[] vitamins, string taste, bool isRipe, bool hasSeeds)
           : base(name, price, purchaseDay, shelfLife, weight, size, color, vitamins,  taste)
        {
            IsRipe = isRipe;
            HasSeeds = hasSeeds;
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs Ripe: {(isRipe ? "Yes" : "No")}\n\tHas Seeds: {(hasSeeds ? "Yes" : "No")}";
        }
        //public override void Peel()
        //{
        //    Console.WriteLine("Peeling an Peach...");
        //}
    }
}