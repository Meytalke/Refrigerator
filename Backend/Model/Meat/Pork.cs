using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class Pork : Meat
    {
        private bool isSmoked;
        private bool isMarinated;

        public bool IsSmoked { get => isSmoked; set => isSmoked = value; }
        public bool IsMarinated { get => isMarinated; set => isMarinated = value; }
        private static Random random = new Random();
        private static HashSet<int> generatedIds = new HashSet<int>();


        public Pork(string name, double price, DateTime purchaseDay, int shelfLife, double weight, double fatPercentage, bool isKosher, bool IsSmoked, bool IsMarinated)
            : base(name, price, purchaseDay, shelfLife, weight, fatPercentage, isKosher)
        {
            IsSmoked = isSmoked;
            IsMarinated = isMarinated;
        }

        public override string print()
        {
            return $"{base.print()}\n\tIs Smoked: {(isSmoked ? "Yes" : "No")}\n\tIs Marinated: {(isMarinated ? "Yes" : "No")}";
        }
    }
}