using Refrigerator_FinalProj.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refrigerator_FinalProj.Backend.Model
{
    [Serializable]
    public class ProductsManager
    {
        
        private static BindingList<Product> products;
        static ProductsManager()
        {
            products = FileUtiles.LoadProductsFromFile();
        }
        public int CountOccurrences(string productName)
        {
            int count = 0;
            products = FileUtiles.LoadProductsFromFile();
            foreach (Product product in products)
            {
                if (product.Name == productName)
                {
                    count++;
                }
            }

            return count;
        }

        public void LoadProductsFromFile()
        {
            products = FileUtiles.LoadProductsFromFile();
        }
        public static void saveProducts(object sender, FormClosingEventArgs e)
        {
            FileUtiles.SaveProductsToFile(products);
        }

        public BindingList<Product> GetProducts()
        {
            return products;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void mergeProducts(ProductsManager m)
        {
            foreach (Product pro in m.GetProducts())
            {
                if (!products.Any(p => p.Id == pro.Id))
                {
                    products.Add(pro);
                }
            }
        }

        public ProductsManager()
        {
            products = new BindingList<Product>();
        }

        public bool removeProduct(Product product)
        {
            return products.Remove(product);
        }
        //public void removeAll(ProductsManager m)
        //{
        //    products.Clear();
        //}
        public void RemoveProductById(int productId)
        {
            Product productToRemove = products.FirstOrDefault(product => product.Id == productId);
            if (productToRemove != null)
            {
                removeProduct(productToRemove);
            }
        }
        public Product ChangeByid(int productId)
        {
            Product productToChange = products.FirstOrDefault(product => product.Id == productId);
            if(productToChange != null)
            {
                return productToChange;
            }
            else
            {
                return null;
            }
        }
        public bool UpdateProductLifetime(Product product)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan timeSpan = currentDate - product.PurchaseDay;
            int remainingDays = product.ShelfLife - (int)timeSpan.TotalDays;

            if (remainingDays <= 0)
            {
                return false;
            }
            else
            {
                product.ShelfLife = remainingDays;
                return true;
            }
        }
        public void DisplayPrintFunc(int id)
        {
            Product productt = products.FirstOrDefault(product => product.Id == id);
            if (productt != null)
            {
                string productName = productt.Name;
                string pro = productt.print();
                MessageBox.Show($"The product name is: {productName} \n\t{pro}");
            }
            else
            {
                MessageBox.Show("Invalid product ID");
            }
        }
        public BindingList<T> GetSpecificProduct<T>() where T : Product
        {
            BindingList<T> specificProducts = new BindingList<T>();
            foreach (Product product in products)
                if (product is T)
                    specificProducts.Add(product as T);
            return specificProducts;
        }

        public List<Product> GetFilteredProducts(string selectedProductName)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (Product product in products)
            {
                if (product.Name == selectedProductName)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }
    }
}