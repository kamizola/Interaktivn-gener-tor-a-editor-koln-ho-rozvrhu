namespace SchoolTimetable
{
    public partial class FormUcebny : Form
    {
        public FormUcebny()
        {
            InitializeComponent();
            NactiSeznam();
        }

        private void NactiSeznam()
        {
            lstUcebny.Items.Clear();
            foreach (Ucebna u in Data.Ucebny)
            {
                lstUcebny.Items.Add(u);
            }
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            if (txtNazev.Text.Trim() == "")
            {
                MessageBox.Show("Vyplň název učebny.");
                return;
            }

            Ucebna u = new Ucebna();
            u.Nazev = txtNazev.Text.Trim();
            Data.Ucebny.Add(u);

            NactiSeznam();
            txtNazev.Text = "";
        }

        private void lstUcebny_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucebna u = (Ucebna)lstUcebny.SelectedItem;
            if (u == null)
            {
                return;
            }

            txtNazev.Text = u.Nazev;
        }

        private void btnUpravit_Click(object sender, EventArgs e)
        {
            Ucebna u = (Ucebna)lstUcebny.SelectedItem;
            if (u == null)
            {
                MessageBox.Show("Nejdřív vyber učebnu.");
                return;
            }

            if (txtNazev.Text.Trim() == "")
            {
                MessageBox.Show("Vyplň název učebny.");
                return;
            }

            u.Nazev = txtNazev.Text.Trim();
            NactiSeznam();
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            Ucebna u = (Ucebna)lstUcebny.SelectedItem;
            if (u == null)
            {
                MessageBox.Show("Nejdřív vyber učebnu.");
                return;
            }

            Data.Ucebny.Remove(u);
            NactiSeznam();
            txtNazev.Text = "";
        }
    }
}
