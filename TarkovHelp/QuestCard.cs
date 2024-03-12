using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TarkovHelp
{
    public partial class QuestCard : Form
    {
        
        public QuestCard()
        {
            InitializeComponent();
        }
        
        private SQLiteConnection DB;

        #region Для перетаскивания
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private async void QuestCard_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection($"{Database.connectionDB}");
            await DB.OpenAsync();

            labelWho.Text = "Выдает: " + DataQuests.Quester;
            labelQuestName.Text = "Квест " + DataQuests.QuestName;
            GoalQuest.Text = DataQuests.QuestGoal;
            labelReward.Text = DataQuests.Reward;
            DialogBefore.Text = DataQuests.DialogBefore;
            DialogAfter.Text = DataQuests.DialogAfter;
            HowDone.Text = DataQuests.HowDone;
            PictureQuest();

            if (DataQuests.Done == "false" || DataQuests.Done == null)
            {
                buttonDone.BackColor = Color.FromArgb(97, 97, 97);
                buttonDone.Text = "Не выполнено";
            }
            else if (DataQuests.Done == "true")
            {
                buttonDone.BackColor = Color.Green;
                buttonDone.Text = "Выполнено";
            }
        }

        private async void PictureQuest()
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand commandSelect = new SQLiteCommand($"SELECT * FROM {Quests.main} WHERE ({Quests.QuestName}) LIKE '{DataQuests.QuestName}' ", DB);
            {
                sqlReader = (SQLiteDataReader)await commandSelect.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    byte[] imageData = (byte[])sqlReader["Picture"]; //Считываем картинку
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        pictureBoxQuest.Image = Image.FromStream(stream); //Записываем картинку

                    }
                }
            }
        }

        private async void buttonDone_Click(object sender, EventArgs e)
        {
            if (buttonDone.BackColor == Color.Green)
            {
                buttonDone.BackColor = Color.FromArgb(97, 97, 97);
                buttonDone.Text = "Не выполнено";
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Quests.main} SET {Quests.Done}=@done WHERE {Quests.QuestName}=@questName", DB);
                commandUpdate.Parameters.AddWithValue("@done", "false");
                commandUpdate.Parameters.AddWithValue("@questName", DataQuests.QuestName);
                await commandUpdate.ExecuteNonQueryAsync();
            }
            else
            {
                buttonDone.BackColor = Color.Green;
                buttonDone.Text = "Выполнено";
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Quests.main} SET {Quests.Done}=@done WHERE {Quests.QuestName}=@questName", DB);
                commandUpdate.Parameters.AddWithValue("@done", "true");
                commandUpdate.Parameters.AddWithValue("@questName", DataQuests.QuestName);
                await commandUpdate.ExecuteNonQueryAsync();
            }
        }

        #region Перетаскивание
        private void DragAndDrop(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
