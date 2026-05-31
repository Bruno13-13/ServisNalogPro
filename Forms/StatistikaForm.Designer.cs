namespace ServisNalogPro.Forms
{
    partial class StatistikaForm
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
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lblUTijeku = new System.Windows.Forms.Label();
            this.lblZavrseno = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupno.Location = new System.Drawing.Point(68, 106);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(144, 25);
            this.lblUkupno.TabIndex = 0;
            this.lblUkupno.Text = "Ukupno naloga";
            // 
            // lblUTijeku
            // 
            this.lblUTijeku.AutoSize = true;
            this.lblUTijeku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUTijeku.Location = new System.Drawing.Point(372, 106);
            this.lblUTijeku.Name = "lblUTijeku";
            this.lblUTijeku.Size = new System.Drawing.Size(95, 31);
            this.lblUTijeku.TabIndex = 1;
            this.lblUTijeku.Text = "U tijeku";
            // 
            // lblZavrseno
            // 
            this.lblZavrseno.AutoSize = true;
            this.lblZavrseno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZavrseno.Location = new System.Drawing.Point(611, 106);
            this.lblZavrseno.Name = "lblZavrseno";
            this.lblZavrseno.Size = new System.Drawing.Size(118, 31);
            this.lblZavrseno.TabIndex = 2;
            this.lblZavrseno.Text = "Završeno";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(719, 435);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(103, 51);
            this.btnIzlaz.TabIndex = 4;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // StatistikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 508);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.lblZavrseno);
            this.Controls.Add(this.lblUTijeku);
            this.Controls.Add(this.lblUkupno);
            this.Name = "StatistikaForm";
            this.Text = "StatistikaForm";
            this.Load += new System.EventHandler(this.StatistikaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label lblUTijeku;
        private System.Windows.Forms.Label lblZavrseno;
        private System.Windows.Forms.Button btnIzlaz;
    }
}