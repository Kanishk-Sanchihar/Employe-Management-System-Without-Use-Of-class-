using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class search_emp : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;

    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=emp;Integrated Security=True");
        con.Open();

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s;
        s="select * from add_emp where eid ="+TextBox1.Text;
        DataSet ds = new DataSet();
        da = new SqlDataAdapter(s, con);

        da.Fill(ds);
        TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
        TextBox3.Text = ds.Tables[0].Rows[0][2].ToString();
        TextBox4.Text = ds.Tables[0].Rows[0][3].ToString();
        

    }
}