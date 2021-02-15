using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQSCENARIOS.LINQ.LINQ_TO_OBJECTS.LINQTOLISTS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Products> listProducts = new List<Products>();
                listProducts.Add(new Products { ProductName = "Mobile", Category = "Electronics", Price = 6000 });
                listProducts.Add(new Products { ProductName = "Fridge", Category = "Electronics", Price = 12000 });
                listProducts.Add(new Products { ProductName = "Chair", Category = "HomeNeeds", Price = 1000 });
                listProducts.Add(new Products { ProductName = "Table", Category = "HomeNeeds", Price = 6000 });
                listProducts.Add(new Products { ProductName = "T-Shirt", Category = "Clothes", Price = 1500 });
                listProducts.Add(new Products { ProductName = "Jeans", Category = "Clothes", Price = 3500 });



                var prds = from products in listProducts
                           where products.Price > 5000 && products.Price < 10000
                           orderby products.Price
                           select new
                           {
                               products.ProductName,
                               products.Category,
                               products.Price

                           };


                this.gvXML.DataSource = prds;
                this.gvXML.DataBind();
            }
        }
    }
}