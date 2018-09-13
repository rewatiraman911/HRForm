using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for SqlConnect
/// </summary>
public class SqlConnect
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    public SqlConnect()
    {
        string conn = ConfigurationManager.ConnectionStrings["strconn"].ConnectionString;
        con = new SqlConnection(conn);
        con.Open();

    }
    public DataSet getTable(string table)
    {
        string query = "select * from " + table;
        cmd = new SqlCommand(query, con);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet getTable()
    {
        string query = "select empid,ename,salary,Employee.depid,depname from Employee join department on Employee.depid=department.depid";
        cmd = new SqlCommand(query, con);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public int addDepart(string id, string name)
    {
        string insQuery = "insert into department values('"+id+"','"+name+"')";
        cmd = new SqlCommand(insQuery, con);//jitne b dml statmnt h execute hone pr int return karte hai
        int count = cmd.ExecuteNonQuery();//ENQ is for dml stmnt
        return count;
    }

    public DataSet getDpart()
    {
        string dep = "select * from department";
        cmd = new SqlCommand(dep, con);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public int addEmp(string id,string name,int sal,string did)
    {
        string addQuery = "insert into employee values('" + id + "','" + name + "'," + sal + ",'" + did + "')";
        cmd = new SqlCommand(addQuery, con);
        int count = cmd.ExecuteNonQuery();
        return count;

    }
}