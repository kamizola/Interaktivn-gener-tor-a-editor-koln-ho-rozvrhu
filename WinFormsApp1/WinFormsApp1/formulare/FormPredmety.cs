namespace SchoolTimetable
{
    public partial class FormPredmety : Form
    {
        public FormPredmety()
        {
            InitializeComponent();
            NactiSeznam();
        }

        private void NactiSeznam()
        {
            lstPredmety.Items.Clear();
            foreach (Predmet p in Data.Predmety)
            {
                lstPredmety.Items.Add(p);
            }
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            if (txtNazev.Text.Trim() == "" || txtZkratka.Text.Trim() == "")
            {
                MessageBox.Show("Vyplň název i zkratku.");
                return;
            }

            Predmet p = new Predmet();
            p.Nazev = txtNazev.Text.Trim();
            p.Zkratka = txtZkratka.Text.Trim();
            Data.Predmety.Add(p);

            NactiSeznam();
            txtNazev.Text = "";
            txtZkratka.Text = "";
        }

        private void lstPredmety_SelectedIndexChanged(object sender, EventArgs e)
        {
            Predmet p = (Predmet)lstPredmety.SelectedItem;
            if (p == null)
            {
                return;
            }

            txtNazev.Text = p.Nazev;
            txtZkratka.Text = p.Zkratka;
        }

        private void btnUpravit_Click(object sender, EventArgs e)
        {
            Predmet p = (Predmet)lstPredmety.SelectedItem;
            if (p == null)
            {
                MessageBox.Show("Nejdřív vyber předmět.");
                return;
            }

            if (txtNazev.Text.Trim() == "" || txtZkratka.Text.Trim() == "")
            {
                MessageBox.Show("Vyplň název i zkratku.");
                return;
            }

            p.Nazev = txtNazev.Text.Trim();
            p.Zkratka = txtZkratka.Text.Trim();
            NactiSeznam();
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            Predmet p = (Predmet)lstPredmety.SelectedItem;
            if (p == null)
            {
                MessageBox.Show("Nejdřív vyber předmět.");
                return;
            }

            Data.Predmety.Remove(p);
            NactiSeznam();
            txtNazev.Text = "";
            txtZkratka.Text = "";
        }
    }
}
