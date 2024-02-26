using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogIn : System.Web.UI.Page
{
    SqlBaglanti bgl = new SqlBaglanti();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string query = "SELECT * FROM Users";

        SqlCommand cmd = new SqlCommand(query, bgl.Baglanti());
        SqlDataReader read = cmd.ExecuteReader();


        while (read.Read())
        {
            string name = read["Username"].ToString();

            if (name == UsernameText.Text)
            {
                Response.Write("<script>alert('Username Doru');</script>");
                string Password = read["Password"].ToString();
                if (Password == PasswordText.Text)
                {
                    string Id = read["ID"].ToString();

                    Response.Write("<script>alert('Giris Yapıldı}');</script>");
                    Response.Redirect("MainPage.aspx?Id="+Id);
                }
            }
        }

        bgl.Baglanti().Close();
    }

    protected void PasswordText_TextChanged(object sender, EventArgs e)
    {

    }
}