using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Butter : DairyProduct
    {
        private bool isSalted;
        private double fatPercentage;
        public bool IsSalted { get => isSalted; set => isSalted = value; }
        public double FatPercentage { get => fatPercentage; set => fatPercentage = value; }

        public Butter(string Name, double Price, DateTime purchaseDay, int ShelfLife, double caloriesPercentage, double lactosePercentage, string brand, bool isSalted, double fatPercentage)
            : base(Name, Price, purchaseDay, ShelfLife, caloriesPercentage, lactosePercentage, brand)
        {
            IsSalted = isSalted;
            FatPercentage = fatPercentage;
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs Salted: {(isSalted ? "Yes" : "No")}\n\tfat: {fatPercentage}%";
        }
    }
}