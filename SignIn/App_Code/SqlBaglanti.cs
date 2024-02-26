using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// SqlBaglanti için özet açıklama
/// </summary>
public class SqlBaglanti
{
    public SqlConnection Baglanti()
    {
        SqlConnection Baglan = new SqlConnection(@"Server=DESKTOP-UQGF5P1\SQLEXPRESS;Database=VoteWebsite;Trusted_Connection=True;");
        Baglan.Open();

        return Baglan;
    }
}