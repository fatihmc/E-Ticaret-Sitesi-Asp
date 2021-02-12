using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Label = System.Web.UI.WebControls.Label;

namespace itpwebsite
{
    public partial class Sepetim : System.Web.UI.Page

    {
         int toplam = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Email"] != null)
            {
                Response.Write("Hoşgeldin " + Session["Email"]);
            }
            else
            {
                Response.Redirect("login.aspx");
            }
            string kullaniciAdi = Session["Email"].ToString();

           
            string sorgu = "SELECT * FROM Baskets WHERE kullaniciAdi=@kullaniciAdi";

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");

            SqlCommand komut = new SqlCommand(sorgu, con);
            komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
         
            con.Open();

            SqlDataAdapter adaptor1 = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            adaptor1.Fill(dt);

            adaptor1.Dispose();
            komut.Dispose();
            DataTable dtNew = new DataTable(); // sepeti tutacağımız bir datatable oluşturuyoruz

            dtNew.Columns.Add("ID");// DataTableye id colonunu ekliyoruz
            dtNew.Columns.Add("Name");//DataTableye isim colonunu ekliyoruz
            dtNew.Columns.Add("Price");//DataTableye fiyat colonunu ekliyoruz
            dtNew.Columns.Add("Description");//DataTableye adet colonunu ekliyoruz
            dtNew.Columns.Add("Image");//DataTableye tutar colonunu ekliyoruz
            dtNew.Columns.Add("Stock");//DataTableye tutar colonunu ekliyoruz

            foreach (DataRow row in dt.Rows)
            {
                int ID = Convert.ToInt32(row["urunID"].ToString());
                string sorguUrun = "SELECT * FROM Products WHERE ID=@ID";
                SqlCommand komutUrun = new SqlCommand(sorguUrun, con);
                komutUrun.Parameters.AddWithValue("@ID", ID);


                SqlDataReader okuyucu = komutUrun.ExecuteReader();
                
                DataRow drow = dtNew.NewRow();
                while (okuyucu.Read() == true)
                {
                    drow["ID"] = Convert.ToInt32(okuyucu["ID"].ToString());
                    drow["Name"] = okuyucu["Name"].ToString(); 
                    drow["Price"] = Convert.ToInt32(okuyucu["Price"].ToString());
                    drow["Description"] = okuyucu["Description"].ToString();
                    drow["Image"] = okuyucu["Image"].ToString();
                    drow["Stock"] = Convert.ToInt32(okuyucu["Stock"].ToString());    
                    dtNew.Rows.Add(drow); 

                    toplam = toplam + Convert.ToInt32(okuyucu["Price"].ToString());
                }
                okuyucu.Close();
            }

            lbltoplam.Text =toplam.ToString();
           
            ListViewSepet.DataSource = dtNew;
                ListViewSepet.DataBind();
               
                con.Close();

        }
        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSil_Click(object sender, CommandEventArgs e)

        {
           
            // SEPETTEN SİL------------------------------------------------------

            string kullaniciAdi = Session["Email"].ToString();

            int urunID = Convert.ToInt32(e.CommandArgument.ToString());

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");

            string sorgu = "DELETE FROM Baskets WHERE urunID=@urunID AND kullaniciAdi=@kullaniciAdi";
      
            SqlCommand komut = new SqlCommand(sorgu, con);

            con.Open();
            komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            komut.Parameters.AddWithValue("@urunID", urunID);
            
            komut.ExecuteNonQuery();
            MessageBox.Show("Sepetten silindi!");
            Response.Redirect("Sepetim.aspx");
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("credit.aspx");
        }
    }
}