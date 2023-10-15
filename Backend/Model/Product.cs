using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public abstract class Product
    {
        private int id;
        private string name;
        private double price;
        private string color;
        private string size;
        private double weight;
        private double liters;
        private DateTime purchaseDay;
        private int shelfLife;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public string Size { get => size; set => size = value; }
        public double Weight { get => weight; set => weight = value; }
        public DateTime PurchaseDay { get => purchaseDay; set => purchaseDay = value; }
        public int ShelfLife { get => shelfLife; set => shelfLife = value; }
        public double Liters { get => liters; set => liters = value; }
        public int Id { get => id; set => id = value; }
        private static Random random = new Random();
        private static HashSet<int> generatedIds = new HashSet<int>();

        public static int GenerateId()
        {
            int id;
            do
            {
                id = random.Next(100000, 999999);
            } while (generatedIds.Contains(id));

            generatedIds.Add(id);
            return id;
        }
        protected Product(string name, double price, DateTime purchaseDay, int shelfLife)
        {
            Name = name;
            Price = price;
            PurchaseDay = purchaseDay;
            ShelfLife = shelfLife;
            Id = GenerateId();
        }
        public bool decreaseProduct(double weight)
        {
            if (Weight >= weight)
            {
                Weight -= weight;
                return true;
            }
            return false;
        }

        public void addProduct(double weight)
        {
            Weight += weight;
        }

        public virtual string print()
        {
            return $"ID: {id}\n\tName: {Name}\n\tPrice: {Price}";
        }
    }
}