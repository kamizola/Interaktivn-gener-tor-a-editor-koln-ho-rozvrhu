namespace SchoolTimetable
{
    public partial class HlavniOkno : Form
    {
        public HlavniOkno()
        {
            InitializeComponent();
        }

        private void btnTridy_Click(object sender, EventArgs e)
        {
            FormTridy okno = new FormTridy();
            okno.ShowDialog();
        }

        private void btnUcitele_Click(object sender, EventArgs e)
        {
            FormUcitele okno = new FormUcitele();
            okno.ShowDialog();
        }

        private void btnUcebny_Click(object sender, EventArgs e)
        {
            FormUcebny okno = new FormUcebny();
            okno.ShowDialog();
        }

        private void btnPredmety_Click(object sender, EventArgs e)
        {
            FormPredmety okno = new FormPredmety();
            okno.ShowDialog();
        }
    }
}
