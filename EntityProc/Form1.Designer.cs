
namespace EntityProc
{
    partial class Form1
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
            this.txtUretimAdi = new System.Windows.Forms.TextBox();
            this.txtUretimSehir = new System.Windows.Forms.TextBox();
            this.txtUretimMiktari = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUretimAdi
            // 
            this.txtUretimAdi.Location = new System.Drawing.Point(274, 75);
            this.txtUretimAdi.Name = "txtUretimAdi";
            this.txtUretimAdi.Size = new System.Drawing.Size(166, 32);
            this.txtUretimAdi.TabIndex = 0;
            // 
            // txtUretimSehir
            // 
            this.txtUretimSehir.Location = new System.Drawing.Point(274, 161);
            this.txtUretimSehir.Name = "txtUretimSehir";
            this.txtUretimSehir.Size = new System.Drawing.Size(166, 32);
            this.txtUretimSehir.TabIndex = 1;
            // 
            // txtUretimMiktari
            // 
            this.txtUretimMiktari.Location = new System.Drawing.Point(274, 253);
            this.txtUretimMiktari.Name = "txtUretimMiktari";
            this.txtUretimMiktari.Size = new System.Drawing.Size(166, 32);
            this.txtUretimMiktari.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(690, 339);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uretim Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uretim Sehri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uretim Miktar";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(771, 339);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(852, 339);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 8;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(933, 339);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(656, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 258);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtUretimMiktari);
            this.Controls.Add(this.txtUretimSehir);
            this.Controls.Add(this.txtUretimAdi);
            this.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUretimAdi;
        private System.Windows.Forms.TextBox txtUretimSehir;
        private System.Windows.Forms.TextBox txtUretimMiktari;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

