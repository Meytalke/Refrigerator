using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public abstract class Vegetable : Product
    {
        private bool isOrganic;
        private string[] vitamins;

        public bool IsOrganic { get => isOrganic; set => isOrganic = value; }
        public string[] Vitamins { get => vitamins; set => vitamins = value; }

        public Vegetable(string name, double price, DateTime purchaseDay, int shelfLife, bool isOrganic, string color, string size, double weight, string[] vitamins)
            : base(name, price, purchaseDay, shelfLife)
        {
            IsOrganic = isOrganic;
            Color = color;
            Size = size;
            Weight = weight;
            Vitamins = vitamins;
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs Organic: {(IsOrganic ? "Yes" : "No")}\n\tSize: {Size}\n\tWeight: {Weight}\n\tColor: {Color}\n\tVitamins: {string.Join(", ", Vitamins)}";
        }
    }
}