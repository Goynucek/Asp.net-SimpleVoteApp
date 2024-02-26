using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SıgnIn : System.Web.UI.Page
{
    SqlBaglanti bgl = new SqlBaglanti();


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
       string query = "INSERT INTO Users (Username, Password, IsVoted, ilkAday, ikinciAday) VALUES (@Username, @Password, @IsVoted, @ilkAday, @ikinciAday)";

        // SQL komutu oluşturma
        using (SqlCommand cmd = new SqlCommand(query, bgl.Baglanti()))
        {
            // Parametreleri ekleyerek SQL enjeksiyonundan korunma
            cmd.Parameters.AddWithValue("@Username", UsernameText.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordText.Text);
            cmd.Parameters.AddWithValue("@IsVoted", "False");
            cmd.Parameters.AddWithValue("@ilkAday", "False");
            cmd.Parameters.AddWithValue("@ikinciAday","False");

            // Komutu çalıştırma
            int rowsAffected = cmd.ExecuteNonQuery();

            // Ekleme işlemi başarılıysa
            if (rowsAffected > 0)
            {
                Response.Redirect("LogIn.aspx");
                Response.Write("<script>alert('Üyelik Gerçekleşti');</script>");
            }
            else
            {
                Response.Write("<script>alert('Üyelik Gerçekleşmedi');</script>");
            }
        }
        bgl.Baglanti().Close();
    }
}