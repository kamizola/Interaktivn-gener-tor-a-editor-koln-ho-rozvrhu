namespace SchoolTimetable
{
    public partial class FormUcitele : Form
    {
        public FormUcitele()
        {
            InitializeComponent();
            NactiSeznam();
        }

        private void NactiSeznam()
        {
            lstUcitele.Items.Clear();
            foreach (Ucitel u in Data.Ucitele)
            {
                lstUcitele.Items.Add(u);
            }
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            if (txtJmeno.Text.Trim() == "" || txtZkratka.Text.Trim() == "")
            {
                MessageBox.Show("Vyplň jméno i zkratku.");
                return;
            }

            Ucitel u = new Ucitel();
            u.Jmeno = txtJmeno.Text.Trim();
            u.Zkratka = txtZkratka.Text.Trim();
            Data.Ucitele.Add(u);

            NactiSeznam();
            txtJmeno.Text = "";
            txtZkratka.Text = "";
        }

        private void lstUcitele_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitel u = (Ucitel)lstUcitele.SelectedItem;
            if (u == null)
            {
                return;
            }

            txtJmeno.Text = u.Jmeno;
            txtZkratka.Text = u.Zkratka;
        }

        private void btnUpravit_Click(object sender, EventArgs e)
        {
            Ucitel u = (Ucitel)lstUcitele.SelectedItem;
            if (u == null)
            {
                MessageBox.Show("Nejdřív vyber učitele.");
                return;
            }

            if (txtJmeno.Text.Trim() == "" || txtZkratka.Text.Trim() == "")
            {
                MessageBox.Show("Vyplň jméno i zkratku.");
                return;
            }

            u.Jmeno = txtJmeno.Text.Trim();
            u.Zkratka = txtZkratka.Text.Trim();
            NactiSeznam();
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            Ucitel u = (Ucitel)lstUcitele.SelectedItem;
            if (u == null)
            {
                MessageBox.Show("Nejdřív vyber učitele.");
                return;
            }

            Data.Ucitele.Remove(u);
            NactiSeznam();
            txtJmeno.Text = "";
            txtZkratka.Text = "";
        }
    }
}
