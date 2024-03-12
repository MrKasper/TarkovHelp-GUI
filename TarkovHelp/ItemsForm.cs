using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TarkovHelp
{
    public partial class ItemsForm : Form
    {
        #region Для перетаскивания
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        private static readonly SystemItems _items = new SystemItems(SystemItems.MaxItem);
        private SQLiteConnection DB;
        public ItemsForm()
        {
            InitializeComponent();
        }

        private async void ItemsForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection($"{Database.connectionDB}");
            await DB.OpenAsync();
        }

        private void DrawPanelItems(int countQuest) //Параметры для рисования объектов 
        {
            flowLayoutPanel1.Controls.Clear();

            for (int i = 1; i <= countQuest; i++)
            {
                Panel pn = new Panel();
                pn.BorderStyle = BorderStyle.FixedSingle;
                pn.Size = new Size(162, 217);
                flowLayoutPanel1.Controls.Add(pn);

                PictureBox picture = new PictureBox();
                picture.Size = new Size(156, 91);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Location = new Point(3, 3);
                picture.Name = "picture" + i;
                picture.BorderStyle = BorderStyle.FixedSingle;
                pn.Controls.Add(picture);

                Label headLabel = new Label();
                headLabel.Size = new Size(156, 23);
                headLabel.Text = $"Salewa first aid kit" + i;
                headLabel.Font = new Font("Arial", 9.75f);
                headLabel.TextAlign = ContentAlignment.MiddleCenter;
                headLabel.Location = new Point(3, 97);
                headLabel.Name = "headLabel" + i;
                pn.Controls.Add(headLabel);

                Label infoLabel = new Label();
                infoLabel.Size = new Size(156, 58);
                infoLabel.Text = "Gunsmith - Part 1 " + i;
                infoLabel.Font = new Font("Arial", 9.75f);
                infoLabel.Location = new Point(3, 120);
                infoLabel.TextAlign = ContentAlignment.MiddleCenter;
                infoLabel.Name = "infoLabel" + i;
                pn.Controls.Add(infoLabel);

                Button fillBtn = new Button();
                fillBtn.Size = new Size(156, 33);
                fillBtn.Location = new Point(3, 181);
                fillBtn.Text = "0/2500000";
                fillBtn.Cursor = Cursors.Hand;
                fillBtn.Name = "fillBtn" + i;
                pn.Controls.Add(fillBtn);
                fillBtn.Click += FillButtonClick;

                headLabel.Text = _items.items[i - 1].Title;
                infoLabel.Text = _items.items[i - 1].ForWhat;
                fillBtn.Text = "0/" + _items.items[i - 1].Count;
                fillBtn.Name = _items.items[i - 1].Count;
                picture.Image = _items.items[i - 1].PictureQuest;
            }
        }

        public void FillButtonClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                if (button.Text == $"{button.Name}/{button.Name}")
                {
                    button.BackColor = Color.White;
                    button.Text = $"0/{button.Name}";
                    button.ForeColor = Color.Black;
                }
                else
                {
                    button.BackColor = Color.Green;
                    button.Text = $"{button.Name}/{button.Name}";
                    button.ForeColor = Color.White;
                }
            }
        }

        private async void AllItemsBtn_Click(object sender, EventArgs e)
        {
            comboBoxFilterShelter.Visible = false;
            _items.items = new List<Item>();
            Quest.MaxItem = 0;
            int countQuester = 0;
            SQLiteDataReader sqlReader = null;
            Image Picture; //Создаем новую переменную
            SQLiteCommand command = new SQLiteCommand($"SELECT COUNT (*) FROM {Items.main}", DB);
            {
                countQuester = Convert.ToInt32(command.ExecuteScalar());
                Quest.MaxItem = Convert.ToInt32(countQuester);
                await command.ExecuteNonQueryAsync();
            }
            SQLiteCommand commandSelect = new SQLiteCommand($"SELECT * FROM {Items.main}", DB);
            {
                sqlReader = (SQLiteDataReader)await commandSelect.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    object title = sqlReader.GetValue(2);
                    object forWhat = sqlReader.GetValue(3);
                    object count = sqlReader.GetValue(4);

                    byte[] imageData = (byte[])sqlReader["Picture"]; //Считываем картинку
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        Picture = Image.FromStream(stream); //Записываем картинку

                    }
                    _items.CreateItem(title.ToString(), forWhat.ToString(), count.ToString(), Picture); //Создаем элементы
                }
            }
            DrawPanelItems(countQuester);
        }

        private async void QuestsBtn_Click(object sender, EventArgs e)
        {
            comboBoxFilterShelter.Visible = false;
            _items.items = new List<Item>();
            Quest.MaxItem = 0;
            int countQuester = 0;
            SQLiteDataReader sqlReader = null;
            Image Picture; //Создаем новую переменную
            SQLiteCommand command = new SQLiteCommand($"SELECT COUNT (*) FROM {Items.main} WHERE ({Items.TypeItems}) LIKE 'Задания' ", DB);
            {
                countQuester = Convert.ToInt32(command.ExecuteScalar());
                Quest.MaxItem = Convert.ToInt32(countQuester);
                await command.ExecuteNonQueryAsync();
            }
            SQLiteCommand commandSelect = new SQLiteCommand($"SELECT * FROM {Items.main} WHERE ({Items.TypeItems}) LIKE 'Задания' ", DB);
            {
                sqlReader = (SQLiteDataReader)await commandSelect.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    object title = sqlReader.GetValue(2);
                    object forWhat = sqlReader.GetValue(3);
                    object count = sqlReader.GetValue(4);

                    byte[] imageData = (byte[])sqlReader["Picture"]; //Считываем картинку
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        Picture = Image.FromStream(stream); //Записываем картинку

                    }
                    _items.CreateItem(title.ToString(), forWhat.ToString(), count.ToString(), Picture); //Создаем элементы
                }
            }
            DrawPanelItems(countQuester);
        }

        private async void ShelterBtn_Click(object sender, EventArgs e)
        {
            comboBoxFilterShelter.Visible = true;
            comboBoxFilterShelter.SelectedItem = "Все компоненты";
            _items.items = new List<Item>();
            Quest.MaxItem = 0;
            int countQuester = 0;
            SQLiteDataReader sqlReader = null;
            Image Picture; //Создаем новую переменную
            SQLiteCommand command = new SQLiteCommand($"SELECT COUNT (*) FROM {Items.main} WHERE ({Items.TypeItems}) LIKE 'Убежище' ", DB);
            {
                countQuester = Convert.ToInt32(command.ExecuteScalar());
                Quest.MaxItem = Convert.ToInt32(countQuester);
                await command.ExecuteNonQueryAsync();
            }
            SQLiteCommand commandSelect = new SQLiteCommand($"SELECT * FROM {Items.main} WHERE ({Items.TypeItems}) LIKE 'Убежище' ", DB);
            {
                sqlReader = (SQLiteDataReader)await commandSelect.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    object title = sqlReader.GetValue(2);
                    object forWhat = sqlReader.GetValue(3);
                    object count = sqlReader.GetValue(4);

                    byte[] imageData = (byte[])sqlReader["Picture"]; //Считываем картинку
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        Picture = Image.FromStream(stream); //Записываем картинку

                    }
                    _items.CreateItem(title.ToString(), forWhat.ToString(), count.ToString(), Picture); //Создаем элементы
                }
            }
            DrawPanelItems(countQuester);
        }

        private async void comboBoxFilterShelter_TextChanged(object sender, EventArgs e)
        {
            string text = comboBoxFilterShelter.Text;
            _items.items = new List<Item>();
            Quest.MaxItem = 0;
            int countQuester = 0;
            SQLiteDataReader sqlReader = null;
            Image Picture; //Создаем новую переменную
            SQLiteCommand command = new SQLiteCommand($"SELECT COUNT (*) FROM {Items.main} WHERE ({Items.TypeItems}) LIKE 'Убежище' AND ({Items.ForWhat}) LIKE '{text}%'", DB);
            {
                countQuester = Convert.ToInt32(command.ExecuteScalar());
                Quest.MaxItem = Convert.ToInt32(countQuester);
                await command.ExecuteNonQueryAsync();
            }
            SQLiteCommand commandSelect = new SQLiteCommand($"SELECT * FROM {Items.main} WHERE ({Items.TypeItems}) LIKE 'Убежище' AND ({Items.ForWhat}) LIKE '{text}%'", DB);
            {
                sqlReader = (SQLiteDataReader)await commandSelect.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    object title = sqlReader.GetValue(2);
                    object forWhat = sqlReader.GetValue(3);
                    object count = sqlReader.GetValue(4);

                    byte[] imageData = (byte[])sqlReader["Picture"]; //Считываем картинку
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        Picture = Image.FromStream(stream); //Записываем картинку

                    }
                    _items.CreateItem(title.ToString(), forWhat.ToString(), count.ToString(), Picture); //Создаем элементы
                }
            }
            DrawPanelItems(countQuester);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Form fMain = new MainForm();
            fMain.Show();
            fMain.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }

        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        #region Перетаскивание формы
        private void DragAndDrop(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
    }
}