using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TarkovHelp
{
    public partial class QuestList : Form
    {
        private SQLiteConnection DB;
        public QuestList()
        {
            InitializeComponent();            
        }

        private async void QuestList_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection($"{Database.connectionDB}");
            await DB.OpenAsync();

            loadingQuestsTable();
        }

        private async void loadingQuestsTable() 
        {
            dataGridViewQuests.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Quests.main}]", DB);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Quests.id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Quests.Quester}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Quests.QuestName}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Quests.QuestGoal}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Quests.DialogBefore}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Quests.DialogAfter}"]}");
                    data[data.Count - 1][6] = Convert.ToString($"{sqlReader[$"{Quests.Reward}"]}");
                }

                foreach (string[] s in data)
                {
                    dataGridViewQuests.Rows.Add(s);
                }
                dataGridViewQuests.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }

        private async void dataGridViewQuests_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) //Открытие карточки квеста 
        {            
            if (dataGridViewQuests.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewQuests.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewQuests.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ColumnID"].Value);
                string Quester = Convert.ToString(selectedRow.Cells["ColumnQuester"].Value);
                string QuestName = Convert.ToString(selectedRow.Cells["ColumnQuestName"].Value);
                SQLiteDataReader sqlReader = null;
                SQLiteCommand commandInsert = new SQLiteCommand($"SELECT * FROM [{Quests.main}] " +
                    $"WHERE [{Quests.id}]=@id " +
                    $"AND [{Quests.Quester}]=@quester " +
                    $"AND [{Quests.QuestName}]=@questName ", DB);
                commandInsert.Parameters.AddWithValue("id", id);
                commandInsert.Parameters.AddWithValue("quester", Quester);
                commandInsert.Parameters.AddWithValue("questName", QuestName);
                try
                {
                    sqlReader = (SQLiteDataReader)await commandInsert.ExecuteReaderAsync();
                    while (await sqlReader.ReadAsync())
                    {
                        DataQuests.Id = Convert.ToString($"{sqlReader[$"{Quests.id}"]}");
                        DataQuests.Quester = Convert.ToString($"{sqlReader[$"{Quests.Quester}"]}");
                        DataQuests.QuestName = Convert.ToString($"{sqlReader[$"{Quests.QuestName}"]}");
                        DataQuests.QuestGoal = Convert.ToString($"{sqlReader[$"{Quests.QuestGoal}"]}");
                        DataQuests.DialogBefore = Convert.ToString($"{sqlReader[$"{Quests.DialogBefore}"]}");
                        DataQuests.DialogAfter = Convert.ToString($"{sqlReader[$"{Quests.DialogAfter}"]}");
                        DataQuests.Reward = Convert.ToString($"{sqlReader[$"{Quests.Reward}"]}");
                        DataQuests.Done = Convert.ToString($"{sqlReader[$"{Quests.Done}"]}");
                        DataQuests.HowDone = Convert.ToString($"{sqlReader[$"{Quests.HowDone}"]}");

                        byte[] imageData = (byte[])sqlReader["Picture"]; //Считываем картинку
                        using (MemoryStream stream = new MemoryStream(imageData))
                        {
                            DataQuests.PictureQuest = Image.FromStream(stream); //Записываем картинку
                        }

                        if (DataQuests.isOpen == false)
                        {
                            Form fDataStudent = new QuestCardEdit();
                            fDataStudent.Show();
                        }
                        else return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlReader != null)
                    {
                        sqlReader.Close();
                    }
                }
            }            
        }

        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Form FRoomsList = new AdminPanel();
            FRoomsList.Show();
            FRoomsList.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            loadingQuestsTable();
        }
    }
}
