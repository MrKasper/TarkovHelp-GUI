using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TarkovHelp
{
    public partial class QuestCardEdit : Form
    {
        
        public QuestCardEdit()
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

        private async void QuestCardEdit_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection($"{Database.connectionDB}");
            await DB.OpenAsync();

            loadingQuestData();
            DataQuests.isOpen = true;
        }
        private void loadingQuestData() //Загрузка данных 
        {
            labelWho.Text = "Выдает: " + DataQuests.Quester;
            QuestNameTextBox.Text = "Квест " + DataQuests.QuestName;
            QuestGoalTextBox.Text = DataQuests.QuestGoal;
            DialogBeforeTextBox.Text = DataQuests.DialogBefore;
            DialogAfterTextBox.Text = DataQuests.DialogAfter;
            PictureQuest.Image = DataQuests.PictureQuest;
            RewardTextBox.Text = DataQuests.Reward;
            HowDone.Text = DataQuests.HowDone;
        }
        private bool SwapPick = false;
        private string imgPath;
        private string imgFormat;
        private string imgName;
        private object imgSave;

        private void SwapPictureBtn_Click(object sender, EventArgs e) //Смена картинки 
        {
            OpenFileDialog openFile = new OpenFileDialog();// создаем диалоговое окно
            openFile.ShowDialog();// открываем окно
            string FileName = openFile.FileName;// берем полный адрес картинки
            imgPath = openFile.FileName; // записываем в переменную путь к изображению
            if (imgPath == "") // если не указан путь к изображению, то...
                return; // прекратить выполнение
            // Конвертируем изображение в байты byte[]
            byte[] _imageBytes = null;
            FileInfo _imgInfo = new FileInfo(imgPath); // загрузим изображение
            PictureQuest.Image = Image.FromFile(imgPath); // загружает изображение в pictureBox
            long _numBytes = _imgInfo.Length; // вычислим длину
            FileStream _fileStream = new FileStream(imgPath, FileMode.Open, FileAccess.Read); // откроем изображение на чтение
            BinaryReader _binReader = new BinaryReader(_fileStream);
            _imageBytes = _binReader.ReadBytes((int)_numBytes); // изображение в байтах
            imgSave = _imageBytes; //Для перекидывания сохранения на кнопку

            imgFormat = Path.GetExtension(imgPath).Replace(".", "").ToLower(); // запишем в переменную расширение изображения в нижнем регистре, не забыв удалить (Replace) точку перед расширением
            imgName = Path.GetFileName(openFile.FileName).Replace(Path.GetExtension(imgPath), ""); // запишем в переменную имя файла, не забыв удалить (Replace) расширение с точкой
            
            SwapPick = true;
        }

        private async void SaveUpdateBtn_Click(object sender, EventArgs e)
        {
            if (SwapPick == true)
            {
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Quests.main} SET [{Quests.QuestName}]=@questName, [{Quests.QuestGoal}]=@questGoal, " +
                 $"[{Quests.DialogBefore}]=@dialogBefore, [{Quests.DialogAfter}]=@dialogAfter, [{Quests.Reward}]=@reward, [{Quests.Picture}]=@picture, " +
                $"[{Quests.Format}]=@format, [{Quests.NameImg}]=@imgName, [{Quests.HowDone}]=@howdone WHERE [{Quests.id}]=@id", DB);
                commandUpdate.Parameters.AddWithValue("@id", DataQuests.Id);
                commandUpdate.Parameters.AddWithValue("@questName", QuestNameTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@questGoal", QuestGoalTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@dialogBefore", DialogBeforeTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@dialogAfter", DialogAfterTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@reward", RewardTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@picture", imgSave);
                commandUpdate.Parameters.AddWithValue("@format", imgFormat);
                commandUpdate.Parameters.AddWithValue("@imgName", imgName);
                commandUpdate.Parameters.AddWithValue("@howdone", HowDone.Text);
                await commandUpdate.ExecuteNonQueryAsync();
            }
            else
            {
                SQLiteCommand commandUpdate = new SQLiteCommand($"UPDATE {Quests.main} SET [{Quests.QuestName}]=@questName, [{Quests.QuestGoal}]=@questGoal, " +
                    $"[{Quests.DialogBefore}]=@dialogBefore, [{Quests.DialogAfter}]=@dialogAfter, [{Quests.Reward}]=@reward, [{Quests.HowDone}]=@howdone WHERE [{Quests.id}]=@id", DB);
                commandUpdate.Parameters.AddWithValue("@id", DataQuests.Id);
                commandUpdate.Parameters.AddWithValue("@questName", QuestNameTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@questGoal", QuestGoalTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@dialogBefore", DialogBeforeTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@dialogAfter", DialogAfterTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@reward", RewardTextBox.Text);
                commandUpdate.Parameters.AddWithValue("@howdone", HowDone.Text);
                await commandUpdate.ExecuteNonQueryAsync();
            }
            MessageBox.Show("Успех");
            this.Close();
            DataQuests.isOpen = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DataQuests.isOpen = false;
        }

        #region Перетаскивание
        private void QuestNameTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void QuestCardEdit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void label5_MouseDown(object sender, MouseEventArgs e)
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
