namespace RentACar
{
    partial class Siparis
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
            this.lblMeblag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Meblag:";
            // 
            // lblMeblag
            // 
            this.lblMeblag.AutoSize = true;
            this.lblMeblag.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeblag.Location = new System.Drawing.Point(147, 81);
            this.lblMeblag.Name = "lblMeblag";
            this.lblMeblag.Size = new System.Drawing.Size(41, 34);
            this.lblMeblag.TabIndex = 2;
            this.lblMeblag.Text = "0.0";
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 261);
            this.Controls.Add(this.lblMeblag);
            this.Controls.Add(this.label1);
            this.Name = "Siparis";
            this.Text = "Siparis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMeblag;
    }
}