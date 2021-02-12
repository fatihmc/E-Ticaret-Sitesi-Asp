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
    public partial class Login : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Email = txtklnc.Text;
            string Password = txtsfr.Text;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");
            string sorgu = "SELECT * from Users WHERE Email=@Email AND Password=@Password";
            SqlCommand komut = new SqlCommand(sorgu,con);

            con.Open();
            komut.Parameters.AddWithValue("@Email", Email);
            komut.Parameters.AddWithValue("@Password", Password);
            komut.ExecuteNonQuery();
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                Session.Add("Email", txtklnc.Text);
                Session.Add("Password", txtsfr.Text);
                MessageBox.Show("Başarıyla giriş yapıldı!");
                Response.Redirect("AnaSayfa.aspx");
               
                //Yönlendirme

            }
            else
            {
               
                txtklnc.Text =  "";
                txtsfr.Text = "";
                MessageBox.Show("Giriş başarısız!");

            }


            con.Close();
           

            
        }
    }
}