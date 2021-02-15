using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQSCENARIOS.LINQ.LINQ_TO_OBJECTS.LINQTOFILES
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"E:\output");
                var giffiles = from file in dir.GetFiles()
                               where file.Extension == ".gif"
                               orderby file.Length
                               select new { FileName = file.Name, FileSize = (file.Length / 1024) + " KB" };
                gv.DataSource = giffiles;
                gv.DataBind();
                
            }
        }
    }
}