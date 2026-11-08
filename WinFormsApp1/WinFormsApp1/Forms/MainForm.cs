using System.ComponentModel;
using SchoolTimetable.Data;
using SchoolTimetable.Models;

namespace SchoolTimetable.Forms;

public class MainForm : Form
{
    private readonly TimetableData _data = new();
    private readonly ToolStripStatusLabel _statusLabel = new();

    public MainForm()
    {
        Text = "Editor školního rozvrhu";
        ClientSize = new Size(1000, 650);
        MinimumSize = new Size(700, 450);
        StartPosition = FormStartPosition.CenterScreen;

        var placeholder = new Label
        {
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            ForeColor = SystemColors.GrayText,
            Font = new Font(Font.FontFamily, 14f),
            Text = "Týdenní mřížka rozvrhu bude doplněna ve 2. kontrolním bodu."
        };

        var toolbar = new FlowLayoutPanel { Dock = DockStyle.Top, AutoSize = true, Padding = new Padding(8) };
        toolbar.Controls.Add(CreateButton("Třídy", OpenClasses));
        toolbar.Controls.Add(CreateButton("Učitelé", OpenTeachers));
        toolbar.Controls.Add(CreateButton("Učebny", OpenClassrooms));
        toolbar.Controls.Add(CreateButton("Předměty", OpenSubjects));

        var statusStrip = new StatusStrip();
        statusStrip.Items.Add(_statusLabel);

        var menu = BuildMenu();
        MainMenuStrip = menu;

        Controls.Add(placeholder);
        Controls.Add(toolbar);
        Controls.Add(statusStrip);
        Controls.Add(menu);

        UpdateStatus();
    }

    private MenuStrip BuildMenu()
    {
        var menu = new MenuStrip();

        var file = new ToolStripMenuItem("Soubor");
        file.DropDownItems.Add("Konec", null, (_, _) => Close());

        var lists = new ToolStripMenuItem("Seznamy");
        lists.DropDownItems.Add("Třídy…", null, (_, _) => OpenClasses());
        lists.DropDownItems.Add("Učitelé…", null, (_, _) => OpenTeachers());
        lists.DropDownItems.Add("Učebny…", null, (_, _) => OpenClassrooms());
        lists.DropDownItems.Add("Předměty…", null, (_, _) => OpenSubjects());

        menu.Items.Add(file);
        menu.Items.Add(lists);
        return menu;
    }

    private static Button CreateButton(string text, Action onClick)
    {
        var button = new Button { Text = text, Width = 110, Height = 32 };
        button.Click += (_, _) => onClick();
        return button;
    }

    private void OpenClasses() =>
        OpenEditor("Třídy", "Název třídy", _data.Classes);

    private void OpenTeachers() =>
        OpenEditor("Učitelé", "Jméno učitele", _data.Teachers, true, "Zkratka (např. NOV)");

    private void OpenClassrooms() =>
        OpenEditor("Učebny", "Označení učebny", _data.Classrooms);

    private void OpenSubjects() =>
        OpenEditor("Předměty", "Název předmětu", _data.Subjects, true, "Zkratka (např. MAT)");

    private void OpenEditor<T>(
        string title,
        string nameLabel,
        BindingList<T> items,
        bool useShortName = false,
        string shortLabel = "Zkratka") where T : NamedItem, new()
    {
        using var form = new ListEditorForm<T>(title, nameLabel, items, useShortName, shortLabel);
        form.ShowDialog(this);
        UpdateStatus();
    }

    private void UpdateStatus()
    {
        _statusLabel.Text =
            $"Třídy: {_data.Classes.Count}   |   Učitelé: {_data.Teachers.Count}   |   " +
            $"Učebny: {_data.Classrooms.Count}   |   Předměty: {_data.Subjects.Count}";
    }
}
