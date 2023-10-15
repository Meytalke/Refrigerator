using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj
{
    public class Refrigerator
    {
        private string brand;
        private int capacity;
        private int numberOfDoors;
        private int items=2;
        private bool hasFreezer;
        private bool isEnergyEfficient;

        public string Brand { get => brand; set => brand = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }
        public int Items { get => items; set => items = value; }
        public bool HasFreezer { get => hasFreezer; set => hasFreezer = value; }
        public bool IsEnergyEfficient { get => isEnergyEfficient; set => isEnergyEfficient = value; }

        public Refrigerator(string brand, int capacity=400, int numberOfDoors=1, bool hasFreezer=false, bool isEnergyEfficient=false)
        {
            this.brand = brand;
            this.capacity = capacity;
            this.numberOfDoors = numberOfDoors;
            this.hasFreezer = hasFreezer;
            this.isEnergyEfficient = isEnergyEfficient;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public string GetBrand()
        {
            return brand;
        }

        public void SetCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public int GetCapacity()
        {
            return capacity;
        }
        public int GetItems()
        {
            return items;
        }
        public void SetNumberOfDoors(int numberOfDoors)
        {
            this.numberOfDoors = numberOfDoors;
        }

        public int GetNumberOfDoors()
        {
            return numberOfDoors;
        }

        public void SetHasFreezer(bool hasFreezer)
        {
            this.hasFreezer = hasFreezer;
        }

        public bool GetHasFreezer()
        {
            return hasFreezer;
        }

        public void SetIsEnergyEfficient(bool isEnergyEfficient)
        {
            this.isEnergyEfficient = isEnergyEfficient;
        }

        public bool GetIsEnergyEfficient()
        {
            return isEnergyEfficient;
        }
    }
}
