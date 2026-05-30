namespace ServisNalogPro
{
    partial class MainForm
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
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ServisNalog Pro - Glavni izbornik";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(258, 132);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(155, 47);
            this.btnKreiraj.TabIndex = 1;
            this.btnKreiraj.Text = "Kreiraj radni nalog";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(258, 216);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(155, 41);
            this.btnStatistika.TabIndex = 2;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(675, 385);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(113, 43);
            this.btnIzlaz.TabIndex = 3;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(532, 385);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(103, 43);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnOdjava;
    }
}