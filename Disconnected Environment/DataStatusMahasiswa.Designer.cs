namespace Disconnected_Environment
{
    partial class DataStatusMahasiswa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusmahasiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.act6DataSet1 = new Disconnected_Environment.Act6DataSet1();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.Label();
            this.act6DataSet = new Disconnected_Environment.Act6DataSet();
            this.statusmahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status_mahasiswaTableAdapter = new Disconnected_Environment.Act6DataSetTableAdapters.status_mahasiswaTableAdapter();
            this.act6DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status_mahasiswaTableAdapter1 = new Disconnected_Environment.Act6DataSet1TableAdapters.status_mahasiswaTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmahasiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(561, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // statusmahasiswaBindingSource1
            // 
            this.statusmahasiswaBindingSource1.DataMember = "status_mahasiswa";
            this.statusmahasiswaBindingSource1.DataSource = this.act6DataSet1;
            // 
            // act6DataSet1
            // 
            this.act6DataSet1.DataSetName = "Act6DataSet1";
            this.act6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(473, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(473, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(473, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(669, 28);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 32);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(324, 332);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(121, 24);
            this.cbxStatusMahasiswa.TabIndex = 5;
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(324, 252);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(121, 24);
            this.cbxNama.TabIndex = 6;
            this.cbxNama.SelectedIndexChanged += new System.EventHandler(this.cbxNama_SelectedIndexChanged);
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(324, 385);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(121, 24);
            this.cbxTahunMasuk.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nomer Induk Mahasiswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tahun Masuk";
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.Location = new System.Drawing.Point(321, 296);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(43, 16);
            this.txtNIM.TabIndex = 12;
            this.txtNIM.Text = "txtNIM";
            // 
            // act6DataSet
            // 
            this.act6DataSet.DataSetName = "Act6DataSet";
            this.act6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusmahasiswaBindingSource
            // 
            this.statusmahasiswaBindingSource.DataMember = "status_mahasiswa";
            this.statusmahasiswaBindingSource.DataSource = this.act6DataSet;
            // 
            // status_mahasiswaTableAdapter
            // 
            this.status_mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // act6DataSet1BindingSource
            // 
            this.act6DataSet1BindingSource.DataSource = this.act6DataSet1;
            this.act6DataSet1BindingSource.Position = 0;
            // 
            // status_mahasiswaTableAdapter1
            // 
            this.status_mahasiswaTableAdapter1.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(678, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataStatusMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataStatusMahasiswa";
            this.Text = "Data Status Mahasiswa";
            this.Load += new System.EventHandler(this.DataStatusMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmahasiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusmahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNIM;
        private Act6DataSet act6DataSet;
        private System.Windows.Forms.BindingSource statusmahasiswaBindingSource;
        private Act6DataSetTableAdapters.status_mahasiswaTableAdapter status_mahasiswaTableAdapter;
        private System.Windows.Forms.BindingSource act6DataSet1BindingSource;
        private Act6DataSet1 act6DataSet1;
        private System.Windows.Forms.BindingSource statusmahasiswaBindingSource1;
        private Act6DataSet1TableAdapters.status_mahasiswaTableAdapter status_mahasiswaTableAdapter1;
        private System.Windows.Forms.Button btnBack;
    }
}