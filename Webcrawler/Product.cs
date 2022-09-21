using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webcrawler
{
    public class Product
    {
        public ProductSourceData Source;

        /// <summary>
        /// The store that the product is sold in
        /// </summary>
        public string StoreName;

        /// <summary>
        /// The name of the product
        /// </summary>
        public string Name;

        /// <summary>
        /// The Brand the product belongs to
        /// </summary>
        public string Brand;

        /// <summary>
        /// The amount of grams that is contained in this package
        /// </summary>
        public string UnitInfo;


        /// <summary>
        /// The price in euro this product is sold for
        /// </summary>
        public string ProductPrice;

        /// <summary>
        /// A short summary of the product
        /// </summary>
        public string Summary;

        /// <summary>
        /// The description of the product
        /// </summary>
        public string Description;

        /// <summary>
        /// The ingredients contained
        /// </summary>
        public string Ingredients;

        /// <summary>
        /// The neutritional value
        /// </summary>
        public List<ValueTuple<string, string>> Neutrition;

        public Product()
        {
            StoreName = "Unknown";
            Name = "Placeholder";
            Brand = "Placeholder";
            UnitInfo = "0g";
            ProductPrice = "0.00";
            Summary = "Placeholder";
            Description = "Placeholder";
            Ingredients = "Placeholder";
            Neutrition = new List<ValueTuple<string, string>>(); ;
        }

        public Product(string storeName, string name, string brand, string unitInfo, string unitPrice, string productPrice, string summary, string description, string ingredients, List<ValueTuple<string, string>> neutrition)
        {
            StoreName = storeName;
            Name = name;
            Brand = brand;
            UnitInfo = unitInfo;
            ProductPrice = productPrice;
            Summary = summary;
            Description = description;
            Ingredients = ingredients;
            Neutrition = neutrition;
        }

        public int GetProductPrice()
        {
            return int.Parse(ProductPrice);
        }

        public int GetUnitPrice()
        {
            throw new NotImplementedException();
        }
    }

    public struct ProductSourceData
    {
        public ProductSource Store;
        public string Url;
        public string ImageUrl;
        public string Department;
    }

    public enum ProductSource
    {
        AlbertHeijn,
        Jumbo
    }

    public enum MeasurementUnit
    {
        Kilograms,
        Grams,
        Liter,
        Milliliter,
        Items
    }
}
