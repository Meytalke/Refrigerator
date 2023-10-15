using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public abstract class Meat : Product
    {
        private double fatPercentage;
        private bool isKosher;

        public double FatPercentage { get => fatPercentage; set => fatPercentage = value; }
        public bool IsKosher { get => isKosher; set => isKosher = value; }

        public Meat(string name, double price, DateTime purchaseDay, int shelfLife, double weight, double fatPercentage, bool isKosher)
            : base(name, price, purchaseDay, shelfLife)
        {
            FatPercentage = fatPercentage;
            IsKosher = isKosher;
            Weight = weight;
        }

        public override string print()
        {
            return $"{base.print()}\n\tWeight: {Weight}Kg"; // add the details
        }
    }
}