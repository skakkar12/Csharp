using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;


namespace LINQSCENARIOS.LINQ.LINQTOXML
{
    public partial class BetweenAndOrderBy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
             System.Xml.Linq.XDocument xdoc = System.Xml.Linq.XDocument.Parse(@"
                <Employees>
                    <Employee>
                        <Name>Thomas</Name>
                        <Designation>Executive</Designation>
                        <Department>Accounts</Department>
                        <Salary>5000</Salary>
                    </Employee>
                    <Employee>
                        <Name>Wills</Name>
                        <Designation>Manager</Designation>
                        <Department>Accounts</Department>
                        <Salary>24000</Salary>
                    </Employee>
                    <Employee>
                        <Name>Brod</Name>
                        <Designation>Manager</Designation>
                        <Department>Finance</Department>
                        <Salary>28000</Salary>
                    </Employee>
                    <Employee>
                        <Name>Smith</Name>
                        <Designation>Analyst</Designation>
                        <Department>Finance</Department>
                        <Salary>21000</Salary>
                    </Employee>
                </Employees>
                ");


             var res = from emp in xdoc.Root.Elements()
                       where 20000 < (decimal)emp.Element("Salary") &&
                       (decimal)emp.Element("Salary") < 25000
                       orderby (decimal)emp.Element("Salary") ascending
                       select new
                       {
                           EmployeeName = emp.Element("Name").Value,
                           Designation = emp.Element("Designation").Value,
                           Department = emp.Element("Department").Value,
                           Salary = emp.Element("Salary").Value
                       };
             gvXML.DataSource = res;
             gvXML.DataBind();
            }
        }
    }
}