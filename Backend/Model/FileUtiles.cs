using Refrigerator_FinalProj.Backend.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator_FinalProj.Backend.Model
{
    public class FileUtiles
    {
        public static void SaveProductsToFile(BindingList<Product> products)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fi = new System.IO.FileInfo("products.bin");
            using (var binaryFile = fi.Create())
            {
                binaryFormatter.Serialize(binaryFile, products);
                binaryFile.Flush();
            }
            Console.WriteLine("Succses Save"); 
        }

        public static BindingList<Product> LoadProductsFromFile()
        {
            BindingList<Product> products;
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fi = new System.IO.FileInfo("products.bin");
                using (var binaryFile = fi.OpenRead())
                {
                    products = (BindingList<Product>)binaryFormatter.Deserialize(binaryFile);
                }
            }
            catch (Exception ex)
            {
                products = new BindingList<Product>();
            }
            return products;
        }
    }
}
