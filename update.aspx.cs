using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class update : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=emp;Integrated Security=True");
        con.Open();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string s;
        s = "update emp set ename='" + TextBox7.Text + "', edept='" + TextBox8.Text + "' esal=" + TextBox9.Text + " where eid=" + TextBox10.Text;
        DataSet ds = new DataSet();
       
        Response.Write("<Script>alert('Record Updated Successfully')</script>");
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s;
        s = "select * from add_emp where eid=" + TextBox6.Text;
        DataSet ds = new DataSet();
        da = new SqlDataAdapter(s, con);
        da.Fill(ds);
        TextBox7.Text = ds.Tables[0].Rows[0][0].ToString();
        TextBox8.Text = ds.Tables[0].Rows[0][1].ToString();
        TextBox9.Text = ds.Tables[0].Rows[0][2].ToString();
       TextBox10.Text = ds.Tables[0].Rows[0][3].ToString();
       
       //TextBox7.Text = "";
       //TextBox8.Text = "";
       //TextBox9.Text = "";
      // TextBox10.Text = "";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string s;
        s = "delete from add_emp where eid=" + TextBox6.Text;
        cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
    }
}