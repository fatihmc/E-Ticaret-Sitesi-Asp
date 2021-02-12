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
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Emailsoru = txtmail.Text;
            string Soru = txtistek.Text;
            

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");

            string sorgu = "INSERT INTO Contact (Emailsoru, Soru) VALUES (@Emailsoru, @Soru)";

            SqlCommand komut = new SqlCommand(sorgu, con);

            con.Open();
            komut.Parameters.AddWithValue("@Emailsoru", Emailsoru);
            komut.Parameters.AddWithValue("@Soru", Soru);
          

            komut.ExecuteNonQuery();
            MessageBox.Show("Sorunuz gönderildi!");
            con.Close();
        }
    }
}