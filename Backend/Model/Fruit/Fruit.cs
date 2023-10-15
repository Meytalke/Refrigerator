using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public abstract class Fruit : Product
    {
        private string[] vitamins;
        private string taste ;
        public string[] Vitamins { get => vitamins; set => vitamins = value; }
        public string Taste { get => taste; set => taste = value; }

        public Fruit(string name, double price, DateTime purchaseDay, int shelfLife, double weight, string size, string color, string[] vitamins, string taste)
           : base(name, price, purchaseDay, shelfLife)
        {
            Vitamins = vitamins;
            Color = color;
            Size = size;
            Weight = weight;
            Taste = taste;
        }
        public override string print()
        {
            return $"{base.print()}\n\tColor: {Color}\n\tWeight: {Weight}\n\tColor: {Color}\n\tTaste: {Taste}\n\tVitamins: {string.Join(", ", Vitamins)}";
        }
    }
}