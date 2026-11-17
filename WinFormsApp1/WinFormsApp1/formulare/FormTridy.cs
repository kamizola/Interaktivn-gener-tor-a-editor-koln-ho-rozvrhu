namespace SchoolTimetable
{
    public partial class FormTridy : Form
    {
        public FormTridy()
        {
            InitializeComponent();
            NactiSeznam();
        }

        private void NactiSeznam()
        {
            lstTridy.Items.Clear();
            foreach (Trida t in Data.Tridy)
            {
                lstTridy.Items.Add(t);
            }
        }

        private void btnPridat_Click(object sender, EventArgs e)
        {
            if (txtNazev.Text.Trim() == "")
            {
                MessageBox.Show("Vyplň název třídy.");
                return;
            }

            Trida t = new Trida();
            t.Nazev = txtNazev.Text.Trim();
            Data.Tridy.Add(t);

            NactiSeznam();
            txtNazev.Text = "";
        }

        private void lstTridy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trida t = (Trida)lstTridy.SelectedItem;
            if (t == null)
            {
                return;
            }

            txtNazev.Text = t.Nazev;
        }

        private void btnUpravit_Click(object sender, EventArgs e)
        {
            Trida t = (Trida)lstTridy.SelectedItem;
            if (t == null)
            {
                MessageBox.Show("Nejdřív vyber třídu.");
                return;
            }

            if (txtNazev.Text.Trim() == "")
            {
                MessageBox.Show("Vyplň název třídy.");
                return;
            }

            t.Nazev = txtNazev.Text.Trim();
            NactiSeznam();
        }

        private void btnSmazat_Click(object sender, EventArgs e)
        {
            Trida t = (Trida)lstTridy.SelectedItem;
            if (t == null)
            {
                MessageBox.Show("Nejdřív vyber třídu.");
                return;
            }

            Data.Tridy.Remove(t);
            NactiSeznam();
            txtNazev.Text = "";
        }
    }
}
