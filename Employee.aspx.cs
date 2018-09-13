using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employee : System.Web.UI.Page
{
    SqlConnect sql;
    protected void Page_Load(object sender, EventArgs e)
    {
        sql = new SqlConnect();
        repeater2.DataSource = sql.getTable();
        repeater2.DataBind();
    }
}