
namespace Futbol_Maç_Tahmin_Sistemi
{
    partial class Team_Information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbo_Futbol_Maç_Tahmin_SistemiDataSet = new Futbol_Maç_Tahmin_Sistemi.dbo_Futbol_Maç_Tahmin_SistemiDataSet();
            this.maclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maclarTableAdapter = new Futbol_Maç_Tahmin_Sistemi.dbo_Futbol_Maç_Tahmin_SistemiDataSetTableAdapters.MaclarTableAdapter();
            this.takimadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maçyaptiğitakimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilktakimgolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikincitakimgolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilktakimtoplaoynamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikincitakimtoplaoynamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilktakimtoplamşutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikincitakimtoplamşutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilktakimisabetlişutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikincitakimisabetlişutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilktakimpasbaşariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikincitakimpasbaşariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilktakimkornerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikincitakimkornerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilktakimortaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikincitakimortaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilktakimfaulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikincitakimfaulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilktakimofsaytDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikincitakimofsaytDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kazananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_Futbol_Maç_Tahmin_SistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(327, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takım Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takimadiDataGridViewTextBoxColumn,
            this.maçyaptiğitakimDataGridViewTextBoxColumn,
            this.ilktakimgolDataGridViewTextBoxColumn,
            this.ikincitakimgolDataGridViewTextBoxColumn,
            this.ilktakimtoplaoynamaDataGridViewTextBoxColumn,
            this.ikincitakimtoplaoynamaDataGridViewTextBoxColumn,
            this.ilktakimtoplamşutDataGridViewTextBoxColumn,
            this.ikincitakimtoplamşutDataGridViewTextBoxColumn,
            this.ilktakimisabetlişutDataGridViewTextBoxColumn,
            this.ikincitakimisabetlişutDataGridViewTextBoxColumn,
            this.ilktakimpasbaşariDataGridViewTextBoxColumn,
            this.ikincitakimpasbaşariDataGridViewTextBoxColumn,
            this.ilktakimkornerDataGridViewTextBoxColumn,
            this.ikincitakimkornerDataGridViewTextBoxColumn,
            this.ilktakimortaDataGridViewTextBoxColumn,
            this.ikincitakimortaDataGridViewTextBoxColumn,
            this.ilktakimfaulDataGridViewTextBoxColumn,
            this.ikincitakimfaulDataGridViewTextBoxColumn,
            this.ilktakimofsaytDataGridViewTextBoxColumn,
            this.ikincitakimofsaytDataGridViewTextBoxColumn,
            this.kazananDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maclarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 543);
            this.dataGridView1.TabIndex = 1;
            // 
            // dbo_Futbol_Maç_Tahmin_SistemiDataSet
            // 
            this.dbo_Futbol_Maç_Tahmin_SistemiDataSet.DataSetName = "dbo_Futbol_Maç_Tahmin_SistemiDataSet";
            this.dbo_Futbol_Maç_Tahmin_SistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maclarBindingSource
            // 
            this.maclarBindingSource.DataMember = "Maclar";
            this.maclarBindingSource.DataSource = this.dbo_Futbol_Maç_Tahmin_SistemiDataSet;
            // 
            // maclarTableAdapter
            // 
            this.maclarTableAdapter.ClearBeforeFill = true;
            // 
            // takimadiDataGridViewTextBoxColumn
            // 
            this.takimadiDataGridViewTextBoxColumn.DataPropertyName = "Takim_adi";
            this.takimadiDataGridViewTextBoxColumn.HeaderText = "Takim_adi";
            this.takimadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.takimadiDataGridViewTextBoxColumn.Name = "takimadiDataGridViewTextBoxColumn";
            // 
            // maçyaptiğitakimDataGridViewTextBoxColumn
            // 
            this.maçyaptiğitakimDataGridViewTextBoxColumn.DataPropertyName = "Maç_yaptiği_takim";
            this.maçyaptiğitakimDataGridViewTextBoxColumn.HeaderText = "Maç_yaptiği_takim";
            this.maçyaptiğitakimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maçyaptiğitakimDataGridViewTextBoxColumn.Name = "maçyaptiğitakimDataGridViewTextBoxColumn";
            // 
            // ilktakimgolDataGridViewTextBoxColumn
            // 
            this.ilktakimgolDataGridViewTextBoxColumn.DataPropertyName = "İlk_takim_gol";
            this.ilktakimgolDataGridViewTextBoxColumn.HeaderText = "İlk_takim_gol";
            this.ilktakimgolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilktakimgolDataGridViewTextBoxColumn.Name = "ilktakimgolDataGridViewTextBoxColumn";
            // 
            // ikincitakimgolDataGridViewTextBoxColumn
            // 
            this.ikincitakimgolDataGridViewTextBoxColumn.DataPropertyName = "İkinci_takim_gol";
            this.ikincitakimgolDataGridViewTextBoxColumn.HeaderText = "İkinci_takim_gol";
            this.ikincitakimgolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ikincitakimgolDataGridViewTextBoxColumn.Name = "ikincitakimgolDataGridViewTextBoxColumn";
            // 
            // ilktakimtoplaoynamaDataGridViewTextBoxColumn
            // 
            this.ilktakimtoplaoynamaDataGridViewTextBoxColumn.DataPropertyName = "İlk_takim_toplaoynama";
            this.ilktakimtoplaoynamaDataGridViewTextBoxColumn.HeaderText = "İlk_takim_toplaoynama";
            this.ilktakimtoplaoynamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilktakimtoplaoynamaDataGridViewTextBoxColumn.Name = "ilktakimtoplaoynamaDataGridViewTextBoxColumn";
            // 
            // ikincitakimtoplaoynamaDataGridViewTextBoxColumn
            // 
            this.ikincitakimtoplaoynamaDataGridViewTextBoxColumn.DataPropertyName = "İkinci_takim_toplaoynama";
            this.ikincitakimtoplaoynamaDataGridViewTextBoxColumn.HeaderText = "İkinci_takim_toplaoynama";
            this.ikincitakimtoplaoynamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ikincitakimtoplaoynamaDataGridViewTextBoxColumn.Name = "ikincitakimtoplaoynamaDataGridViewTextBoxColumn";
            // 
            // ilktakimtoplamşutDataGridViewTextBoxColumn
            // 
            this.ilktakimtoplamşutDataGridViewTextBoxColumn.DataPropertyName = "İlk_takim_toplamşut";
            this.ilktakimtoplamşutDataGridViewTextBoxColumn.HeaderText = "İlk_takim_toplamşut";
            this.ilktakimtoplamşutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilktakimtoplamşutDataGridViewTextBoxColumn.Name = "ilktakimtoplamşutDataGridViewTextBoxColumn";
            // 
            // ikincitakimtoplamşutDataGridViewTextBoxColumn
            // 
            this.ikincitakimtoplamşutDataGridViewTextBoxColumn.DataPropertyName = "İkinci_takim_toplamşut";
            this.ikincitakimtoplamşutDataGridViewTextBoxColumn.HeaderText = "İkinci_takim_toplamşut";
            this.ikincitakimtoplamşutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ikincitakimtoplamşutDataGridViewTextBoxColumn.Name = "ikincitakimtoplamşutDataGridViewTextBoxColumn";
            // 
            // ilktakimisabetlişutDataGridViewTextBoxColumn
            // 
            this.ilktakimisabetlişutDataGridViewTextBoxColumn.DataPropertyName = "İlk_takim_isabetli_şut";
            this.ilktakimisabetlişutDataGridViewTextBoxColumn.HeaderText = "İlk_takim_isabetli_şut";
            this.ilktakimisabetlişutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilktakimisabetlişutDataGridViewTextBoxColumn.Name = "ilktakimisabetlişutDataGridViewTextBoxColumn";
            // 
            // ikincitakimisabetlişutDataGridViewTextBoxColumn
            // 
            this.ikincitakimisabetlişutDataGridViewTextBoxColumn.DataPropertyName = "İkinci_takim_isabetli_şut";
            this.ikincitakimisabetlişutDataGridViewTextBoxColumn.HeaderText = "İkinci_takim_isabetli_şut";
            this.ikincitakimisabetlişutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ikincitakimisabetlişutDataGridViewTextBoxColumn.Name = "ikincitakimisabetlişutDataGridViewTextBoxColumn";
            // 
            // ilktakimpasbaşariDataGridViewTextBoxColumn
            // 
            this.ilktakimpasbaşariDataGridViewTextBoxColumn.DataPropertyName = "İlk_takim_pasbaşari";
            this.ilktakimpasbaşariDataGridViewTextBoxColumn.HeaderText = "İlk_takim_pasbaşari";
            this.ilktakimpasbaşariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilktakimpasbaşariDataGridViewTextBoxColumn.Name = "ilktakimpasbaşariDataGridViewTextBoxColumn";
            // 
            // ikincitakimpasbaşariDataGridViewTextBoxColumn
            // 
            this.ikincitakimpasbaşariDataGridViewTextBoxColumn.DataPropertyName = "İkinci_takim_pasbaşari";
            this.ikincitakimpasbaşariDataGridViewTextBoxColumn.HeaderText = "İkinci_takim_pasbaşari";
            this.ikincitakimpasbaşariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ikincitakimpasbaşariDataGridViewTextBoxColumn.Name = "ikincitakimpasbaşariDataGridViewTextBoxColumn";
            // 
            // ilktakimkornerDataGridViewTextBoxColumn
            // 
            this.ilktakimkornerDataGridViewTextBoxColumn.DataPropertyName = "İlk_takim_korner";
            this.ilktakimkornerDataGridViewTextBoxColumn.HeaderText = "İlk_takim_korner";
            this.ilktakimkornerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilktakimkornerDataGridViewTextBoxColumn.Name = "ilktakimkornerDataGridViewTextBoxColumn";
            // 
            // ikincitakimkornerDataGridViewTextBoxColumn
            // 
            this.ikincitakimkornerDataGridViewTextBoxColumn.DataPropertyName = "İkinci_takim_korner";
            this.ikincitakimkornerDataGridViewTextBoxColumn.HeaderText = "İkinci_takim_korner";
            this.ikincitakimkornerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ikincitakimkornerDataGridViewTextBoxColumn.Name = "ikincitakimkornerDataGridViewTextBoxColumn";
            // 
            // ilktakimortaDataGridViewTextBoxColumn
            // 
            this.ilktakimortaDataGridViewTextBoxColumn.DataPropertyName = "İlk_takim_orta";
            this.ilktakimortaDataGridViewTextBoxColumn.HeaderText = "İlk_takim_orta";
            this.ilktakimortaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilktakimortaDataGridViewTextBoxColumn.Name = "ilktakimortaDataGridViewTextBoxColumn";
            // 
            // ikincitakimortaDataGridViewTextBoxColumn
            // 
            this.ikincitakimortaDataGridViewTextBoxColumn.DataPropertyName = "İkinci_takim_orta";
            this.ikincitakimortaDataGridViewTextBoxColumn.HeaderText = "İkinci_takim_orta";
            this.ikincitakimortaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ikincitakimortaDataGridViewTextBoxColumn.Name = "ikincitakimortaDataGridViewTextBoxColumn";
            // 
            // ilktakimfaulDataGridViewTextBoxColumn
            // 
            this.ilktakimfaulDataGridViewTextBoxColumn.DataPropertyName = "İlk_takim_faul";
            this.ilktakimfaulDataGridViewTextBoxColumn.HeaderText = "İlk_takim_faul";
            this.ilktakimfaulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilktakimfaulDataGridViewTextBoxColumn.Name = "ilktakimfaulDataGridViewTextBoxColumn";
            // 
            // ikincitakimfaulDataGridViewTextBoxColumn
            // 
            this.ikincitakimfaulDataGridViewTextBoxColumn.DataPropertyName = "İkinci_takim_faul";
            this.ikincitakimfaulDataGridViewTextBoxColumn.HeaderText = "İkinci_takim_faul";
            this.ikincitakimfaulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ikincitakimfaulDataGridViewTextBoxColumn.Name = "ikincitakimfaulDataGridViewTextBoxColumn";
            // 
            // ilktakimofsaytDataGridViewTextBoxColumn
            // 
            this.ilktakimofsaytDataGridViewTextBoxColumn.DataPropertyName = "İlk_takim_ofsayt";
            this.ilktakimofsaytDataGridViewTextBoxColumn.HeaderText = "İlk_takim_ofsayt";
            this.ilktakimofsaytDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilktakimofsaytDataGridViewTextBoxColumn.Name = "ilktakimofsaytDataGridViewTextBoxColumn";
            // 
            // ikincitakimofsaytDataGridViewTextBoxColumn
            // 
            this.ikincitakimofsaytDataGridViewTextBoxColumn.DataPropertyName = "İkinci_takim_ofsayt";
            this.ikincitakimofsaytDataGridViewTextBoxColumn.HeaderText = "İkinci_takim_ofsayt";
            this.ikincitakimofsaytDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ikincitakimofsaytDataGridViewTextBoxColumn.Name = "ikincitakimofsaytDataGridViewTextBoxColumn";
            // 
            // kazananDataGridViewTextBoxColumn
            // 
            this.kazananDataGridViewTextBoxColumn.DataPropertyName = "kazanan";
            this.kazananDataGridViewTextBoxColumn.HeaderText = "kazanan";
            this.kazananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kazananDataGridViewTextBoxColumn.Name = "kazananDataGridViewTextBoxColumn";
            // 
            // Takim_Bilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1924, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Takim_Bilgileri";
            this.Text = "Takim_Bilgileri";
            this.Load += new System.EventHandler(this.Takim_Bilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_Futbol_Maç_Tahmin_SistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private dbo_Futbol_Maç_Tahmin_SistemiDataSet dbo_Futbol_Maç_Tahmin_SistemiDataSet;
        private System.Windows.Forms.BindingSource maclarBindingSource;
        private dbo_Futbol_Maç_Tahmin_SistemiDataSetTableAdapters.MaclarTableAdapter maclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn takimadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maçyaptiğitakimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilktakimgolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikincitakimgolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilktakimtoplaoynamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikincitakimtoplaoynamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilktakimtoplamşutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikincitakimtoplamşutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilktakimisabetlişutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikincitakimisabetlişutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilktakimpasbaşariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikincitakimpasbaşariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilktakimkornerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikincitakimkornerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilktakimortaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikincitakimortaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilktakimfaulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikincitakimfaulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilktakimofsaytDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ikincitakimofsaytDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kazananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}