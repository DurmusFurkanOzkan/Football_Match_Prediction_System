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
    public partial class Takim_Bilgileri : Form
    {
        public Takim_Bilgileri()
        {
            InitializeComponent();
        }
        
        
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-48MHJFV;Initial Catalog=dbo_Futbol_Maç_Tahmin_Sistemi;Integrated Security=True");

        public string takim_ismi;
        private void Takim_Bilgileri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbo_Futbol_Maç_Tahmin_SistemiDataSet.Maclar' table. You can move, or remove it, as needed.
            this.maclarTableAdapter.Fill(this.dbo_Futbol_Maç_Tahmin_SistemiDataSet.Maclar);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from Maclar where Takim_adi=@p1 OR Maç_yaptiği_takim=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", takim_ismi);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
    }
}
