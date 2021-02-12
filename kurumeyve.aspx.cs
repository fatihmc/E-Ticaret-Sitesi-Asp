using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace itpwebsite
{
    public partial class kurumeyve : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT TOP 6 * FROM Products WHERE CategoryId=3";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");

            SqlCommand komut = new SqlCommand(sorgu, con);

            con.Open();

            SqlDataAdapter adaptor1 = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            adaptor1.Fill(dt);

            ListViewKuruMeyve.DataSource = dt;
            ListViewKuruMeyve.DataBind();
         
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