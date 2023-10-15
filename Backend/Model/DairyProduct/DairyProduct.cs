using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public abstract class DairyProduct : Product
    {
        private double caloriesPercentage;
        private double lactosePercentage;
        private string brand;
        public double CaloriesPercentage { get => caloriesPercentage; set => caloriesPercentage = value; }
        public double LactosePercentage { get => lactosePercentage; set => lactosePercentage = value; }
        public string Brand { get => brand; set => brand = value; }

        public DairyProduct(string Name, double Price, DateTime purchaseDay, int ShelfLife, double caloriesPercentage, double lactosePercentage, string brand)
          : base(Name, Price, purchaseDay, ShelfLife)
        {
            CaloriesPercentage = caloriesPercentage;
            LactosePercentage = lactosePercentage;
            Brand = brand;
        }

        public override string print()
        {
            return $"{base.print()}\n\tBrand: {brand}\n\tCalories: {caloriesPercentage}%\n\tLactose: {lactosePercentage}%";
        }

    }
}