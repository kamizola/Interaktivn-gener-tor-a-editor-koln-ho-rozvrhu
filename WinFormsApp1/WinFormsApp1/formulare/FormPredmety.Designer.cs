namespace SchoolTimetable
{
    partial class FormPredmety
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstPredmety = new System.Windows.Forms.ListBox();
            this.lblNazev = new System.Windows.Forms.Label();
            this.txtNazev = new System.Windows.Forms.TextBox();
            this.lblZkratka = new System.Windows.Forms.Label();
            this.txtZkratka = new System.Windows.Forms.TextBox();
            this.btnPridat = new System.Windows.Forms.Button();
            this.btnUpravit = new System.Windows.Forms.Button();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPredmety
            // 
            this.lstPredmety.FormattingEnabled = true;
            this.lstPredmety.ItemHeight = 15;
            this.lstPredmety.Location = new System.Drawing.Point(12, 12);
            this.lstPredmety.Name = "lstPredmety";
            this.lstPredmety.Size = new System.Drawing.Size(260, 274);
            this.lstPredmety.TabIndex = 0;
            this.lstPredmety.SelectedIndexChanged += new System.EventHandler(this.lstPredmety_SelectedIndexChanged);
            // 
            // lblNazev
            // 
            this.lblNazev.AutoSize = true;
            this.lblNazev.Location = new System.Drawing.Point(290, 12);
            this.lblNazev.Name = "lblNazev";
            this.lblNazev.Size = new System.Drawing.Size(50, 15);
            this.lblNazev.TabIndex = 1;
            this.lblNazev.Text = "Název";
            // 
            // txtNazev
            // 
            this.txtNazev.Location = new System.Drawing.Point(290, 30);
            this.txtNazev.Name = "txtNazev";
            this.txtNazev.Size = new System.Drawing.Size(200, 23);
            this.txtNazev.TabIndex = 2;
            // 
            // lblZkratka
            // 
            this.lblZkratka.AutoSize = true;
            this.lblZkratka.Location = new System.Drawing.Point(290, 67);
            this.lblZkratka.Name = "lblZkratka";
            this.lblZkratka.Size = new System.Drawing.Size(50, 15);
            this.lblZkratka.TabIndex = 3;
            this.lblZkratka.Text = "Zkratka";
            // 
            // txtZkratka
            // 
            this.txtZkratka.Location = new System.Drawing.Point(290, 85);
            this.txtZkratka.Name = "txtZkratka";
            this.txtZkratka.Size = new System.Drawing.Size(200, 23);
            this.txtZkratka.TabIndex = 4;
            // 
            // btnPridat
            // 
            this.btnPridat.Location = new System.Drawing.Point(290, 132);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(200, 30);
            this.btnPridat.TabIndex = 5;
            this.btnPridat.Text = "Přidat";
            this.btnPridat.UseVisualStyleBackColor = true;
            this.btnPridat.Click += new System.EventHandler(this.btnPridat_Click);
            // 
            // btnUpravit
            // 
            this.btnUpravit.Location = new System.Drawing.Point(290, 172);
            this.btnUpravit.Name = "btnUpravit";
            this.btnUpravit.Size = new System.Drawing.Size(200, 30);
            this.btnUpravit.TabIndex = 6;
            this.btnUpravit.Text = "Upravit";
            this.btnUpravit.UseVisualStyleBackColor = true;
            this.btnUpravit.Click += new System.EventHandler(this.btnUpravit_Click);
            // 
            // btnSmazat
            // 
            this.btnSmazat.Location = new System.Drawing.Point(290, 212);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(200, 30);
            this.btnSmazat.TabIndex = 7;
            this.btnSmazat.Text = "Smazat";
            this.btnSmazat.UseVisualStyleBackColor = true;
            this.btnSmazat.Click += new System.EventHandler(this.btnSmazat_Click);
            // 
            // FormPredmety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 300);
            this.Controls.Add(this.lstPredmety);
            this.Controls.Add(this.lblNazev);
            this.Controls.Add(this.txtNazev);
            this.Controls.Add(this.lblZkratka);
            this.Controls.Add(this.txtZkratka);
            this.Controls.Add(this.btnPridat);
            this.Controls.Add(this.btnUpravit);
            this.Controls.Add(this.btnSmazat);
            this.Name = "FormPredmety";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Předměty";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstPredmety;
        private System.Windows.Forms.Label lblNazev;
        private System.Windows.Forms.TextBox txtNazev;
        private System.Windows.Forms.Label lblZkratka;
        private System.Windows.Forms.TextBox txtZkratka;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.Button btnUpravit;
        private System.Windows.Forms.Button btnSmazat;
    }
}
