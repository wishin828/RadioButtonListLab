using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RadioButtonListLab.Models
{
    public class DataUtility
    {
        static List<ProductModel> _data;
        public static IQueryable<ProductModel> GetDatas()
        {
            if (_data == null)
            {
                _data = new List<ProductModel>();
                _data.Add(new ProductModel { CategoryName = "Apple", ProductId = 1, ProductName = "iPhone3", Price = 5000, Qty = 5, CreateDate = new DateTime(2009, 1, 1) });
                _data.Add(new ProductModel { CategoryName = "Apple", ProductId = 2, ProductName = "iPhone4", Price = 10000, Qty = 6, CreateDate = new DateTime(2010, 3, 1) });
                _data.Add(new ProductModel { CategoryName = "Apple", ProductId = 3, ProductName = "iPhone4s", Price = 15000, Qty = 15, CreateDate = new DateTime(2011, 4, 1) });
                _data.Add(new ProductModel { CategoryName = "Apple", ProductId = 4, ProductName = "iPhone5", Price = 20000, Qty = 25, CreateDate = new DateTime(2012, 5, 1), OnSaled = true });
                _data.Add(new ProductModel { CategoryName = "Apple", ProductId = 5, ProductName = "iPhone5s", Price = 25000, Qty = 5, CreateDate = new DateTime(2013, 6, 8), OnSaled = true });

                _data.Add(new ProductModel { CategoryName = "HTC", ProductId = 6, ProductName = "Diamond", Price = 5000, Qty = 5, CreateDate = new DateTime(2009, 1, 1) });
                _data.Add(new ProductModel { CategoryName = "HTC", ProductId = 7, ProductName = "Titan", Price = 6000, Qty = 25, CreateDate = new DateTime(2010, 1, 13) });
                _data.Add(new ProductModel { CategoryName = "HTC", ProductId = 8, ProductName = "One", Price = 7000, Qty = 35, CreateDate = new DateTime(2011, 3, 12) });
                _data.Add(new ProductModel { CategoryName = "HTC", ProductId = 9, ProductName = "New One", Price = 15000, Qty = 45, CreateDate = new DateTime(2012, 11, 1), OnSaled = true });
                _data.Add(new ProductModel { CategoryName = "HTC", ProductId = 10, ProductName = "Flyer", Price = 3000, Qty = 55, CreateDate = new DateTime(2013, 1, 1), OnSaled = true });

                _data.Add(new ProductModel { CategoryName = "Nokia", ProductId = 11, ProductName = "Lumia610", Price = 5000, Qty = 5, CreateDate = new DateTime(2009, 1, 1) });
                _data.Add(new ProductModel { CategoryName = "Nokia", ProductId = 12, ProductName = "Lumia710", Price = 7000, Qty = 45, CreateDate = new DateTime(2010, 12, 1) });
                _data.Add(new ProductModel { CategoryName = "Nokia", ProductId = 13, ProductName = "Lumia810", Price = 8000, Qty = 35, CreateDate = new DateTime(2011, 11, 30) });
                _data.Add(new ProductModel { CategoryName = "Nokia", ProductId = 14, ProductName = "Lumia920", Price = 13000, Qty = 25, CreateDate = new DateTime(2012, 10, 12) });
                _data.Add(new ProductModel { CategoryName = "Nokia", ProductId = 15, ProductName = "Lumia1500", Price = 18000, Qty = 5, CreateDate = new DateTime(2013, 9, 12) ,OnSaled=true});
            }
            return _data.AsQueryable();
        }

        public static int Remove(int productId)
        {
            return _data.RemoveAll(o => o.ProductId == productId);
        }

        public static void Reset()
        {
            _data = null;
        }
    }
}