using System.ComponentModel;
using SchoolTimetable.Models;
using SchoolTimetable.Validation;

namespace SchoolTimetable.Forms;

public class ListEditorForm<T> : Form where T : NamedItem, new()
{
    private readonly BindingList<T> _items;
    private readonly bool _useShortName;

    private readonly ListBox _listBox = new() { Dock = DockStyle.Fill, IntegralHeight = false };
    private readonly TextBox _nameBox = new() { Width = 250 };
    private readonly TextBox _shortBox = new() { Width = 250 };
    private readonly Label _errorLabel = new() { ForeColor = Color.Firebrick, AutoSize = false, Width = 250, Height = 44 };
    private readonly Button _newButton = new() { Text = "Nový", Width = 80 };
    private readonly Button _addButton = new() { Text = "Přidat", Width = 80 };
    private readonly Button _saveButton = new() { Text = "Uložit", Width = 80 };
    private readonly Button _deleteButton = new() { Text = "Smazat vybranou položku", Width = 250 };

    public ListEditorForm(
        string title,
        string nameLabel,
        BindingList<T> items,
        bool useShortName = false,
        string shortLabel = "Zkratka")
    {
        _items = items;
        _useShortName = useShortName;

        Text = title;
        ClientSize = new Size(600, 380);
        MinimumSize = new Size(560, 340);
        StartPosition = FormStartPosition.CenterParent;

        var rightPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Right,
            Width = 290,
            Padding = new Padding(12),
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false
        };

        rightPanel.Controls.Add(new Label { Text = nameLabel, AutoSize = true });
        rightPanel.Controls.Add(_nameBox);

        if (_useShortName)
        {
            rightPanel.Controls.Add(new Label { Text = shortLabel, AutoSize = true, Margin = new Padding(3, 10, 3, 0) });
            rightPanel.Controls.Add(_shortBox);
        }

        var buttonRow = new FlowLayoutPanel { AutoSize = true, Width = 250, Margin = new Padding(0, 10, 0, 0) };
        buttonRow.Controls.AddRange(new Control[] { _newButton, _addButton, _saveButton });
        rightPanel.Controls.Add(buttonRow);
        rightPanel.Controls.Add(_deleteButton);
        rightPanel.Controls.Add(_errorLabel);

        Controls.Add(_listBox);
        Controls.Add(rightPanel);

        _listBox.SelectedIndexChanged += (_, _) => OnSelectionChanged();
        _newButton.Click += (_, _) => NewItem();
        _addButton.Click += (_, _) => AddItem();
        _saveButton.Click += (_, _) => SaveItem();
        _deleteButton.Click += (_, _) => DeleteItem();

        RefreshList();
    }

    private T? Selected => _listBox.SelectedItem as T;

    private void RefreshList(T? select = null)
    {
        _listBox.BeginUpdate();
        _listBox.Items.Clear();
        foreach (var item in _items)
            _listBox.Items.Add(item);
        _listBox.EndUpdate();

        if (select != null)
            _listBox.SelectedItem = select;

        UpdateButtons();
    }

    private void OnSelectionChanged()
    {
        _errorLabel.Text = "";
        if (Selected is { } item)
        {
            _nameBox.Text = item.Name;
            _shortBox.Text = item.ShortName;
        }
        else
        {
            _nameBox.Clear();
            _shortBox.Clear();
        }
        UpdateButtons();
    }

    private void UpdateButtons()
    {
        bool hasSelection = Selected != null;
        _saveButton.Enabled = hasSelection;
        _deleteButton.Enabled = hasSelection;
    }

    private void NewItem()
    {
        _listBox.SelectedIndex = -1;
        _nameBox.Clear();
        _shortBox.Clear();
        _errorLabel.Text = "";
        _nameBox.Focus();
    }

    private void AddItem()
    {
        var error = InputValidator.Validate(
            _nameBox.Text, _shortBox.Text, _useShortName, _items.Cast<NamedItem>(), null);
        if (error != null)
        {
            _errorLabel.Text = error;
            return;
        }

        var item = new T
        {
            Name = _nameBox.Text.Trim(),
            ShortName = _useShortName ? _shortBox.Text.Trim() : ""
        };
        _items.Add(item);
        RefreshList(item);
    }

    private void SaveItem()
    {
        if (Selected is not { } item)
            return;

        var error = InputValidator.Validate(
            _nameBox.Text, _shortBox.Text, _useShortName, _items.Cast<NamedItem>(), item);
        if (error != null)
        {
            _errorLabel.Text = error;
            return;
        }

        item.Name = _nameBox.Text.Trim();
        item.ShortName = _useShortName ? _shortBox.Text.Trim() : "";
        RefreshList(item);
    }

    private void DeleteItem()
    {
        if (Selected is not { } item)
            return;

        var answer = MessageBox.Show(
            this,
            $"Opravdu smazat položku „{item.Name}“?",
            "Potvrzení smazání",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (answer != DialogResult.Yes)
            return;

        _items.Remove(item);
        RefreshList();
    }
}
