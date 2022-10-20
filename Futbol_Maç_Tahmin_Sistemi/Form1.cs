using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Futbol_Maç_Tahmin_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-48MHJFV;Initial Catalog=dbo_Futbol_Maç_Tahmin_Sistemi;Integrated Security=True");
        public string takim_ismi_;
        


        private void button1_Click(object sender, EventArgs e)
        {   
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into Maclar values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21)", baglan);
            komut.Parameters.AddWithValue("@p1", ilk_takim.Text);
            komut.Parameters.AddWithValue("@p2", ikinci_takim.Text);
            komut.Parameters.AddWithValue("@p3", int.Parse(ilk_takim_gol.Text));
            komut.Parameters.AddWithValue("@p4", int.Parse(ikinci_takim_gol.Text));
            komut.Parameters.AddWithValue("@p5", int.Parse(ilk_takim_toplaoynama.Text));
            komut.Parameters.AddWithValue("@p6", int.Parse(ikinci_takim_toplaoynama.Text));
            komut.Parameters.AddWithValue("@p7", int.Parse(ilk_takim_toplamsut.Text));
            komut.Parameters.AddWithValue("@p8", int.Parse(ikinci_takim_toplamsut.Text));
            komut.Parameters.AddWithValue("@p9", int.Parse(ilk_takim_isabetlisut.Text));
            komut.Parameters.AddWithValue("@p10", int.Parse(ikinci_takim_isabetlisut.Text));
            komut.Parameters.AddWithValue("@p11", int.Parse(ilk_takim_pasbasari.Text));
            komut.Parameters.AddWithValue("@p12", int.Parse(ikinci_takim_pasbasari.Text));
            komut.Parameters.AddWithValue("@p13", int.Parse(ilk_takim_korner.Text));
            komut.Parameters.AddWithValue("@p14", int.Parse(ikinci_takim_korner.Text));
            komut.Parameters.AddWithValue("@p15", int.Parse(ilk_takim_orta.Text));
            komut.Parameters.AddWithValue("@p16", int.Parse(ikinci_takim_orta.Text));
            komut.Parameters.AddWithValue("@p17", int.Parse(ilk_takim_faul.Text));
            komut.Parameters.AddWithValue("@p18", int.Parse(ikinci_takim_faul.Text));
            komut.Parameters.AddWithValue("@p19", int.Parse(ilk_takim_ofsayt.Text));
            komut.Parameters.AddWithValue("@p20", int.Parse(ikinci_takim_ofsayt.Text));
            komut.Parameters.AddWithValue("@p21", kazanan.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Maç Eklendi ");
            ilk_takim.Text = "";
            ikinci_takim.Text = "";
            ilk_takim_gol.Text = "";
            ikinci_takim_gol.Text = "";
            ilk_takim_toplaoynama.Text = "";
            ikinci_takim_toplaoynama.Text = "";
            ilk_takim_toplamsut.Text = "";
            ikinci_takim_toplamsut.Text = "";
            ilk_takim_isabetlisut.Text = "";
            ikinci_takim_isabetlisut.Text = "";
            ilk_takim_pasbasari.Text = "";
            ikinci_takim_pasbasari.Text = "";
            ilk_takim_korner.Text = "";
            ikinci_takim_korner.Text = "";
            ilk_takim_orta.Text = "";
            ikinci_takim_orta.Text = "";
            ilk_takim_faul.Text = "";
            ikinci_takim_faul.Text = "";
            ilk_takim_ofsayt.Text = "";
            ikinci_takim_ofsayt.Text = "";
            kazanan.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            Takim_Bilgileri tb = new Takim_Bilgileri();
            tb.takim_ismi = takim_ismi.Text;
            tb.Show();
            
    }

        private void button2_Click(object sender, EventArgs e)
        {
            Tahmin_Yap ty = new Tahmin_Yap();
            ty.takim_1 = ilk_takim_tahmin.Text;
            ty.takim_2 = ikinci_takim_tahmin.Text;
            ty.Show();
        }
    }
}
