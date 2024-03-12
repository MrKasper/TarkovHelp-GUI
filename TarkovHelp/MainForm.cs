using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TarkovHelp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static readonly Quest _quest = new Quest(Quest.MaxItem);
        private SQLiteConnection DB;

        #region Для перетаскивания
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private async void MainForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection($"{Database.connectionDB}");
            await DB.OpenAsync();
            CheckPinQuest();
            CheckDoneQuests();
        }

        private async void CheckDoneQuests()
        {
            int allQuests = 0;
            int doneQuests = 0;
            SQLiteCommand commandAll = new SQLiteCommand($"SELECT COUNT (*) FROM {Quests.main}", DB);
            {
                allQuests = Convert.ToInt32(commandAll.ExecuteScalar());
                await commandAll.ExecuteNonQueryAsync();
            }
            SQLiteCommand command = new SQLiteCommand($"SELECT COUNT (*) FROM {Quests.main} WHERE ({Quests.Done})=@done", DB);
            {
                command.Parameters.AddWithValue("@done", "true");
                doneQuests = Convert.ToInt32(command.ExecuteScalar());
                await command.ExecuteNonQueryAsync();
            }
            labelQuests.Text = $"{doneQuests}/{allQuests}";
        }

        private async void CheckPinQuest()
        {
            _quest.items = new List<Item_Quest>();
            Quest.MaxItem = 0;
            int countQuester = 0;
            SQLiteDataReader sqlReader = null;
            Image Picture; //Создаем новую переменную
            SQLiteCommand command = new SQLiteCommand($"SELECT COUNT (*) FROM {Quests.main} WHERE ({Quests.Pin})=@pin", DB);
            {
                command.Parameters.AddWithValue("@pin", "true");
                countQuester = Convert.ToInt32(command.ExecuteScalar());
                Quest.MaxItem = Convert.ToInt32(countQuester);
                await command.ExecuteNonQueryAsync();
            }
            SQLiteCommand commandSelect = new SQLiteCommand($"SELECT * FROM {Quests.main} WHERE ({Quests.Pin})=@pin", DB);
            {
                commandSelect.Parameters.AddWithValue("@pin", "true");
                sqlReader = (SQLiteDataReader)await commandSelect.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    object quester = sqlReader.GetValue(1);
                    object title = sqlReader.GetValue(2);
                    object questGoal = sqlReader.GetValue(3);
                    object dialogBefore = sqlReader.GetValue(4);
                    object dialogAfter = sqlReader.GetValue(5);
                    object reward = sqlReader.GetValue(6);
                    object done = sqlReader.GetValue(10);
                    object pin = sqlReader.GetValue(11);
                    object howDone = sqlReader.GetValue(12);

                    byte[] imageData = (byte[])sqlReader["Picture"]; //Считываем картинку
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        Picture = Image.FromStream(stream); //Записываем картинку

                    }
                    _quest.CreateItem(quester.ToString(), title.ToString(), questGoal.ToString(), dialogBefore.ToString(), dialogAfter.ToString(), reward.ToString(), Picture, done.ToString(), pin.ToString(), howDone.ToString()); //Создаем элементы
                }
            }
            DrawPanelQuests(countQuester);
        }

        private void DrawPanelQuests(int countQuest) //Параметры для рисования объектов 
        {
            flowLayoutPanel1.Controls.Clear();

            for (int i = 1; i <= countQuest; i++)
            {
                Panel pn = new Panel();
                pn.BorderStyle = BorderStyle.FixedSingle;
                pn.Size = new Size(162, 260);
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
                headLabel.Text = $"Example" + i;
                headLabel.TextAlign = ContentAlignment.MiddleCenter;
                headLabel.Location = new Point(3, 97);
                headLabel.Name = "headLabel" + i;
                pn.Controls.Add(headLabel);

                Label infoLabel = new Label();
                infoLabel.Size = new Size(156, 58);
                infoLabel.Text = "More info " + i;
                infoLabel.Location = new Point(3, 120);
                infoLabel.Name = "infoLabel" + i;
                pn.Controls.Add(infoLabel);

                Button moreBtn = new Button();
                moreBtn.Size = new Size(78, 33);
                moreBtn.Location = new Point(3, 181);
                moreBtn.Text = "More";
                moreBtn.Cursor = Cursors.Hand;
                moreBtn.Name = "moreBtn" + i;
                pn.Controls.Add(moreBtn);
                moreBtn.Click += MoreInfoButtonClick;

                Button fastBtn = new Button();
                fastBtn.Size = new Size(78, 33);
                fastBtn.Location = new Point(81, 181);
                fastBtn.Text = "Fast";
                fastBtn.Cursor = Cursors.Hand;
                fastBtn.Name = "fastBtn" + i;
                pn.Controls.Add(fastBtn);
                fastBtn.Click += FastInfoButtonClick;

                Button doneBtn = new Button();
                doneBtn.Size = new Size(156, 33);
                doneBtn.Location = new Point(3, 220);
                doneBtn.Text = "Done";
                doneBtn.Cursor = Cursors.Hand;
                doneBtn.Name = "doneBtn" + i;
                doneBtn.FlatStyle = FlatStyle.Flat;
                doneBtn.FlatAppearance.BorderSize = 0;
                doneBtn.BackColor = Color.White;
                pn.Controls.Add(doneBtn);
                doneBtn.Click += DoneButtonClick;

                Button pin = new Button();
                pin.Size = new Size(20, 20);
                pin.Location = new Point(133, 3);
                pin.Cursor = Cursors.Hand;
                pin.Text = "*";
                pin.TextAlign = ContentAlignment.MiddleCenter;
                pin.Font = new Font("Arial", 11f);
                pin.FlatStyle = FlatStyle.Flat;
                pin.FlatAppearance.BorderSize = 0;
                picture.Controls.Add(pin);
                pin.Click += PinButtonClick;

                headLabel.Text = _quest.items[i - 1].Title;
                infoLabel.Text = _quest.items[i - 1].DialogBefore;
                picture.Image = _quest.items[i - 1].PictureQuest;
                fastBtn.Name = $"{_quest.items[i - 1].Title};" +
                    $"{_quest.items[i - 1].QuestGoal};" +
                    $"{_quest.items[i - 1].Reward}";
                moreBtn.Name = $"{_quest.items[i - 1].Who};" +
                    $"{_quest.items[i - 1].Title};" +
                    $"{_quest.items[i - 1].QuestGoal};" +
                    $"{_quest.items[i - 1].DialogBefore};" +
                    $"{_quest.items[i - 1].DialogAfter};" +
                    $"{_quest.items[i - 1].Reward};" +
                    $"{_quest.items[i - 1].Done};" +
                    $"{_quest.items[i - 1].HowDone}";
                pin.Name = $"{_quest.items[i - 1].Title};" +
                    $"{_quest.items[i - 1].QuestGoal};" +
                    $"{_quest.items[i - 1].DialogBefore};" +
                    $"{_quest.items[i - 1].DialogAfter};" +
                    $"{_quest.items[i - 1].Reward}";
                doneBtn.Name = $"{_quest.items[i - 1].Title};" +
                    $"{_quest.items[i - 1].QuestGoal};" +
                    $"{_quest.items[i - 1].DialogBefore};" +
                    $"{_quest.items[i - 1].DialogAfter};" +
                    $"{_quest.items[i - 1].Reward}";

                if (_quest.items[i - 1].Pin == "false" || _quest.items[i - 1].Pin == null)
                {
                    pin.BackColor = Color.White;
                    pin.ForeColor = Color.Black;
                }
                else if (_quest.items[i - 1].Pin == "true")
                {
                    pin.BackColor = Color.Green;
                    pin.ForeColor = Color.White;
                }

                if (_quest.items[i - 1].Done == "false" || _quest.items[i - 1].Done == null)
                {
                    doneBtn.BackColor = Color.White;
                    doneBtn.ForeColor = Color.Black;
                }
                else if (_quest.items[i - 1].Done == "true")
                {
                    doneBtn.BackColor = Color.Green;
                    doneBtn.ForeColor = Color.White;
                }
            }
        }

        public void MoreInfoButtonClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                string[] advName = Convert.ToString(button.Name).Split(';');
                DataQuests.Quester = advName[0];
                DataQuests.QuestName = advName[1];
                DataQuests.QuestGoal = advName[2];
                DataQuests.DialogBefore = advName[3];
                DataQuests.DialogAfter = advName[4];
                DataQuests.Reward = advName[5];
                DataQuests.Done = advName[6];
                DataQuests.HowDone = advName[7];
                Form fInfoQuest = new QuestCard();
                fInfoQuest.Show();
            }
        }

        public void FastInfoButtonClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                string[] advName = Convert.ToString(button.Name).Split(';');
                MessageBox.Show($"Задача:\n{advName[1]}\n\nНаграда:\n{advName[2]}", $"{advName[0]}");
            }
        }

        public async void DoneButtonClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                string[] advName = Convert.ToString(button.Name).Split(';');
                if (button.ForeColor == Color.White)
                {
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                    SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Quests.main} SET {Quests.Done}=@done WHERE {Quests.QuestName}=@questName", DB);
                    commandUpdate.Parameters.AddWithValue("@done", "false");
                    commandUpdate.Parameters.AddWithValue("@questName", advName[0]);
                    await commandUpdate.ExecuteNonQueryAsync();
                }
                else
                {
                    button.BackColor = Color.Green;
                    button.ForeColor = Color.White;
                    SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Quests.main} SET {Quests.Done}=@done WHERE {Quests.QuestName}=@questName", DB);
                    commandUpdate.Parameters.AddWithValue("@done", "true");
                    commandUpdate.Parameters.AddWithValue("@questName", advName[0]);
                    await commandUpdate.ExecuteNonQueryAsync();
                }
            }
        }

        public async void PinButtonClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                string[] advName = Convert.ToString(button.Name).Split(';');
                if (button.ForeColor == Color.White)
                {
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                    SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Quests.main} SET {Quests.Pin}=@pin WHERE {Quests.QuestName}=@questName", DB);
                    commandUpdate.Parameters.AddWithValue("@pin", "false");
                    commandUpdate.Parameters.AddWithValue("@questName", advName[0]);
                    await commandUpdate.ExecuteNonQueryAsync();
                    CheckPinQuest();
                }
                else
                {
                    button.BackColor = Color.Green;
                    button.ForeColor = Color.White;
                    SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Quests.main} SET {Quests.Pin}=@pin WHERE {Quests.QuestName}=@questName", DB);
                    commandUpdate.Parameters.AddWithValue("@pin", "true");
                    commandUpdate.Parameters.AddWithValue("@questName", advName[0]);
                    await commandUpdate.ExecuteNonQueryAsync();
                }
            }
        }

        private void buttonQuests_Click(object sender, EventArgs e)
        {
            Form fQuests = new QuestForm();
            fQuests.Show();
            fQuests.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            Form fItems = new ItemsForm();
            fItems.Show();
            fItems.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }

        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void AdminPanelBtn_Click(object sender, EventArgs e)
        {
            Form fAdminka = new AdminPanel();
            fAdminka.Show();
            fAdminka.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
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

        private void buttonFleaMarket_Click(object sender, EventArgs e)
        {
            Form fFlea = new FleaMarketForm();
            fFlea.Show();
            //fFlea.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            //this.Hide();
        }

        private void buttonAssemblys_Click(object sender, EventArgs e)
        {
            Form fAssemblys = new AssemblysForm();
            fAssemblys.Show();
            fAssemblys.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }
    }
}
