using System.Text;

namespace Lab2;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new PhoneBookForm());
    }
}

// Один об'єкт — один запис довідника.
class Contact
{
    public string Surname, Name, Phone, Address;
    public Contact(string surname, string name, string phone, string address)
    {
        Surname = surname; Name = name; Phone = phone; Address = address;
    }
}

class PhoneBookForm : Form
{
    readonly List<Contact> contacts = new();
    readonly DataGridView grid = new();
    readonly ComboBox people = new();
    readonly TextBox surname = new(), name = new(), phone = new(), address = new();
    readonly TextBox search = new();
    readonly TabControl tabs = new();
    bool changed;

    public PhoneBookForm()
    {
        Text = "Телефонний довідник";
        ClientSize = new Size(760, 430);
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;

        var menu = new MenuStrip();
        var file = new ToolStripMenuItem("Файл");
        file.DropDownItems.Add("Відкрити…", null, (s, e) => OpenFile());
        file.DropDownItems.Add("Зберегти…", null, (s, e) => SaveFile());
        file.DropDownItems.Add("Кінець", null, (s, e) => Close());
        var sort = new ToolStripMenuItem("Впорядкувати за алфавітом");
        sort.DropDownItems.Add("А → Я", null, (s, e) => SortContacts(false));
        sort.DropDownItems.Add("Я → А", null, (s, e) => SortContacts(true));
        menu.Items.Add(file);
        menu.Items.Add(sort);
        menu.Items.Add("Про програму", null, (s, e) => ShowAbout());
        MainMenuStrip = menu;

        tabs.SetBounds(10, 35, 740, 385);
        var listPage = new TabPage("Список всіх записів");
        var editPage = new TabPage("Редагування та пошук записів");
        tabs.TabPages.AddRange(new[] { listPage, editPage });
        Controls.Add(tabs);
        Controls.Add(menu);

        grid.Dock = DockStyle.Fill;
        grid.ReadOnly = true;
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.MultiSelect = false;
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        foreach (string title in new[] { "Прізвище", "Ім’я", "Телефон", "Адреса" })
        {
            int column = grid.Columns.Add(title, title);
            grid.Columns[column].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        grid.CellDoubleClick += (s, e) =>
        {
            if (e.RowIndex < 0) return;
            people.SelectedIndex = e.RowIndex;
            tabs.SelectedIndex = 1;
        };
        listPage.Controls.Add(grid);

        AddLabel(editPage, "Виберіть запис:", 15, 20);
        people.SetBounds(160, 16, 530, 28);
        people.DropDownStyle = ComboBoxStyle.DropDownList;
        people.SelectedIndexChanged += (s, e) => ShowContact();
        editPage.Controls.Add(people);

        AddField(editPage, "Прізвище:", surname, 60, 20);
        AddField(editPage, "Ім’я:", name, 100, 20);
        AddField(editPage, "Телефон:", phone, 140, 15);
        AddField(editPage, "Адреса:", address, 180, 100);
        AddButton(editPage, "Новий", 15, 225, ClearFields);
        AddButton(editPage, "Зберегти запис", 190, 225, SaveContact);
        AddButton(editPage, "Стерти", 365, 225, DeleteContact);
        AddButton(editPage, "Перший", 15, 265, () => SelectContact(0));
        AddButton(editPage, "Попередній", 190, 265, () => SelectContact(people.SelectedIndex - 1));
        AddButton(editPage, "Наступний", 365, 265, () => SelectContact(people.SelectedIndex + 1));
        AddButton(editPage, "Останній", 540, 265, () => SelectContact(contacts.Count - 1));
        AddLabel(editPage, "Пошук прізвища:", 15, 315);
        search.SetBounds(160, 310, 355, 28);
        search.MaxLength = 20;
        editPage.Controls.Add(search);
        AddButton(editPage, "Знайти", 540, 308, FindContact);
        FormClosing += (s, e) => e.Cancel = !ConfirmSave();
    }

    static void AddLabel(Control parent, string text, int x, int y)
    {
        parent.Controls.Add(new Label { Text = text, Left = x, Top = y, AutoSize = true });
    }

    static void AddField(Control parent, string title, TextBox box, int y, int maxLength)
    {
        AddLabel(parent, title, 15, y + 4);
        box.SetBounds(160, y, 530, 28);
        box.MaxLength = maxLength;
        parent.Controls.Add(box);
    }

    static void AddButton(Control parent, string title, int x, int y, Action action)
    {
        var button = new Button { Text = title, Left = x, Top = y, Width = 155, Height = 32 };
        button.Click += (s, e) => action();
        parent.Controls.Add(button);
    }

    // Таблиця і список завжди будуються з одного списку contacts.
    void RefreshList(int selected = -1)
    {
        people.Items.Clear();
        grid.Rows.Clear();
        foreach (Contact c in contacts)
        {
            people.Items.Add(c.Surname + " " + c.Name);
            grid.Rows.Add(c.Surname, c.Name, c.Phone, c.Address);
        }
        ClearFields();
        if (selected >= 0) SelectContact(selected);
    }

    void SelectContact(int index)
    {
        if (contacts.Count == 0) return;
        people.SelectedIndex = Math.Clamp(index, 0, contacts.Count - 1);
    }

    void ShowContact()
    {
        int i = people.SelectedIndex;
        if (i < 0) return;
        Contact c = contacts[i];
        surname.Text = c.Surname; name.Text = c.Name;
        phone.Text = c.Phone; address.Text = c.Address;
        grid.ClearSelection();
        grid.Rows[i].Selected = true;
    }

    void ClearFields()
    {
        people.SelectedIndex = -1;
        surname.Clear(); name.Clear(); phone.Clear(); address.Clear();
        grid.ClearSelection();
    }

    void SaveContact()
    {
        string[] fields = { surname.Text.Trim(), name.Text.Trim(), phone.Text.Trim(), address.Text.Trim() };
        if (fields[0] == "" || fields.Any(f => f.IndexOfAny(new[] { '\t', '\r', '\n' }) >= 0))
        {
            MessageBox.Show("Введіть прізвище. Поля не повинні містити табуляцій або переносів рядка.");
            return;
        }
        var c = new Contact(fields[0], fields[1], fields[2], fields[3]);
        int i = people.SelectedIndex;
        if (i < 0) { contacts.Add(c); i = contacts.Count - 1; }
        else contacts[i] = c;
        changed = true;
        RefreshList(i);
    }

    void DeleteContact()
    {
        int i = people.SelectedIndex;
        if (i < 0) return;
        contacts.RemoveAt(i);
        changed = true;
        RefreshList();
    }

    void FindContact()
    {
        int i = contacts.FindIndex(c => string.Equals(c.Surname, search.Text.Trim(),
                                                     StringComparison.CurrentCultureIgnoreCase));
        if (i < 0) MessageBox.Show("Такого прізвища немає.", "Пошук");
        else { people.SelectedIndex = i; ShowContact(); }
    }

    void SortContacts(bool reverse)
    {
        contacts.Sort((a, b) => reverse
            ? string.Compare(b.Surname, a.Surname, StringComparison.CurrentCulture)
            : string.Compare(a.Surname, b.Surname, StringComparison.CurrentCulture));
        if (contacts.Count > 1) changed = true;
        RefreshList();
    }

    // Один рядок файлу: прізвище, ім'я, телефон, адреса; роздільник — табуляція.
    bool SaveFile()
    {
        using var dialog = new SaveFileDialog { Filter = "Текстові файли|*.txt", FileName = "contacts.txt" };
        if (dialog.ShowDialog() != DialogResult.OK) return false;
        try
        {
            File.WriteAllLines(dialog.FileName, contacts.Select(c =>
                string.Join("\t", c.Surname, c.Name, c.Phone, c.Address)), Encoding.UTF8);
            changed = false;
            return true;
        }
        catch (Exception ex) { MessageBox.Show("Не вдалося зберегти: " + ex.Message); return false; }
    }

    void OpenFile()
    {
        if (!ConfirmSave()) return;
        using var dialog = new OpenFileDialog { Filter = "Текстові файли|*.txt" };
        if (dialog.ShowDialog() != DialogResult.OK) return;
        try
        {
            var loaded = new List<Contact>();
            foreach (string line in File.ReadAllLines(dialog.FileName, Encoding.UTF8))
            {
                string[] f = line.Split('\t');
                if (f.Length != 4 || string.IsNullOrWhiteSpace(f[0]) ||
                    f[0].Length > 20 || f[1].Length > 20 || f[2].Length > 15 || f[3].Length > 100)
                    throw new FormatException("Неправильний формат запису.");
                loaded.Add(new Contact(f[0], f[1], f[2], f[3]));
            }
            contacts.Clear();
            contacts.AddRange(loaded);
            changed = false;
            RefreshList();
        }
        catch (Exception ex) { MessageBox.Show("Не вдалося відкрити: " + ex.Message); }
    }

    bool ConfirmSave()
    {
        if (!changed) return true;
        var answer = MessageBox.Show("Зберегти зміни у файл?", "Телефонний довідник",
                                     MessageBoxButtons.YesNoCancel);
        return answer == DialogResult.No || (answer == DialogResult.Yes && SaveFile());
    }

    void ShowAbout()
    {
        using var about = new Form { Text = "Про програму", ClientSize = new Size(350, 130),
            StartPosition = FormStartPosition.CenterParent, MaximizeBox = false, MinimizeBox = false };
        AddLabel(about, "Практична робота №2\nТелефонний довідник. C# / Windows Forms.", 15, 15);
        AddButton(about, "OK", 95, 75, () => about.Close());
        about.ShowDialog(this);
    }
}
