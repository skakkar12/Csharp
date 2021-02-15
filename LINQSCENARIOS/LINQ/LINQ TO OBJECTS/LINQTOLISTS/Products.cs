using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQSCENARIOS.LINQ.LINQ_TO_OBJECTS.LINQTOLISTS
{
    public class Products
    {
        private string _productName;
        private string _category;
        private decimal _price;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

    }
}