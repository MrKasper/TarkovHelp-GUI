using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TarkovHelp
{
    public partial class AddQuest : Form
    {
        public AddQuest()
        {
            InitializeComponent();
        }

        private SQLiteConnection DB;

        private async void AddQuest_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection($"{Database.connectionDB}");
            await DB.OpenAsync();
        }

        private string imgPath;
        private string imgFormat;
        private string imgName;
        private object imgSave;

        private void AddPictureBtn_Click(object sender, EventArgs e) //Выбор картинки 
        {
            OpenFileDialog openFile = new OpenFileDialog();// создаем диалоговое окно
            openFile.Filter = "Image files|*.jpg;*.jpeg;*.png";
            openFile.ShowDialog();// открываем окно
            string FileName = openFile.FileName;// берем полный адрес картинки
            imgPath = openFile.FileName; // записываем в переменную путь к изображению
            PadhTextBox.Text = FileName; // выводим в текстовом поле путь к изображению (для наглядности)
            //InitVariable();
            if (PadhTextBox.Text == "") // если не указан путь к изображению, то...
                return; // прекратить выполнение
            // Конвертируем изображение в байты byte[]
            byte[] _imageBytes = null;
            FileInfo _imgInfo = new FileInfo(imgPath); // загрузим изображение
            pictureBox1.Image = Image.FromFile(imgPath); // загружает изображение в pictureBox
            long _numBytes = _imgInfo.Length; // вычислим длину
            FileStream _fileStream = new FileStream(imgPath, FileMode.Open, FileAccess.Read); // откроем изображение на чтение
            BinaryReader _binReader = new BinaryReader(_fileStream);
            _imageBytes = _binReader.ReadBytes((int)_numBytes); // изображение в байтах
            imgSave = _imageBytes; //Для перекидывания сохранения на кнопку

            imgFormat = Path.GetExtension(imgPath).Replace(".", "").ToLower(); // запишем в переменную расширение изображения в нижнем регистре, не забыв удалить (Replace) точку перед расширением
            imgName = Path.GetFileName(openFile.FileName).Replace(Path.GetExtension(imgPath), ""); // запишем в переменную имя файла, не забыв удалить (Replace) расширение с точкой
        }

        private async void SaveBtn_Click(object sender, EventArgs e) //Сохранение 
        {
            SQLiteCommand command = new SQLiteCommand($"INSERT INTO {Quests.main} ([{Quests.Quester}],[{Quests.QuestName}], [{Quests.QuestGoal}], " +
                $"[{Quests.DialogBefore}], [{Quests.DialogAfter}], [{Quests.Reward}], [{Quests.Picture}], [{Quests.Format}], [{Quests.NameImg}]) " +
            "VALUES (@quester, @questName, @questGoal, @dialogBefore, @dialogAfter, @reward, @picture, @format, @imgName)", DB);
            command.Parameters.AddWithValue("@quester", QuesterTextBox.Text);
            command.Parameters.AddWithValue("@questName", QuestNameTextBox.Text);
            command.Parameters.AddWithValue("@questGoal", QuestGoalTextBox.Text); 
            command.Parameters.AddWithValue("@dialogBefore", DialogBeforeTextBox.Text);
            command.Parameters.AddWithValue("@dialogAfter", DialogAfterTextBox.Text);
            command.Parameters.AddWithValue("@reward", RewardTextBox.Text);
            command.Parameters.AddWithValue("@picture", imgSave);
            command.Parameters.AddWithValue("@format", imgFormat);
            command.Parameters.AddWithValue("@imgName", imgName);
            await command.ExecuteNonQueryAsync();
            MessageBox.Show("Успех");
        }

        private void CancelBtn_Click(object sender, EventArgs e) //Отменить 
        {
            Form fgoQuest = new AdminPanel();
            fgoQuest.Show();
            fgoQuest.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }

        void mainForm_FormClosed(object sender, FormClosedEventArgs e) //Помощник 
        {
            this.Close();
        }
    }
}
