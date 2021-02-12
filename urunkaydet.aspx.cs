using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace itpwebsite
{
    public partial class urunkaydet : System.Web.UI.Page
    {

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




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // ÜRÜN KAYDETME------------------------------------------------------

            string urunAdi = txturunadi.Text;

            if (FileUpload1.HasFile && FileUpload1.PostedFile.ContentLength < 5000000)
            {
                Bitmap EskiResim = new Bitmap(FileUpload1.PostedFile.InputStream); //Küçülmesini istedigimiz resmi FileUpload dan okuyoruz.
                int SabitBoyut = 200; // Kucuk Resmin Genisliği 100 olacak.
                Bitmap YeniKucukResim = YenidenBoyutlandir(EskiResim, SabitBoyut);
                string ResimAdi = urunAdi.Trim() + ".jpg"; //Her firmanın bir tane logosu olabilir.
                YeniKucukResim.Save(Server.MapPath("images/" + ResimAdi), ImageFormat.Jpeg); //Jpeg formatında resmi belirtilen yere kaydediyor..
                

                ////veritabanı bağlantısı
                ///
                int CategoryId = Convert.ToInt32(DropDownList1.SelectedItem.Value);


                MessageBox.Show(DropDownList1.SelectedItem.Text);
                MessageBox.Show(DropDownList1.SelectedItem.Value);

                string Image = $"~/images/{ResimAdi}";
                string Name = txturunadi.Text;
                string Description = txtaciklama.Text;
                int Price = Convert.ToInt32(txtfiyat.Text);
                int Stock = Convert.ToInt32(txtstok.Text);
                
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");
                
                string sorgu = "INSERT INTO Products (Name, CategoryId, Image, Description, Price, Stock) VALUES (@Name, @CategoryId, @Image, @Description, @Price, @Stock)";

                SqlCommand komut = new SqlCommand(sorgu, con);

                con.Open();
                komut.Parameters.AddWithValue("@CategoryId", CategoryId);
                komut.Parameters.AddWithValue("@Name", Name);
                komut.Parameters.AddWithValue("@Description", Description);
                komut.Parameters.AddWithValue("@Price", Price);
                komut.Parameters.AddWithValue("@Image", Image);
                komut.Parameters.AddWithValue("@Stock", Stock);

                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarı ile Eklendi");
                con.Close();
            }
            else
            {
                MessageBox.Show("KAYIT YAPILAMADI: Resim Seçilmemiş olabilir, Resim Boyutu 50 kB’dan büyük olabilir");
            }

            


        }


        //Resim Boyutu--------------------------------------------------------------------
        public Bitmap YenidenBoyutlandir(Bitmap EskiResim, int SabitBoyut)
        {
            using (Bitmap OriginalResim = EskiResim) //Orjinal resminımlarken ilk değer olarak EskiResmi içine atıyor ve öyle kullanıyor.
 {
                double ResimYukseklik = OriginalResim.Height;
                double ResimUzunluk = OriginalResim.Width;
                double oran = 0;
                if (ResimUzunluk > ResimYukseklik && ResimUzunluk >SabitBoyut) //Eğer resmin genişliği yüksekliginden büyükse veya 150 pxden   büyükse
 {
                    oran = ResimUzunluk / ResimYukseklik;
                    ResimUzunluk = SabitBoyut; //Resmin genişliğini 150        olarak atayacak ve aşağıda o genişliğe göre yüksekliği bulacak.
                     ResimYukseklik = SabitBoyut / oran;
                }
                else if (ResimYukseklik > ResimUzunluk && ResimYukseklik >SabitBoyut)
                    //Buradada yukarıdaki işlemin tersini yapıp genişliği   otomatik bulacak.
 {
                    oran = ResimYukseklik / ResimUzunluk;
                    ResimYukseklik = SabitBoyut;
                    ResimUzunluk = SabitBoyut / oran;
                }
                else if (ResimYukseklik == ResimUzunluk && ResimYukseklik >SabitBoyut)
                //Resmin boyutları eşitse
                {
                    ResimYukseklik = SabitBoyut;
                    ResimUzunluk = SabitBoyut;
                }
                Size YeniBoyut = new Size(Convert.ToInt32(ResimUzunluk),
               Convert.ToInt32(ResimYukseklik)); //Resmi yeniden boyutlandırıyoruz.
                Bitmap YeniBitmapResim = new Bitmap(OriginalResim,
               YeniBoyut);
                OriginalResim.Dispose(); //Orjinal resimden kurtuluyoruz...
                return YeniBitmapResim;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //ÜRÜN GÜNCELLEME-------------------------------------------------------
            string urunAdi = txturunadi.Text;

            if (FileUpload2.HasFile && FileUpload2.PostedFile.ContentLength < 5000000)
            {
                Bitmap EskiResim = new Bitmap(FileUpload2.PostedFile.InputStream); //Küçülmesini istedigimiz resmi FileUpload dan okuyoruz.
                int SabitBoyut = 200; // Kucuk Resmin Genisliği 100 olacak.
                Bitmap YeniKucukResim = YenidenBoyutlandir(EskiResim, SabitBoyut);
                string ResimAdi = urunAdi.Trim() + ".jpg"; //Her firmanın bir tane logosu olabilir.
                YeniKucukResim.Save(Server.MapPath("images/" + ResimAdi), ImageFormat.Jpeg); //Jpeg formatında resmi belirtilen yere kaydediyor..
                string Name = txtadcagir.Text;
                string Image2 = $"~/images/{ResimAdi}";
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");
                string sorgu = "UPDATE Products SET Name=@Name,Description=@Description,Price=@Price,Image=@Image,Stock=@Stock WHERE Name='" + txtadcagir.Text + "'";

            SqlCommand komut = new SqlCommand(sorgu, con);

                con.Open();
                komut.Parameters.AddWithValue("@CategoryId", txtkatg.Text);
                komut.Parameters.AddWithValue("@Name", txtadcagir);
                komut.Parameters.AddWithValue("@Description", txtacik);
                komut.Parameters.AddWithValue("@Price", txtfyt);
                komut.Parameters.AddWithValue("@Image", Image2);
                komut.Parameters.AddWithValue("@Stock", txtstk);
                MessageBox.Show(Name + "Güncellendi");
            }

            else
            {
                MessageBox.Show("KAYIT YAPILAMADI: Resim Seçilmemiş olabilir, Resim Boyutu 50 kB’dan büyük olabilir");
            }

        }
        //Ürün Çağırma-----------------------------------------------------------------------------------------------
        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7ENL5T\SQLEXPRESS;Initial Catalog=AndEticaretDB;Integrated Security=True");

            con.Open();
            
            string Name = Convert.ToString(txtadcagir.Text);
            //Sorgu (Emir Listesi)
            string Sorgu = "SELECT * FROM Products WHERE Name=@Name";
            //Komut Nesnesi (Şöför)
            SqlCommand komut = new SqlCommand(Sorgu, con);
            
            komut.Parameters.AddWithValue("@Name", Name);
            //Okuyucu nesnesi (Kamyon)
            SqlDataReader Okuyucu = komut.ExecuteReader();
            //Bilgiler Sayfaya yükleniyor
            while (Okuyucu.Read() == true)
            {
                string ResimAdi = Okuyucu["Image"].ToString();
                Image1.ImageUrl = $"~/images/{ResimAdi}"; /*"images/" + ResimAdi;*/
                txtadcagir.Text = Okuyucu["Name"].ToString();
                txtacik.Text = Okuyucu["Description"].ToString();
                txtfyt.Text = Okuyucu["Price"].ToString();
                txtkatg.Text = Okuyucu["CategoryId"].ToString();
                txtstk.Text = Okuyucu["Stock"].ToString();
                            }
            MessageBox.Show(Name + "Getirildi.");
            con.Close();

        }
    }

}







