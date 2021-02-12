using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace itpwebsite
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


          


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");

            SqlCommand komut = new SqlCommand("INSERT INTO Users ([Name],[LastName],[Email],[Password],[Telephone],[Adress],[TCKN]) VALUES (@Name,@LastName, @Email,@Password, @Telephone, @Adress,@TCKN)", con);

            con.Open();
            komut.Parameters.AddWithValue("@Name", txtad.Text);
            komut.Parameters.AddWithValue("@LastName", txtsoyad.Text);
            komut.Parameters.AddWithValue("@Email", txtemail.Text);
            komut.Parameters.AddWithValue("@Password",txtsfr.Text);
            komut.Parameters.AddWithValue("@Telephone",txttel.Text);
            komut.Parameters.AddWithValue("@Adress", txtadres.Text);
            komut.Parameters.AddWithValue("@TCKN", txttc.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarı ile Eklendi");
            con.Close();
        }
    }
}