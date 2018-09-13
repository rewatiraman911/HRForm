using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SqlConnect sql;
    protected void Page_Load(object sender, EventArgs e)
    {
        sql = new SqlConnect();
        repeater1.DataSource = sql.getTable("department");
        repeater1.DataBind();
    }
}