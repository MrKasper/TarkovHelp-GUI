using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TarkovHelp
{
    public partial class AddGun : Form
    {
        private SQLiteConnection DB;
        public AddGun()
        {
            InitializeComponent();
        }

        private async void AddGun_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection($"{Database.connectionDB}");
            await DB.OpenAsync();
            TypeItem.SelectedItem = "Тип оружия";
        }
        private string imgPath;
        private string imgFormat;
        private string imgName;
        private object imgSave;
        private void AddPictureBtn_Click(object sender, EventArgs e)
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Form fAdmin = new AdminPanel();
            fAdmin.Show();
            fAdmin.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }
        void mainForm_FormClosed(object sender, FormClosedEventArgs e) //Помощник 
        {
            this.Close();
        }

        private string imgPathLogo;
        private string imgFormatLogo;
        private string imgNameLogo;
        private object imgSaveLogo;
        private void AddPictureLogoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();// создаем диалоговое окно
            openFile.Filter = "Image files|*.jpg;*.jpeg;*.png";
            openFile.ShowDialog();// открываем окно
            string FileName = openFile.FileName;// берем полный адрес картинки
            imgPathLogo = openFile.FileName; // записываем в переменную путь к изображению
            PathTextBox.Text = FileName; // выводим в текстовом поле путь к изображению (для наглядности)
            //InitVariable();
            if (PathTextBox.Text == "") // если не указан путь к изображению, то...
                return; // прекратить выполнение
            // Конвертируем изображение в байты byte[]
            byte[] _imageBytes = null;
            FileInfo _imgInfo = new FileInfo(imgPathLogo); // загрузим изображение
            pictureBox2.Image = Image.FromFile(imgPathLogo); // загружает изображение в pictureBox
            long _numBytes = _imgInfo.Length; // вычислим длину
            FileStream _fileStream = new FileStream(imgPathLogo, FileMode.Open, FileAccess.Read); // откроем изображение на чтение
            BinaryReader _binReader = new BinaryReader(_fileStream);
            _imageBytes = _binReader.ReadBytes((int)_numBytes); // изображение в байтах
            imgSaveLogo = _imageBytes; //Для перекидывания сохранения на кнопку

            imgFormatLogo = Path.GetExtension(imgPathLogo).Replace(".", "").ToLower(); // запишем в переменную расширение изображения в нижнем регистре, не забыв удалить (Replace) точку перед расширением
            imgNameLogo = Path.GetFileName(openFile.FileName).Replace(Path.GetExtension(imgPathLogo), ""); // запишем в переменную имя файла, не забыв удалить (Replace) расширение с точкой
        }

        private async void AddItemBtn_Click(object sender, EventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand($"INSERT INTO {Assemblys.main} ([{Assemblys.TypeGun}],[{Assemblys.NameGun}], [{Assemblys.PictureLogo}], " +
            $"[{Assemblys.FormatLogo}], [{Assemblys.NameImgLogo}], [{Assemblys.Picture}], [{Assemblys.Format}], [{Assemblys.NameImg}]) " +
            "VALUES (@TypeGun, @NameGun, @pictureLogo, @formatLogo, @imgNameLogo, @picture, @format, @imgName)", DB);
            command.Parameters.AddWithValue("@TypeGun", TypeItem.Text);
            command.Parameters.AddWithValue("@NameGun", NameItemTb.Text);
            command.Parameters.AddWithValue("@pictureLogo", imgSaveLogo);
            command.Parameters.AddWithValue("@formatLogo", imgFormatLogo);
            command.Parameters.AddWithValue("@imgNameLogo", imgNameLogo);
            command.Parameters.AddWithValue("@picture", imgSave);
            command.Parameters.AddWithValue("@format", imgFormat);
            command.Parameters.AddWithValue("@imgName", imgName);
            await command.ExecuteNonQueryAsync();
            MessageBox.Show("Успех");
        }
    }
}
