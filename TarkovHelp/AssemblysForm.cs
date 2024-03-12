using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TarkovHelp
{
    public partial class AssemblysForm : Form
    {
        /*
        this.ShturmBtn.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Штурмовые винтовки"));
        this.buttonBolt.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Болтовые винтовки"));
        this.buttonPP.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Пистолет-пулеметы"));
        this.buttonShot.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Дробовики"));
        this.buttonKarabin.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Карабины"));
        this.buttonPistol.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Пистолеты"));
        this.buttonNog.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "По ногам"));
        */
        private static readonly SystemAssemblys _assembly = new SystemAssemblys(SystemAssemblys.MaxItem);
        private SQLiteConnection DB;
        #region Для перетаскивания
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        public AssemblysForm()
        {
            InitializeComponent();
        }
        private async void AssemblysForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection($"{Database.connectionDB}");
            await DB.OpenAsync();

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

        private async void LoadWeapons(object sender, EventArgs e, string weapon)
        {
            _assembly.items = new List<Item_Assembly>();
            SystemAssemblys.MaxItem = 0;
            int countGuns = 0;
            SQLiteDataReader sqlReader = null;
            Image Picture; //Создаем новую переменную
            Image PictureLogo;
            SQLiteCommand command = new SQLiteCommand($"SELECT COUNT (*) FROM {Assemblys.main} WHERE ({Assemblys.TypeGun}) LIKE '{weapon}' ", DB);
            {
                countGuns = Convert.ToInt32(command.ExecuteScalar());
                SystemAssemblys.MaxItem = Convert.ToInt32(countGuns);
                await command.ExecuteNonQueryAsync();
            }
            SQLiteCommand commandSelect = new SQLiteCommand($"SELECT * FROM {Assemblys.main} WHERE ({Assemblys.TypeGun}) LIKE '{weapon}' ", DB);
            {
                sqlReader = (SQLiteDataReader)await commandSelect.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    object title = sqlReader.GetValue(2);

                    byte[] imageData = (byte[])sqlReader["PictureLogo"]; //Считываем картинку
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        PictureLogo = Image.FromStream(stream); //Записываем картинку

                    }

                    byte[] imageData1 = (byte[])sqlReader["Picture"]; //Считываем картинку
                    using (MemoryStream stream = new MemoryStream(imageData1))
                    {
                        Picture = Image.FromStream(stream); //Записываем картинку

                    }
                    _assembly.CreateItem(title.ToString(), PictureLogo, Picture); //Создаем элементы
                }
            }
            DrawPanelQuests(countGuns);
        }
        private void DrawPanelQuests(int countGuns) //Параметры для рисования объектов 
        {
            flowLayoutPanel1.Controls.Clear();

            for (int i = 1; i <= countGuns; i++)
            {
                Panel pn = new Panel();
                pn.BorderStyle = BorderStyle.FixedSingle;
                pn.Size = new Size(162, 166);
                flowLayoutPanel1.Controls.Add(pn);

                PictureBox picture = new PictureBox();
                picture.Size = new Size(156, 91);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Location = new Point(3, 29);
                picture.Name = "picture" + i;
                picture.BorderStyle = BorderStyle.FixedSingle;
                pn.Controls.Add(picture);

                Label headLabel = new Label();
                headLabel.Size = new Size(156, 23);
                headLabel.Text = $"Example" + i;
                headLabel.TextAlign = ContentAlignment.MiddleCenter;
                headLabel.Location = new Point(3, 3);
                headLabel.Name = "headLabel" + i;
                pn.Controls.Add(headLabel);

                Button moreBtn = new Button();
                moreBtn.Size = new Size(156, 33);
                moreBtn.Location = new Point(3, 126);
                moreBtn.Text = "Сборка";
                moreBtn.Cursor = Cursors.Hand;
                moreBtn.Name = "moreBtn" + i;
                pn.Controls.Add(moreBtn);
                moreBtn.Click += MoreInfoButtonClick;

                headLabel.Text = _assembly.items[i - 1].Title;
                picture.Image = _assembly.items[i - 1].PictureLogo;
                moreBtn.Name = _assembly.items[i - 1].Title;
            }
        }
        public void MoreInfoButtonClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            if (button != null)
            {
                DataGuns.Name = button.Name;
                Form fGun = new AssemblyForm();
                fGun.Show();
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
    }
}
