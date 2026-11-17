namespace SchoolTimetable
{
    partial class FormTridy
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
            this.lstTridy = new System.Windows.Forms.ListBox();
            this.lblNazev = new System.Windows.Forms.Label();
            this.txtNazev = new System.Windows.Forms.TextBox();
            this.btnPridat = new System.Windows.Forms.Button();
            this.btnUpravit = new System.Windows.Forms.Button();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTridy
            // 
            this.lstTridy.FormattingEnabled = true;
            this.lstTridy.ItemHeight = 15;
            this.lstTridy.Location = new System.Drawing.Point(12, 12);
            this.lstTridy.Name = "lstTridy";
            this.lstTridy.Size = new System.Drawing.Size(260, 274);
            this.lstTridy.TabIndex = 0;
            this.lstTridy.SelectedIndexChanged += new System.EventHandler(this.lstTridy_SelectedIndexChanged);
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
            // btnPridat
            // 
            this.btnPridat.Location = new System.Drawing.Point(290, 77);
            this.btnPridat.Name = "btnPridat";
            this.btnPridat.Size = new System.Drawing.Size(200, 30);
            this.btnPridat.TabIndex = 3;
            this.btnPridat.Text = "Přidat";
            this.btnPridat.UseVisualStyleBackColor = true;
            this.btnPridat.Click += new System.EventHandler(this.btnPridat_Click);
            // 
            // btnUpravit
            // 
            this.btnUpravit.Location = new System.Drawing.Point(290, 117);
            this.btnUpravit.Name = "btnUpravit";
            this.btnUpravit.Size = new System.Drawing.Size(200, 30);
            this.btnUpravit.TabIndex = 4;
            this.btnUpravit.Text = "Upravit";
            this.btnUpravit.UseVisualStyleBackColor = true;
            this.btnUpravit.Click += new System.EventHandler(this.btnUpravit_Click);
            // 
            // btnSmazat
            // 
            this.btnSmazat.Location = new System.Drawing.Point(290, 157);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(200, 30);
            this.btnSmazat.TabIndex = 5;
            this.btnSmazat.Text = "Smazat";
            this.btnSmazat.UseVisualStyleBackColor = true;
            this.btnSmazat.Click += new System.EventHandler(this.btnSmazat_Click);
            // 
            // FormTridy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 300);
            this.Controls.Add(this.lstTridy);
            this.Controls.Add(this.lblNazev);
            this.Controls.Add(this.txtNazev);
            this.Controls.Add(this.btnPridat);
            this.Controls.Add(this.btnUpravit);
            this.Controls.Add(this.btnSmazat);
            this.Name = "FormTridy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Třídy";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstTridy;
        private System.Windows.Forms.Label lblNazev;
        private System.Windows.Forms.TextBox txtNazev;
        private System.Windows.Forms.Button btnPridat;
        private System.Windows.Forms.Button btnUpravit;
        private System.Windows.Forms.Button btnSmazat;
    }
}
