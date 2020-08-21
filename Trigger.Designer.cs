namespace Trigger
{
    partial class btnRaporla
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
            this.dataGridViewUrun = new System.Windows.Forms.DataGridView();
            this.dataGridViewSatis = new System.Windows.Forms.DataGridView();
            this.btnUrunGoster = new System.Windows.Forms.Button();
            this.btnSatisGoster = new System.Windows.Forms.Button();
            this.btnSatisEkle = new System.Windows.Forms.Button();
            this.txtSatisId = new System.Windows.Forms.TextBox();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.txtSatisAdedi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSatisSil = new System.Windows.Forms.Button();
            this.btnSatisGuncelle = new System.Windows.Forms.Button();
            this.btnSatisRaporla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUrun
            // 
            this.dataGridViewUrun.AllowUserToAddRows = false;
            this.dataGridViewUrun.AllowUserToDeleteRows = false;
            this.dataGridViewUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUrun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrun.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewUrun.Name = "dataGridViewUrun";
            this.dataGridViewUrun.ReadOnly = true;
            this.dataGridViewUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUrun.Size = new System.Drawing.Size(757, 148);
            this.dataGridViewUrun.TabIndex = 0;
            // 
            // dataGridViewSatis
            // 
            this.dataGridViewSatis.AllowUserToAddRows = false;
            this.dataGridViewSatis.AllowUserToDeleteRows = false;
            this.dataGridViewSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSatis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatis.Location = new System.Drawing.Point(12, 202);
            this.dataGridViewSatis.Name = "dataGridViewSatis";
            this.dataGridViewSatis.ReadOnly = true;
            this.dataGridViewSatis.Size = new System.Drawing.Size(757, 148);
            this.dataGridViewSatis.TabIndex = 0;
            this.dataGridViewSatis.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSatis_CellEnter);
            // 
            // btnUrunGoster
            // 
            this.btnUrunGoster.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUrunGoster.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunGoster.Location = new System.Drawing.Point(12, 166);
            this.btnUrunGoster.Name = "btnUrunGoster";
            this.btnUrunGoster.Size = new System.Drawing.Size(93, 30);
            this.btnUrunGoster.TabIndex = 1;
            this.btnUrunGoster.Text = "Ürün GÖSTER";
            this.btnUrunGoster.UseVisualStyleBackColor = false;
            this.btnUrunGoster.Click += new System.EventHandler(this.btnUrunGoster_Click);
            // 
            // btnSatisGoster
            // 
            this.btnSatisGoster.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSatisGoster.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisGoster.Location = new System.Drawing.Point(12, 356);
            this.btnSatisGoster.Name = "btnSatisGoster";
            this.btnSatisGoster.Size = new System.Drawing.Size(93, 30);
            this.btnSatisGoster.TabIndex = 1;
            this.btnSatisGoster.Text = "Satış GÖSTER";
            this.btnSatisGoster.UseVisualStyleBackColor = false;
            this.btnSatisGoster.Click += new System.EventHandler(this.btnSatisGoster_Click);
            // 
            // btnSatisEkle
            // 
            this.btnSatisEkle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSatisEkle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisEkle.Location = new System.Drawing.Point(342, 420);
            this.btnSatisEkle.Name = "btnSatisEkle";
            this.btnSatisEkle.Size = new System.Drawing.Size(93, 30);
            this.btnSatisEkle.TabIndex = 2;
            this.btnSatisEkle.Text = "Satış EKLE";
            this.btnSatisEkle.UseVisualStyleBackColor = false;
            this.btnSatisEkle.Click += new System.EventHandler(this.btnSatisEkle_Click);
            // 
            // txtSatisId
            // 
            this.txtSatisId.Location = new System.Drawing.Point(213, 378);
            this.txtSatisId.Name = "txtSatisId";
            this.txtSatisId.ReadOnly = true;
            this.txtSatisId.Size = new System.Drawing.Size(100, 20);
            this.txtSatisId.TabIndex = 3;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(213, 404);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(100, 20);
            this.txtUrunId.TabIndex = 0;
            // 
            // txtSatisAdedi
            // 
            this.txtSatisAdedi.Location = new System.Drawing.Point(213, 430);
            this.txtSatisAdedi.Name = "txtSatisAdedi";
            this.txtSatisAdedi.Size = new System.Drawing.Size(100, 20);
            this.txtSatisAdedi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Satis ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Urun ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satış Adedi";
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSatisSil.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisSil.Location = new System.Drawing.Point(441, 420);
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(93, 30);
            this.btnSatisSil.TabIndex = 5;
            this.btnSatisSil.Text = "Satış SİL";
            this.btnSatisSil.UseVisualStyleBackColor = false;
            this.btnSatisSil.Click += new System.EventHandler(this.btnSatisSil_Click);
            // 
            // btnSatisGuncelle
            // 
            this.btnSatisGuncelle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSatisGuncelle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisGuncelle.Location = new System.Drawing.Point(540, 420);
            this.btnSatisGuncelle.Name = "btnSatisGuncelle";
            this.btnSatisGuncelle.Size = new System.Drawing.Size(104, 30);
            this.btnSatisGuncelle.TabIndex = 6;
            this.btnSatisGuncelle.Text = "Satış GUNCELLE";
            this.btnSatisGuncelle.UseVisualStyleBackColor = false;
            this.btnSatisGuncelle.Click += new System.EventHandler(this.btnSatisGuncelle_Click);
            // 
            // btnSatisRaporla
            // 
            this.btnSatisRaporla.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSatisRaporla.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisRaporla.Location = new System.Drawing.Point(679, 444);
            this.btnSatisRaporla.Name = "btnSatisRaporla";
            this.btnSatisRaporla.Size = new System.Drawing.Size(104, 49);
            this.btnSatisRaporla.TabIndex = 7;
            this.btnSatisRaporla.Text = "SATIŞ RAPORLA";
            this.btnSatisRaporla.UseVisualStyleBackColor = false;
            this.btnSatisRaporla.Click += new System.EventHandler(this.btnSatisRaporla_Click);
            // 
            // btnRaporla
            // 
            this.AcceptButton = this.btnSatisEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 493);
            this.Controls.Add(this.btnSatisRaporla);
            this.Controls.Add(this.btnSatisGuncelle);
            this.Controls.Add(this.btnSatisSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSatisAdedi);
            this.Controls.Add(this.txtUrunId);
            this.Controls.Add(this.txtSatisId);
            this.Controls.Add(this.btnSatisEkle);
            this.Controls.Add(this.btnSatisGoster);
            this.Controls.Add(this.btnUrunGoster);
            this.Controls.Add(this.dataGridViewSatis);
            this.Controls.Add(this.dataGridViewUrun);
            this.Name = "btnRaporla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trigger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUrun;
        private System.Windows.Forms.DataGridView dataGridViewSatis;
        private System.Windows.Forms.Button btnUrunGoster;
        private System.Windows.Forms.Button btnSatisGoster;
        private System.Windows.Forms.Button btnSatisEkle;
        private System.Windows.Forms.TextBox txtSatisId;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtSatisAdedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSatisSil;
        private System.Windows.Forms.Button btnSatisGuncelle;
        private System.Windows.Forms.Button btnSatisRaporla;
    }
}

