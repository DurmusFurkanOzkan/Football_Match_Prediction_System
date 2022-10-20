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
   
    public partial class Tahmin_Yap : Form
    {       
        public Tahmin_Yap()
        {
            InitializeComponent();
        }
        public class İlkTakim
        {
            public string Name { get; set; }

        }
        public class İkinciTakim
        {
            public string Name { get; set; }

        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-48MHJFV;Initial Catalog=dbo_Futbol_Maç_Tahmin_Sistemi;Integrated Security=True");
        public string takim_1;
        public string takim_2;
        double ilk_takim_gol;
        double ilk_takim_toplaoynama;
        double ilk_takim_toplamsut;
        double ilk_takim_isabetlisut;
        double ilk_takim_pasbasari;
        double ilk_takim_korner;
        double ilk_takim_orta;
        double ilk_takim_faul;
        double ilk_takim_ofsayt;
        double ikinci_takim_gol;
        double ikinci_takim_toplaoynama;
        double ikinci_takim_toplamsut;
        double ikinci_takim_isabetlisut;
        double ikinci_takim_pasbasari;
        double ikinci_takim_korner;
        double ikinci_takim_orta;
        double ikinci_takim_faul;
        double ikinci_takim_ofsayt;
        List<İlkTakim> ilktakim = new List<İlkTakim>();
        List<İkinciTakim> ikincitakim = new List<İkinciTakim>();
        private void Tahmin_Yap_Load(object sender, EventArgs e)
        {   
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select CAST(AVG(İlk_takim_gol) AS DECIMAL(10,2)),CAST(AVG(İlk_takim_toplaoynama) AS DECIMAL(10,2)),CAST(AVG(İlk_takim_toplamşut) AS DECIMAL(10,2)),CAST(AVG(İlk_takim_isabetli_şut) AS DECIMAL(10,2)),CAST(AVG(İlk_takim_pasbaşari) AS DECIMAL(10,2)),CAST(AVG(İlk_takim_korner)AS DECIMAL(10,2)),CAST(AVG(İlk_takim_orta)AS DECIMAL(10,2)),CAST(AVG(İlk_takim_faul)AS DECIMAL(10,2)),CAST(AVG(İlk_takim_ofsayt)AS DECIMAL(10,2)) from Maclar where Takim_adi=@p1 ", baglan);
            komut.Parameters.AddWithValue("@p1", takim_1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {   
                ilk_takim_gol = double.Parse(dr[0].ToString());
                ilk_takim_toplaoynama= double.Parse(dr[1].ToString());
                ilk_takim_toplamsut= double.Parse(dr[2].ToString());
                ilk_takim_isabetlisut= double.Parse(dr[3].ToString());
                ilk_takim_pasbasari= double.Parse(dr[4].ToString());
                ilk_takim_korner= double.Parse(dr[5].ToString());
                ilk_takim_orta= double.Parse(dr[6].ToString());
                ilk_takim_faul= double.Parse(dr[7].ToString());
                ilk_takim_ofsayt = double.Parse(dr[8].ToString());
            }
            toplam_gol.Text = ilk_takim_gol.ToString();
            baglan.Close();
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Select CAST(AVG(İlk_takim_gol) AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_toplaoynama) AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_toplamşut) AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_isabetli_şut) AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_pasbaşari) AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_korner)AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_orta)AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_faul)AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_ofsayt)AS DECIMAL(10, 2)) from Maclar where Maç_yaptiği_takim=@p2 ", baglan);
            komut2.Parameters.AddWithValue("@p2", takim_1);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                ilk_takim_gol = (ilk_takim_gol+ double.Parse(dr2[0].ToString()))/2;
                ilk_takim_toplaoynama = (ilk_takim_toplaoynama+ double.Parse(dr2[1].ToString()))/2;
                ilk_takim_toplamsut = (ilk_takim_toplamsut+ double.Parse(dr2[2].ToString()))/2;
                ilk_takim_isabetlisut = (ilk_takim_isabetlisut+ double.Parse(dr2[3].ToString()))/2;
                ilk_takim_pasbasari = (ilk_takim_pasbasari+ double.Parse(dr2[4].ToString()))/2;
                ilk_takim_korner = (ilk_takim_korner+ double.Parse(dr2[5].ToString()))/2;
                ilk_takim_orta = (ilk_takim_orta+ double.Parse(dr2[6].ToString()))/2;
                ilk_takim_faul = (ilk_takim_faul+ double.Parse(dr2[7].ToString()))/2;
                ilk_takim_ofsayt = (ilk_takim_ofsayt+ double.Parse(dr2[8].ToString()))/2;
            }
            baglan.Close();
            baglan.Open();
            SqlCommand komut3 = new SqlCommand("Select CAST(AVG(İkinci_takim_gol) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_toplaoynama) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_toplamşut) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_isabetli_şut) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_pasbaşari) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_korner)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_orta)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_faul)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_ofsayt)AS DECIMAL(10, 2)) from Maclar where Takim_adi=@p3  ", baglan);
            komut3.Parameters.AddWithValue("@p3", takim_2);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                ikinci_takim_gol = double.Parse(dr3[0].ToString());
                ikinci_takim_toplaoynama = double.Parse(dr3[1].ToString());
                ikinci_takim_toplamsut = double.Parse(dr3[2].ToString());
                ikinci_takim_isabetlisut = double.Parse(dr3[3].ToString());
                ikinci_takim_pasbasari = double.Parse(dr3[4].ToString());
                ikinci_takim_korner = double.Parse(dr3[5].ToString());
                ikinci_takim_orta = double.Parse(dr3[6].ToString());
                ikinci_takim_faul = double.Parse(dr3[7].ToString());
                ikinci_takim_ofsayt = double.Parse(dr3[8].ToString());
            }
            baglan.Close();

            baglan.Open();
            SqlCommand komut4 = new SqlCommand("Select CAST(AVG(İkinci_takim_gol) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_toplaoynama) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_toplamşut) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_isabetli_şut) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_pasbaşari) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_korner)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_orta)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_faul)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_ofsayt)AS DECIMAL(10, 2)) from Maclar where Maç_yaptiği_takim=@p4", baglan);
            komut4.Parameters.AddWithValue("@p4", takim_2);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                ikinci_takim_gol = (ikinci_takim_gol+double.Parse(dr4[0].ToString()))/2;
                ikinci_takim_toplaoynama = (ikinci_takim_toplaoynama+double.Parse(dr4[1].ToString()))/2;
                ikinci_takim_toplamsut = (ikinci_takim_toplamsut+double.Parse(dr4[2].ToString()))/2;
                ikinci_takim_isabetlisut = (ikinci_takim_isabetlisut+double.Parse(dr4[3].ToString()))/2;
                ikinci_takim_pasbasari = (ikinci_takim_pasbasari+double.Parse(dr4[4].ToString()))/2;
                ikinci_takim_korner = (ikinci_takim_korner+double.Parse(dr4[5].ToString()))/2;
                ikinci_takim_orta = (ikinci_takim_orta+double.Parse(dr4[6].ToString()))/2;
                ikinci_takim_faul = (ikinci_takim_faul+double.Parse(dr4[7].ToString()))/2;
                ikinci_takim_ofsayt = (ikinci_takim_ofsayt+double.Parse(dr4[8].ToString()))/2;
            }
            baglan.Close();


            baglan.Open();
            SqlCommand komut5 = new SqlCommand("Select kazanan from Maclar where Takim_adi=@p5", baglan);
            komut5.Parameters.AddWithValue("@p5", takim_1);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                İlkTakim ilkTakim = new İlkTakim();
                ilkTakim.Name = dr5[0].ToString();
                ilktakim.Add(ilkTakim);
            }
            baglan.Close();

            baglan.Open();
            SqlCommand komut6 = new SqlCommand("Select kazanan from Maclar where Maç_yaptiği_takim=@p6", baglan);
            komut6.Parameters.AddWithValue("@p6", takim_1);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                İlkTakim ilkTakim = new İlkTakim();
                ilkTakim.Name = dr6[0].ToString();
                ilktakim.Add(ilkTakim);
            }
            baglan.Close();

            baglan.Open();
            SqlCommand komut7 = new SqlCommand("Select kazanan from Maclar where Takim_adi=@p7", baglan);
            komut7.Parameters.AddWithValue("@p7", takim_2);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                İkinciTakim İkinciTakim = new İkinciTakim();
                İkinciTakim.Name = dr7[0].ToString();
                ikincitakim.Add(İkinciTakim);
            }
            baglan.Close();

            baglan.Open();
            SqlCommand komut8 = new SqlCommand("Select kazanan from Maclar where Maç_yaptiği_takim=@p8", baglan);
            komut8.Parameters.AddWithValue("@p8", takim_2);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                İkinciTakim İkinciTakim = new İkinciTakim();
                İkinciTakim.Name = dr8[0].ToString();
                ikincitakim.Add(İkinciTakim);
            }
            baglan.Close();

            //Algoritma Baslangıcı
            int counter_ilktakim =0;
            double toplam_ilktakim ;
            double toplam_gol_araligi = 0;
            double toplam_korner_araligi = 0;
            foreach (İlkTakim aPart in ilktakim)
            {   if (aPart.Name.ToString().Equals(takim_1))
                    counter_ilktakim++;
            }
            toplam_gol_araligi = toplam_gol_araligi + ilk_takim_gol;
            toplam_korner_araligi = toplam_korner_araligi + ilk_takim_korner;
            counter_ilktakim = counter_ilktakim * 10;
            ilk_takim_gol = ilk_takim_gol * 9;
            ilk_takim_toplamsut = ilk_takim_toplamsut * 8;
            ilk_takim_isabetlisut = ilk_takim_isabetlisut * 7;
            ilk_takim_toplaoynama = ilk_takim_toplaoynama * 6;
            ilk_takim_korner = ilk_takim_korner * 5;
            ilk_takim_pasbasari = ilk_takim_pasbasari * 4;
            ilk_takim_orta = ilk_takim_orta * 3;
            ilk_takim_faul = ilk_takim_faul * (-1);
            ilk_takim_ofsayt = ilk_takim_ofsayt * (-1);
            toplam_ilktakim = counter_ilktakim+ilk_takim_gol + ilk_takim_toplamsut + ilk_takim_isabetlisut + ilk_takim_toplaoynama + ilk_takim_korner + ilk_takim_pasbasari + ilk_takim_orta + ilk_takim_faul + ilk_takim_ofsayt;

            int counter_ikincitakim = 0;
            double toplam_ikincitakim ;
            foreach (İkinciTakim aPart in ikincitakim)
            {
                if (aPart.Name.ToString().Equals(takim_2))
                    counter_ikincitakim++;
            }
            counter_ikincitakim = counter_ikincitakim * 10;
            toplam_gol_araligi = toplam_gol_araligi + ikinci_takim_gol;
            toplam_korner_araligi = toplam_korner_araligi + ikinci_takim_korner;
            ikinci_takim_gol = ikinci_takim_gol * 9;
            ikinci_takim_toplamsut = ikinci_takim_toplamsut * 8;
            ikinci_takim_isabetlisut = ikinci_takim_isabetlisut * 7;
            ikinci_takim_toplaoynama = ikinci_takim_toplaoynama * 6;
            ikinci_takim_korner = ikinci_takim_korner * 5;
            ikinci_takim_pasbasari = ikinci_takim_pasbasari * 4;
            ikinci_takim_orta = ikinci_takim_orta * 3;
            ikinci_takim_faul = ikinci_takim_faul * (-1);
            ikinci_takim_ofsayt = ikinci_takim_ofsayt * (-1);
            toplam_ikincitakim = counter_ikincitakim+ikinci_takim_gol + ikinci_takim_toplamsut + ikinci_takim_isabetlisut + ikinci_takim_toplaoynama + ikinci_takim_korner + ikinci_takim_pasbasari + ikinci_takim_orta + ikinci_takim_faul + ikinci_takim_ofsayt;
            double beraberlik = (toplam_ilktakim + toplam_ikincitakim) / 2;
            double total_toplam = 100 / (toplam_ilktakim + toplam_ikincitakim + beraberlik);
            ev_sahibi_kazanir.Text = "%"+(total_toplam * toplam_ilktakim).ToString();
            berabere.Text = "%"+(total_toplam * beraberlik).ToString();
            deplasman.Text = "%"+(total_toplam * toplam_ikincitakim).ToString();


            //toplam_gol.Text =(toplam_gol_araligi-1).ToString()+"-"+ (toplam_gol_araligi + 1).ToString();
            korner.Text = (toplam_korner_araligi-1).ToString()+"-"+ (toplam_korner_araligi + 1).ToString();
           
            bool flag = false;
            if((ilk_takim_gol/9>=1 && ikinci_takim_gol/9>=0.5) || (ilk_takim_gol / 9 >= 0.5 && ikinci_takim_gol / 9 >= 1))
            {
                flag = true;
            }
            if (flag == true)
                karsılıklı_gol.Text = "OLUR";
            else
                karsılıklı_gol.Text = "OLMAZ";

            Takim1.Text = takim_1.ToString();
            Takim2.Text = takim_2.ToString();


        }
    }
}
