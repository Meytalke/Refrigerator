using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Orange : Fruit
    {
        private bool isOrange;
        private bool hasSeeds;

        public bool IsOrange { get => isOrange; set => isOrange = value; }
        public bool HasSeeds { get => hasSeeds; set => hasSeeds = value; }

        public Orange(string name, double price, DateTime purchaseDay, int shelfLife, double weight, string size, string color, string[] vitamins, string taste, bool isOrange, bool hasSeeds)
           : base(name, price, purchaseDay, shelfLife, weight, size, color, vitamins,  taste)
        {
            IsOrange = isOrange;
            HasSeeds = hasSeeds;
        }
        public override string print()
        {
            return $"{base.print()}\n\tIs Orange: {(isOrange ? "Yes" : "No")}\n\tHas Seeds: {(hasSeeds ? "Yes" : "No")}";
        }
        //public override void Peel()
        //{
        //    Console.WriteLine("Peeling an Orange...");
        //}
    }
}