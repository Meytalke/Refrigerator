using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public abstract class Cheese : DairyProduct
    {
        private string origin;
        private double fatPercentage;

        public string Origin { get => origin; set => origin = value; }
        public double FatPercentage { get => fatPercentage; set => fatPercentage = value; }

        public Cheese(string Name, double Price, DateTime purchaseDay, int ShelfLife, double caloriesPercentage, double lactosePercentage, string brand, string origin, double fatPercentage)
            : base(Name, Price, purchaseDay, ShelfLife, caloriesPercentage, lactosePercentage, brand)
        {
            Origin = origin;
            FatPercentage = fatPercentage;
        }

        public override string print()
        {
            return $"{base.print()}\n\tOrigin: {origin}\n\tFat: {fatPercentage}%";
        }
    }
}