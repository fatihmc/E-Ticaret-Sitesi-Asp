using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace itpwebsite
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (Session["Email"] != null)
            //{
            //    Response.Write("Hoşgeldin " + Session["Email"]);
            //}
            //else
            //{
            //    Response.Redirect("login.aspx");
            //}

            string filter = txtadinisenkoy.Text;
            
            string sorgu = "SELECT TOP 6 * FROM Products";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");

            SqlCommand komut = new SqlCommand(sorgu, con);

            con.Open();

            SqlDataAdapter adaptor1 = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            adaptor1.Fill(dt);

            ListView1.DataSource = dt;
            ListView1.DataBind();
            //MessageBox.Show("Kayıt Başarı ile Eklendi");
            con.Close();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string filter = txtadinisenkoy.Text;
            
            string sorgu = "SELECT * FROM Products WHERE Name LIKE '%"+ txtadinisenkoy.Text + "%' ORDER BY Price";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");

            SqlCommand komut = new SqlCommand(sorgu, con);

            con.Open();
            
            SqlDataAdapter adaptor1 = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            adaptor1.Fill(dt);
          
            ListView1.DataSource = dt;
            ListView1.DataBind();
            con.Close();

        }

        protected void btnSepeteEkle_Click(object sender, CommandEventArgs e)

        {
            // SEPETE EKLE------------------------------------------------------

            if (Session["Email"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                string kullaniciAdi = Session["Email"].ToString();

                int urunID = Convert.ToInt32(e.CommandArgument.ToString());


                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");

                string sorgu = "INSERT INTO Baskets (kullaniciAdi, urunID) VALUES (@kullaniciAdi, @urunID)";

                SqlCommand komut = new SqlCommand(sorgu, con);

                con.Open();
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@urunID", urunID);


                komut.ExecuteNonQuery();
                MessageBox.Show("Sepete eklendi");
                con.Close();

            }


        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}