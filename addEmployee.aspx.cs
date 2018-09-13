using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addEmployee : System.Web.UI.Page
{
    SqlConnect connect;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            connect = new SqlConnect();//ab sql wale page par function bnaenge return type rakhenge dataset
            DropDownList1.DataSource = connect.getDpart();//ye data source dega
            DropDownList1.DataTextField = "DepName";//dropdown k do part hote h ye aur niche ka
            DropDownList1.DataValueField = "Depid";
            DropDownList1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        connect = new SqlConnect();
        string eid = TextBox1.Text;
        string ename = TextBox2.Text;
        int sal = int.Parse(TextBox3.Text);
        string dep = DropDownList1.SelectedValue.ToString();
        int res = connect.addEmp(eid, ename, sal, dep);
        if (res > 0)
        {
            Response.Redirect("~/Employee.aspx");
        }
        else
        {
            Response.Write("Check Inputs!!"); 
        }
    }
}