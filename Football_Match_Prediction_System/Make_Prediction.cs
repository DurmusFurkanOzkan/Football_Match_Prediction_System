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
   
    public partial class Make_Prediction : Form
    {       
        public Make_Prediction()
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
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-48MHJFV;Initial Catalog=dbo_Futbol_Maç_Tahmin_Sistemi;Integrated Security=True");
        public string team_1;
        public string team_2;
        double first_team_goal;
        double first_team_ball_game;
        double first_team_total_shot;
        double first_team_shot_on_target;
        double first_team_pass;
        double first_team_korner;
        double first_team_middle;
        double first_team_faul;
        double first_team_offside;
        double second_team_goal;
        double second_team_ball_game;
        double second_team_total_shot;
        double second_team_shot_on_target;
        double second_team_pass;
        double second_team_korner;
        double second_team_middle;
        double second_team_faul;
        double second_team_offside;
        List<İlkTakim> ilktakim = new List<İlkTakim>();
        List<İkinciTakim> ikincitakim = new List<İkinciTakim>();
        private void Tahmin_Yap_Load(object sender, EventArgs e)
        {   
            connection.Open();
            SqlCommand komut = new SqlCommand("Select CAST(AVG(İlk_takim_gol) AS DECIMAL(10,2)),CAST(AVG(İlk_takim_toplaoynama) AS DECIMAL(10,2)),CAST(AVG(İlk_takim_toplamşut) AS DECIMAL(10,2)),CAST(AVG(İlk_takim_isabetli_şut) AS DECIMAL(10,2)),CAST(AVG(İlk_takim_pasbaşari) AS DECIMAL(10,2)),CAST(AVG(İlk_takim_korner)AS DECIMAL(10,2)),CAST(AVG(İlk_takim_orta)AS DECIMAL(10,2)),CAST(AVG(İlk_takim_faul)AS DECIMAL(10,2)),CAST(AVG(İlk_takim_ofsayt)AS DECIMAL(10,2)) from Maclar where Takim_adi=@p1 ", connection);
            komut.Parameters.AddWithValue("@p1", team_1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {   
                first_team_goal = double.Parse(dr[0].ToString());
                first_team_ball_game= double.Parse(dr[1].ToString());
                first_team_total_shot= double.Parse(dr[2].ToString());
                first_team_shot_on_target= double.Parse(dr[3].ToString());
                first_team_pass= double.Parse(dr[4].ToString());
                first_team_korner= double.Parse(dr[5].ToString());
                first_team_middle= double.Parse(dr[6].ToString());
                first_team_faul= double.Parse(dr[7].ToString());
                first_team_offside = double.Parse(dr[8].ToString());
            }
            total_goal.Text = first_team_goal.ToString();
            connection.Close();
            connection.Open();
            SqlCommand komut2 = new SqlCommand("Select CAST(AVG(İlk_takim_gol) AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_toplaoynama) AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_toplamşut) AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_isabetli_şut) AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_pasbaşari) AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_korner)AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_orta)AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_faul)AS DECIMAL(10, 2)), CAST(AVG(İlk_takim_ofsayt)AS DECIMAL(10, 2)) from Maclar where Maç_yaptiği_takim=@p2 ", connection);
            komut2.Parameters.AddWithValue("@p2", team_1);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                first_team_goal = (first_team_goal+ double.Parse(dr2[0].ToString()))/2;
                first_team_ball_game = (first_team_ball_game+ double.Parse(dr2[1].ToString()))/2;
                first_team_total_shot = (first_team_total_shot+ double.Parse(dr2[2].ToString()))/2;
                first_team_shot_on_target = (first_team_shot_on_target+ double.Parse(dr2[3].ToString()))/2;
                first_team_pass = (first_team_pass+ double.Parse(dr2[4].ToString()))/2;
                first_team_korner = (first_team_korner+ double.Parse(dr2[5].ToString()))/2;
                first_team_middle = (first_team_middle+ double.Parse(dr2[6].ToString()))/2;
                first_team_faul = (first_team_faul+ double.Parse(dr2[7].ToString()))/2;
                first_team_offside = (first_team_offside+ double.Parse(dr2[8].ToString()))/2;
            }
            connection.Close();
            connection.Open();
            SqlCommand komut3 = new SqlCommand("Select CAST(AVG(İkinci_takim_gol) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_toplaoynama) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_toplamşut) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_isabetli_şut) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_pasbaşari) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_korner)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_orta)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_faul)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_ofsayt)AS DECIMAL(10, 2)) from Maclar where Takim_adi=@p3  ", connection);
            komut3.Parameters.AddWithValue("@p3", team_2);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                second_team_goal = double.Parse(dr3[0].ToString());
                second_team_ball_game = double.Parse(dr3[1].ToString());
                second_team_total_shot = double.Parse(dr3[2].ToString());
                second_team_shot_on_target = double.Parse(dr3[3].ToString());
                second_team_pass = double.Parse(dr3[4].ToString());
                second_team_korner = double.Parse(dr3[5].ToString());
                second_team_middle = double.Parse(dr3[6].ToString());
                second_team_faul = double.Parse(dr3[7].ToString());
                second_team_offside = double.Parse(dr3[8].ToString());
            }
            connection.Close();

            connection.Open();
            SqlCommand komut4 = new SqlCommand("Select CAST(AVG(İkinci_takim_gol) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_toplaoynama) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_toplamşut) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_isabetli_şut) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_pasbaşari) AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_korner)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_orta)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_faul)AS DECIMAL(10, 2)), CAST(AVG(İkinci_takim_ofsayt)AS DECIMAL(10, 2)) from Maclar where Maç_yaptiği_takim=@p4", connection);
            komut4.Parameters.AddWithValue("@p4", team_2);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                second_team_goal = (second_team_goal+double.Parse(dr4[0].ToString()))/2;
                second_team_ball_game = (second_team_ball_game+double.Parse(dr4[1].ToString()))/2;
                second_team_total_shot = (second_team_total_shot+double.Parse(dr4[2].ToString()))/2;
                second_team_shot_on_target = (second_team_shot_on_target+double.Parse(dr4[3].ToString()))/2;
                second_team_pass = (second_team_pass+double.Parse(dr4[4].ToString()))/2;
                second_team_korner = (second_team_korner+double.Parse(dr4[5].ToString()))/2;
                second_team_middle = (second_team_middle+double.Parse(dr4[6].ToString()))/2;
                second_team_faul = (second_team_faul+double.Parse(dr4[7].ToString()))/2;
                second_team_offside = (second_team_offside+double.Parse(dr4[8].ToString()))/2;
            }
            connection.Close();


            connection.Open();
            SqlCommand komut5 = new SqlCommand("Select kazanan from Maclar where Takim_adi=@p5", connection);
            komut5.Parameters.AddWithValue("@p5", team_1);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                İlkTakim ilkTakim = new İlkTakim();
                ilkTakim.Name = dr5[0].ToString();
                ilktakim.Add(ilkTakim);
            }
            connection.Close();

            connection.Open();
            SqlCommand komut6 = new SqlCommand("Select kazanan from Maclar where Maç_yaptiği_takim=@p6", connection);
            komut6.Parameters.AddWithValue("@p6", team_1);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                İlkTakim ilkTakim = new İlkTakim();
                ilkTakim.Name = dr6[0].ToString();
                ilktakim.Add(ilkTakim);
            }
            connection.Close();

            connection.Open();
            SqlCommand komut7 = new SqlCommand("Select kazanan from Maclar where Takim_adi=@p7", connection);
            komut7.Parameters.AddWithValue("@p7", team_2);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                İkinciTakim İkinciTakim = new İkinciTakim();
                İkinciTakim.Name = dr7[0].ToString();
                ikincitakim.Add(İkinciTakim);
            }
            connection.Close();

            connection.Open();
            SqlCommand komut8 = new SqlCommand("Select kazanan from Maclar where Maç_yaptiği_takim=@p8", connection);
            komut8.Parameters.AddWithValue("@p8", team_2);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                İkinciTakim İkinciTakim = new İkinciTakim();
                İkinciTakim.Name = dr8[0].ToString();
                ikincitakim.Add(İkinciTakim);
            }
            connection.Close();

            //Algoritma Baslangıcı
            int counter_ilktakim =0;
            double toplam_ilktakim ;
            double toplam_gol_araligi = 0;
            double toplam_korner_araligi = 0;
            foreach (İlkTakim aPart in ilktakim)
            {   if (aPart.Name.ToString().Equals(team_1))
                    counter_ilktakim++;
            }
            toplam_gol_araligi = toplam_gol_araligi + first_team_goal;
            toplam_korner_araligi = toplam_korner_araligi + first_team_korner;
            counter_ilktakim = counter_ilktakim * 10;
            first_team_goal = first_team_goal * 9;
            first_team_total_shot = first_team_total_shot * 8;
            first_team_shot_on_target = first_team_shot_on_target * 7;
            first_team_ball_game = first_team_ball_game * 6;
            first_team_korner = first_team_korner * 5;
            first_team_pass = first_team_pass * 4;
            first_team_middle = first_team_middle * 3;
            first_team_faul = first_team_faul * (-1);
            first_team_offside = first_team_offside * (-1);
            toplam_ilktakim = counter_ilktakim+first_team_goal + first_team_total_shot + first_team_shot_on_target + first_team_ball_game + first_team_korner + first_team_pass + first_team_middle + first_team_faul + first_team_offside;

            int counter_ikincitakim = 0;
            double toplam_ikincitakim ;
            foreach (İkinciTakim aPart in ikincitakim)
            {
                if (aPart.Name.ToString().Equals(team_2))
                    counter_ikincitakim++;
            }
            counter_ikincitakim = counter_ikincitakim * 10;
            toplam_gol_araligi = toplam_gol_araligi + second_team_goal;
            toplam_korner_araligi = toplam_korner_araligi + second_team_korner;
            second_team_goal = second_team_goal * 9;
            second_team_total_shot = second_team_total_shot * 8;
            second_team_shot_on_target = second_team_shot_on_target * 7;
            second_team_ball_game = second_team_ball_game * 6;
            second_team_korner = second_team_korner * 5;
            second_team_pass = second_team_pass * 4;
            second_team_middle = second_team_middle * 3;
            second_team_faul = second_team_faul * (-1);
            second_team_offside = second_team_offside * (-1);
            toplam_ikincitakim = counter_ikincitakim+second_team_goal + second_team_total_shot + second_team_shot_on_target + second_team_ball_game + second_team_korner + second_team_pass + second_team_middle + second_team_faul + second_team_offside;
            double beraberlik = (toplam_ilktakim + toplam_ikincitakim) / 2;
            double total_toplam = 100 / (toplam_ilktakim + toplam_ikincitakim + beraberlik);
            first_team.Text = "%"+(total_toplam * toplam_ilktakim).ToString();
            draw.Text = "%"+(total_toplam * beraberlik).ToString();
            second_team.Text = "%"+(total_toplam * toplam_ikincitakim).ToString();


            //toplam_gol.Text =(toplam_gol_araligi-1).ToString()+"-"+ (toplam_gol_araligi + 1).ToString();
            korner.Text = (toplam_korner_araligi-1).ToString()+"-"+ (toplam_korner_araligi + 1).ToString();
           
            bool flag = false;
            if((first_team_goal/9>=1 && second_team_goal/9>=0.5) || (first_team_goal / 9 >= 0.5 && second_team_goal / 9 >= 1))
            {
                flag = true;
            }
            if (flag == true)
                mutual_goal.Text = "OLUR";
            else
                mutual_goal.Text = "OLMAZ";

            Team1.Text = team_1.ToString();
            Team2.Text = team_2.ToString();


        }
    }
}
