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
    public partial class CategoryDetails : System.Web.UI.Page
    {
        string id;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["kid"];

            SqlConnection con = new SqlConnection(@"server=ASUS\MYSERVER;database=NORTHWND;trusted_connection=true;");

            SqlDataAdapter da = new SqlDataAdapter("select ProductName,UnitPrice,UnitsInStock,productID from Products where CategoryID=@id", con);

            if (id != null)
            {
                da.SelectCommand.Parameters.AddWithValue("id", id);
                DataTable dt = new DataTable("detayList");
                da.Fill(dt);
                kategoriGrid.DataSource = dt;
                kategoriGrid.DataBind();
            }

        }

        protected void kategoriGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index;
            int productId;

            if (e.CommandName == "sec")
            {

                index = Convert.ToInt32((e.CommandArgument));
                kategoriGrid.SelectedIndex = index;

                productId = Convert.ToInt32((kategoriGrid.SelectedDataKey.Value));

                SqlConnection con = new SqlConnection(@"server=ASUS\MYSERVER;database=NORTHWND;trusted_connection=true;");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select OrderID,UnitPrice,Quantity from [order details] where productId =@proId", con);
                da.SelectCommand.Parameters.AddWithValue("proId", productId);
                da.Fill(dt);
                kategoriGrid.Visible = false;
                bilgi.DataSource = dt;
                bilgi.DataBind();
                blg.Text = kategoriGrid.SelectedRow.Cells[0].Text + " Adlı Ürünün Bilgileri...";
            }
        }
    }
}