﻿namespace Disconnected_Environment
{
    partial class DataProdi
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
            this.prodiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.act6DataSet1 = new Disconnected_Environment.Act6DataSet1();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.nmp = new System.Windows.Forms.TextBox();
            this.prodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.prodiTableAdapter = new Disconnected_Environment.Act6DataSet1TableAdapters.prodiTableAdapter();
            this.idp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prodiBindingSource1
            // 
            this.prodiBindingSource1.DataMember = "prodi";
            this.prodiBindingSource1.DataSource = this.act6DataSet1;
            // 
            // act6DataSet1
            // 
            this.act6DataSet1.DataSetName = "Act6DataSet1";
            this.act6DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(366, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 34);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(478, 313);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(629, 39);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 42);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button4_Click);
            // 
            // nmp
            // 
            this.nmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodiBindingSource, "nama_prodi", true));
            this.nmp.Location = new System.Drawing.Point(252, 313);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(194, 22);
            this.nmp.TabIndex = 5;
            this.nmp.TextChanged += new System.EventHandler(this.nmp_TextChanged);
            // 
            // prodiBindingSource
            // 
            this.prodiBindingSource.DataMember = "prodi";
            this.prodiBindingSource.DataSource = this.act6DataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nama Prodi";
            // 
            // prodiTableAdapter
            // 
            this.prodiTableAdapter.ClearBeforeFill = true;
            // 
            // idp
            // 
            this.idp.Location = new System.Drawing.Point(252, 351);
            this.idp.Name = "idp";
            this.idp.Size = new System.Drawing.Size(194, 22);
            this.idp.TabIndex = 8;
            this.idp.TextChanged += new System.EventHandler(this.idp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id Prodi";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(676, 365);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataProdi";
            this.Text = "Data Prodi";
            this.Load += new System.EventHandler(this.DataProdi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.Label label1;
        private Act6DataSet1 act6DataSet1;
        private System.Windows.Forms.BindingSource prodiBindingSource;
        private Act6DataSet1TableAdapters.prodiTableAdapter prodiTableAdapter;
        private System.Windows.Forms.BindingSource prodiBindingSource1;
        private System.Windows.Forms.TextBox idp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}