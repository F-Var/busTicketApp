using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using busTicketApp.Model;

namespace busTicketApp
{
    public partial class Form1 : Form
    {

        //entity çağırdık
        BiletEntities db = new BiletEntities();

        public Form1()
        {
            InitializeComponent();
        }

        //easteregg
        int sayi = 0;
        private void label3_Click(object sender, EventArgs e)
        {
            //int sayi2 = sayi;
            sayi++;
            if (sayi == 13)
            {
                this.BackgroundImage = busTicketApp.Properties.Resources.tur;
                checkBox1.Visible = true;
            }
        }
        //easteregg off
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            checkBox1.Visible = false;
        }

        //kayar yazı
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = label3.Text.Substring(1) + label3.Text.Substring(0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;//kayar yazı tick başı

            //combobox şehir listeleme
            List<sehirMesafe> sehirListesi = db.sehirMesafe.ToList();
            List<sehirMesafe> sehirListesi2 = db.sehirMesafe.ToList();
            List<sehirMesafe> sehirEklemeListesi = db.sehirMesafe.ToList();
            List<sehirMesafe> sehirEklemeListesi2 = db.sehirMesafe.ToList();
            cb_nereden.DataSource = sehirListesi;
            cb_nereye.DataSource = sehirListesi2;
            cbGuzergahNereden.DataSource = sehirEklemeListesi;
            cbGuzergahNereye.DataSource = sehirEklemeListesi2;

            //sehirListesi.Where(ilAdi => sehirListesi.Contains(ilAdi)).ToList();

            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "NEREDEN";
            dataGridView1.Columns[1].Name = "NEREYE";
            dataGridView1.Columns[2].Name = "DURAKLAR";
            dataGridView1.Columns[3].Name = "Otobüs Türü";
            dataGridView1.Columns[4].Name = "Tarife";
            dataGridView1.Columns[5].Name = "Fiyat"; //km başı 0,57 kr
            dataGridView1.Columns[6].Name = "Tarih";
            dataGridView1.Columns[7].Name = "Saat";
            dataGridView1.Columns[8].Name = "KM";
            var deneme = 3;
        }

        private void btn_seferGetir_Click(object sender, EventArgs e)
        {
            //datagrid e seçilen şehirleri yazma
            dataGridView1.Rows[0].Cells[0].Value = cb_nereden.Text;
            dataGridView1.Rows[0].Cells[1].Value = cb_nereye.Text;

            //sql den veri çekip mesafeyi listeye aktardık, listeden de diziye aktardık nereden şehrin indis numarasına göre satırı diziye aktardık
            //seçilen nereden ile satırdaki km leri split ile bölüp diziye aktardık, o dizidende nereye değişkenine gidilecek yerin indis numarası ile
            //iki şehrin mesafesini aldık
            //List<string> mesafeList = new List<string>();
            //SqlConnection baglanti = new SqlConnection();
            //baglanti.ConnectionString = @"Server=DESKTOP-GJ048IL; Database = biletVeritabani; User Id =sa; Password ='3e/\6;1Zx?'";
            //SqlCommand komut = new SqlCommand("Select mesafe from sehirMesafe", baglanti);
            //baglanti.Open();
            //SqlDataReader dr = komut.ExecuteReader();
            //while (dr.Read())
            //{
            //    mesafeList.Add(dr["mesafe"].ToString());
            //}
            //baglanti.Close();

            //try
            //{
            //    //km verisi alma ve yazdırma
            //    string[] tamMesafeDizi = mesafeList.ToArray();
            //    string nereden;
            //    nereden = tamMesafeDizi[cb_nereden.SelectedIndex];
            //    string[] mesafeDizi = nereden.Split('-');
            //    string nereye = mesafeDizi[cb_nereye.SelectedIndex];
            //    dataGridView1.Rows[0].Cells[8].Value = nereye;

            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Hatalı şehir girdiniz, Lütfen şehri listeden seçiniz.", "HATALI GİRİŞ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //}

            //800 den yüksek veya 400 den az mesafe olanlar direk gitsin fakat 800 den düşük 400 den de büyük olanlar aktarmalı gitsin
            //150 den küçük ve 450 den büyük direk gitsin 150 ve 450 arası aktarmalı gitsin


            //var g = db.guzergah.ToList();//.Where(g => g.nereden == cb_nereden.Text).ToList();

            //var gx = (from x in g
            //          where x.nereden.Contains("an")
            //          select x).ToList();



            int Gnereden = (int)cb_nereden.SelectedValue;
            int Gnereye = (int)cb_nereye.SelectedValue;
            var tumGuzergahlar = db.guzergah.ToList();
            var uyanlar = tumGuzergahlar.Where(x => x.nereden == Gnereden && x.nereye == Gnereye).ToList();
            var uyanlar2 = tumGuzergahlar.Where(x => x.durak.Contains(Gnereden.ToString()) && x.durak.Contains(Gnereye.ToString())).ToList();
            uyanlar.AddRange(uyanlar2);
            dataGridView1.DataSource = uyanlar;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {   //select Adana from Sehirler where sehirAdi='Adıyaman' örnek olarak adıyaman adana arasını bu şekilde aldım
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = @"Server=DESKTOP-GJ048IL; Database = biletVeritabani; User Id =sa; Password ='3e/\6;1Zx?'";//Ne kadar @ işaretide koysam burası hata verdi sebebi şifre kısmını tek tırnağa alamam gerekiyordu :(
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.CommandText = textBox1.Text;
                komut.Connection = baglanti;
                DataTable tb = new DataTable();
                tb.Load(komut.ExecuteReader());
                dataGridView1.DataSource = tb;
                baglanti.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "o shit here we go again..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void koltukDoldur(string duzen) {

            yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;
                    if (btn.Tag != "kDeger")
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls.Remove(ctrl);
                        goto yavaslat;
                    }
                }
            }

            int sayac = 0;
            int koltukNo = 1;
            for (int i = 0; i < duzen.Length/5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    string metin = duzen[sayac].ToString();
                    sayac++;

                    Button koltuk = new Button();
                    koltuk.Height = koltuk.Width = 40;
                    koltuk.Top = 40 + (i*45);
                    koltuk.Left = 570 + (j*45);
                    if (metin != "K") goto gecis;
                    koltuk.Text = koltukNo.ToString();
                    koltukNo++;
                    gecis:
                    koltuk.Tag = "kDeger";
                    if (metin == "B") continue;
                    if (metin == "M")
                    {
                        koltuk.Text = "M";
                        koltuk.Enabled = false;
                    }
                    else if (metin == "S")
                    {
                        koltuk.Text = "S";
                        koltuk.Enabled= false;
                    }
                    this.Controls.Add(koltuk);
                }
            }
        }


        private void btnGuzergah_Click(object sender, EventArgs e)
        {
            if (gB_guzergah.Visible == true)
            {
                gB_guzergah.Visible = false;
            }
            else
            {
                gB_guzergah.Visible = true;
            }
        }

        private void btnGuzergah_VisibleChanged(object sender, EventArgs e)
        {
            if (gB_guzergah.Visible == true)
            {
                btnGuzergah.ForeColor = System.Drawing.SystemColors.ControlText;
                btnGuzergah.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void btnGuzergah_MouseMove(object sender, MouseEventArgs e)
        {
                btnGuzergah.ForeColor = System.Drawing.SystemColors.ControlText;
                btnGuzergah.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnGuzergah_MouseLeave(object sender, EventArgs e)
        {
            if (gB_guzergah.Visible == false)
            {
                btnGuzergah.ForeColor = System.Drawing.Color.Silver;
                btnGuzergah.BackColor = System.Drawing.Color.Transparent;
            }
        }

        /*
         * IsSeperator,IsWhitepace->boşluk
         * IsLetter->harf
         * IsNumber->sayı(½ buda dahil) tam rakam için IsDigit kullanmak gerek
         * IsControl->backspace
         * IsSymbol->sadece semboller
         * IsDigit->ondalıklı ama normal sayı yazıyor
        */ 
        private void tbGuzergahDurak_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'); //tire eşit değilsede çift tırnak yerine tek tırnak kullandık çünkü 
        }

        private void btnGuzergahKayit_Click(object sender, EventArgs e)
        {
            guzergah yeniGuzargah = new guzergah();
            yeniGuzargah.guzergah_id = 0;
            yeniGuzargah.nereden = Convert.ToInt32(cbGuzergahNereden.SelectedValue);
            yeniGuzargah.nereye = Convert.ToInt32(cbGuzergahNereye.SelectedValue);
            yeniGuzargah.durak = tbGuzergahDurak.Text;
            db.Entry(yeniGuzargah).State = System.Data.EntityState.Added;
            db.SaveChanges();
            MessageBox.Show("Güzergah Kaydedildi","KAYDETME BAŞARILI",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        int plakaDeger;
        private void cb_nereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            plakaDeger = cb_nereden.SelectedIndex + 1;
            label7.Text = "> " + plakaDeger.ToString();
        }

        private void cb_nereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            plakaDeger = cb_nereye.SelectedIndex + 1;
            label8.Text = "> " + plakaDeger.ToString();
        }

        private void cbGuzergahNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            plakaDeger = cbGuzergahNereden.SelectedIndex + 1;
            label9.Text = "> " + plakaDeger.ToString();
        }

        private void cbGuzergahNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            plakaDeger = cbGuzergahNereye.SelectedIndex + 1;
            label10.Text = "> " + plakaDeger.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // Display the date as "2012-12-28".  
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            label11.Text = dateTimePicker1.Text.ToString();


            ///////////////////////////////////
            yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;
                    if (btn.Tag != "kDeger")
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls.Remove(ctrl);
                        goto yavaslat;
                    }
                }
            }
            ///////////////////////////////////

        }

        private void button3_Click(object sender, EventArgs e)
        {
            koltukDoldur("SBBBMBBBBBKKBKKKKBKKKKBKKKKBKKKKBKKKKBBBKKBKKKKBKKKKBKKKKBKK");
        }
    }
}
