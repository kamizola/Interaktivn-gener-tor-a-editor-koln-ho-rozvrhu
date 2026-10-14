namespace SchoolTimetable.Forms;

/// <summary>Hlavní okno aplikace (zatím jen prázdná kostra).</summary>
public class MainForm : Form
{
    public MainForm()
    {
        Text = "Editor školního rozvrhu";
        ClientSize = new Size(1000, 650);
        MinimumSize = new Size(700, 450);
        StartPosition = FormStartPosition.CenterScreen;
    }
}
