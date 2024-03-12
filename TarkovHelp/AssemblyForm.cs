using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TarkovHelp
{
    public partial class AssemblyForm : Form
    {
        private SQLiteConnection DB;
        public AssemblyForm()
        {
            InitializeComponent();
        }

        private async void AssemblyForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection($"{Database.connectionDB}");
            await DB.OpenAsync();
            LoadingPicture();
        }

        private async void LoadingPicture()
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand commandSelect = new SQLiteCommand($"SELECT * FROM {Assemblys.main} WHERE ({Assemblys.NameGun}) LIKE '{DataGuns.Name}' ", DB);
            {
                sqlReader = (SQLiteDataReader)await commandSelect.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    byte[] imageData = (byte[])sqlReader["Picture"]; //Считываем картинку
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(stream); //Записываем картинку
                    }
                }
            }
        }
    }
}
