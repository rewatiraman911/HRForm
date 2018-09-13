using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addDep : System.Web.UI.Page
{
    SqlConnect connect;
    protected void Page_Load(object sender, EventArgs e)
    {
        connect = new SqlConnect();//connectiom bnn jaega aese iske badd create k liae method bnaenge sql page me

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string depid = TextBox1.Text;
        string dname = TextBox2.Text;
        int res = connect.addDepart(depid, dname);// functn call
        if (res > 0)
        {
            Response.Redirect("~/Default.aspx");//agr fillhogya hai details toh vallue dikha de

        }
        else
        {
            Response.Write("Error!!");
        }

    }
}