namespace SchoolTimetable
{
    partial class HlavniOkno
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
            btnTridy = new Button();
            btnUcitele = new Button();
            btnUcebny = new Button();
            btnPredmety = new Button();
            SuspendLayout();
            // 
            // btnTridy
            // 
            btnTridy.Location = new Point(304, 20);
            btnTridy.Name = "btnTridy";
            btnTridy.Size = new Size(120, 40);
            btnTridy.TabIndex = 0;
            btnTridy.Text = "Třídy";
            btnTridy.UseVisualStyleBackColor = true;
            btnTridy.Click += btnTridy_Click;
            // 
            // btnUcitele
            // 
            btnUcitele.Location = new Point(445, 20);
            btnUcitele.Name = "btnUcitele";
            btnUcitele.Size = new Size(120, 40);
            btnUcitele.TabIndex = 1;
            btnUcitele.Text = "Učitelé";
            btnUcitele.UseVisualStyleBackColor = true;
            btnUcitele.Click += btnUcitele_Click;
            // 
            // btnUcebny
            // 
            btnUcebny.Location = new Point(600, 20);
            btnUcebny.Name = "btnUcebny";
            btnUcebny.Size = new Size(120, 40);
            btnUcebny.TabIndex = 2;
            btnUcebny.Text = "Učebny";
            btnUcebny.UseVisualStyleBackColor = true;
            btnUcebny.Click += btnUcebny_Click;
            // 
            // btnPredmety
            // 
            btnPredmety.Location = new Point(791, 20);
            btnPredmety.Name = "btnPredmety";
            btnPredmety.Size = new Size(120, 40);
            btnPredmety.TabIndex = 3;
            btnPredmety.Text = "Předměty";
            btnPredmety.UseVisualStyleBackColor = true;
            btnPredmety.Click += btnPredmety_Click;
            // 
            // HlavniOkno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 516);
            Controls.Add(btnTridy);
            Controls.Add(btnUcitele);
            Controls.Add(btnUcebny);
            Controls.Add(btnPredmety);
            Name = "HlavniOkno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editor školního rozvrhu";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnTridy;
        private System.Windows.Forms.Button btnUcitele;
        private System.Windows.Forms.Button btnUcebny;
        private System.Windows.Forms.Button btnPredmety;
    }
}
