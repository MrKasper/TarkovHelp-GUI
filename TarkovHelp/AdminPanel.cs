using System;
using System.Windows.Forms;

namespace TarkovHelp
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void AddQuestbtn_Click(object sender, EventArgs e)
        {
            Form FRoomsList = new AddQuest();
            FRoomsList.Show();
            FRoomsList.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }

        private void QuestListbtn_Click(object sender, EventArgs e)
        {
            Form FRoomsList = new QuestList();
            FRoomsList.Show();
            FRoomsList.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            Form fAddItem = new AddItem();
            fAddItem.Show();
            fAddItem.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Form fMain = new MainForm();
            fMain.Show();
            fMain.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }

        private void buttonAssembly_Click(object sender, EventArgs e)
        {
            Form fAddGun = new AddGun();
            fAddGun.Show();
            fAddGun.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
            this.Hide();
        }
    }
}
