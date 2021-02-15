using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQSCENARIOS.LINQ.LINQ_TO_OBJECTS.LINQTOINTARRY
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //int[] ary1 = new int[] { 10, 27, 35, 40, 50, 11, 23, 25, 39, 22, 36 };

                //var maxvalues = (from values in ary1
                //                 orderby (int)values descending
                //                 select new { Max3Values = values }).Take(3);
                //gv.DataSource = maxvalues;
                //gv.DataBind();



                //int[] ary2 = new int[] { 10, 27, 35, 40, 50, 11, 23, 25, 39, 22, 36 };
                //var res = from values in ary2
                //          where (int)values >= 20 && (int)values <= 35
                //          orderby (int)values
                //          select new { ValuesBetween20_35 = values };
                //gv.DataSource = res;
                //gv.DataBind();



                int[] ary3 = new int[] { 10, 27, 35, 40, 50, 11, 23, 25, 39, 22, 36 };
                var evennumbers = from values in ary3
                                  where (int)values % 2 == 0
                                  orderby (int)values
                                  select new { EvenNumbers = values };
                gv.DataSource = evennumbers;
                gv.DataBind();
            }



        }
    }
}