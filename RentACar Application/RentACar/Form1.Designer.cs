namespace RentACar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAracTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.btnKirala = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstArac = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arac Tipi:";
            // 
            // cmbAracTipi
            // 
            this.cmbAracTipi.FormattingEnabled = true;
            this.cmbAracTipi.Location = new System.Drawing.Point(109, 12);
            this.cmbAracTipi.Name = "cmbAracTipi";
            this.cmbAracTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbAracTipi.TabIndex = 1;
            this.cmbAracTipi.SelectedIndexChanged += new System.EventHandler(this.cmbAracTipi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Araclar:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(18, 93);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(188, 172);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gunluk Fiyat";
            this.columnHeader2.Width = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gun Sayisi:";
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(121, 282);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.Size = new System.Drawing.Size(109, 20);
            this.txtGunSayisi.TabIndex = 5;
            // 
            // btnKirala
            // 
            this.btnKirala.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKirala.Location = new System.Drawing.Point(18, 308);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(188, 55);
            this.btnKirala.TabIndex = 6;
            this.btnKirala.Text = "Araci Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Karar Verilen Arac:";
            // 
            // lstArac
            // 
            this.lstArac.FormattingEnabled = true;
            this.lstArac.Location = new System.Drawing.Point(285, 93);
            this.lstArac.Name = "lstArac";
            this.lstArac.Size = new System.Drawing.Size(231, 160);
            this.lstArac.TabIndex = 8;
            // 
            // btnGoster
            // 
            this.btnGoster.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoster.Location = new System.Drawing.Point(285, 308);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(188, 55);
            this.btnGoster.TabIndex = 9;
            this.btnGoster.Text = "Toplam Fiyat Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 375);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lstArac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.txtGunSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAracTipi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAracTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGunSayisi;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstArac;
        private System.Windows.Forms.Button btnGoster;
    }
}

