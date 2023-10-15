using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public abstract class DairyBeverage : Beverage
    {
        private string milkType;
        private bool isLactoseFree;
        private bool isVegan;
        private bool isAlmondMilkBeverage;
        private double fatPercentage;

        public string MilkType { get => milkType; set => milkType = value; }
        public bool IsLactoseFree { get => isLactoseFree; set => isLactoseFree = value; }
        public bool IsVegan { get => isVegan; set => isVegan = value; }
        public bool IsAlmondMilkBeverage { get => isAlmondMilkBeverage; set => isAlmondMilkBeverage = value; }
        public double FatPercentage { get => fatPercentage; set => fatPercentage = value; }
        public DairyBeverage(string name, double price, DateTime purchaseDay, int shelfLife, double liters, string brand, string flavor, bool isCarbonated, string milkType, bool isLactoseFree, bool isVegan, bool isAlmondMilkBeverage, double fatPercentage)
             : base(name, price, purchaseDay, shelfLife, liters, brand, flavor, isCarbonated)
        {
            MilkType = milkType;
            IsLactoseFree = isLactoseFree;
            IsVegan = isVegan;
            IsAlmondMilkBeverage = isAlmondMilkBeverage;
            FatPercentage = fatPercentage;
        }

        public override string print()
        {
            return $"{base.print()}\n\tMilk Type: {milkType}%\n\tIs LactoseFree: {(isLactoseFree ? "Yes" : "No")}\n\tIs Vegan: {(isVegan ? "Yes" : "No")}\n\tIs Almond Milk Beverage: {(isAlmondMilkBeverage ? "Yes" : "No")}\n\tfat:{fatPercentage}%";
        }
    }
}