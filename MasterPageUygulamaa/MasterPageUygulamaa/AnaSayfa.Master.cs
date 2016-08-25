using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageUygulamaa
{
    public partial class AnaSayfa : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=ASUS\MYSERVER;database=NORTHWND;trusted_connection=true;");

            SqlDataAdapter da = new SqlDataAdapter("select categoryName,categoryID from categories",con);
            DataTable dt = new DataTable("categories");
            da.Fill(dt);
            categories.DataSource = dt;
            categories.DataBind();

        }
    }
}