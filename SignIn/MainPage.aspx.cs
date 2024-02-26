using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ID = Request.QueryString["Id"];

        MemberInfo();

        if (IsVoted == "True")
        {
            Button1.Enabled = false;
            Button2.Enabled = false;
        }
    }


    SqlBaglanti bgl = new SqlBaglanti();
    public string ID { get; set; }
    public string IsVoted { get; set; }

    public int IlkAdayOy { get; set; }
    public int IkınciAdayOy { get; set; }



    public void MemberInfo()
    {
        string query = "SELECT ID, IsVoted, ilkAday, ikinciAday FROM Users";

        SqlCommand cmd = new SqlCommand(query, bgl.Baglanti());
        SqlDataReader read = cmd.ExecuteReader();

        int i = 0;
        while (read.Read())
        {
            i++;
            int Id = int.Parse(ID);
            if (i == Id)
            {
                IsVoted = read["IsVoted"].ToString();
            }

            string a = read["ilkAday"].ToString();
            if (a == "True")
            {
                IlkAdayOy++;
            }

            string b = read["ikinciAday"].ToString();
            if (b == "True")
            {
                IkınciAdayOy++;
            }
        }

        Label1.Text = IlkAdayOy.ToString();
        Label2.Text = IkınciAdayOy.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string updateQuery = "UPDATE Users SET ilkAday = @YeniDeger, IsVoted = @YeniDeger WHERE ID = @SartDeger";

        // SQL komutu oluşturma
        using (SqlCommand cmd = new SqlCommand(updateQuery, bgl.Baglanti()))
        {
            // Parametreleri ekleyerek SQL enjeksiyonundan korunma
            cmd.Parameters.AddWithValue("@YeniDeger", "True");
            cmd.Parameters.AddWithValue("@SartDeger", ID);


            // Komutu çalıştırma
            int rowsAffected = cmd.ExecuteNonQuery();

            // Ekleme işlemi başarılıysa
            if (rowsAffected > 0)
            {
                Response.Write("<script>alert('Oy Verildi');</script>");
            }
            else
            {
                Response.Write("<script>alert('Oy Verilmedi');</script>");
            }
        }
        Response.Redirect(Request.RawUrl);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string updateQuery = "UPDATE Users SET ikinciAday = @YeniDeger, IsVoted = @YeniDeger WHERE ID = @SartDeger";

        // SQL komutu oluşturma
        using (SqlCommand cmd = new SqlCommand(updateQuery, bgl.Baglanti()))
        {
            // Parametreleri ekleyerek SQL enjeksiyonundan korunma
            cmd.Parameters.AddWithValue("@YeniDeger", "True");
            cmd.Parameters.AddWithValue("@SartDeger", ID);


            // Komutu çalıştırma
            int rowsAffected = cmd.ExecuteNonQuery();

            // Ekleme işlemi başarılıysa
            if (rowsAffected > 0)
            {
                Response.Write("<script>alert('Oy Verildi');</script>");
            }
            else
            {
                Response.Write("<script>alert('Oy Verilmedi');</script>");
            }
        }
        Response.Redirect(Request.RawUrl);
    }
}