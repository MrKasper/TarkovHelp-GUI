namespace TarkovHelp
{
    partial class AddQuest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuest));
            this.QuesterTextBox = new System.Windows.Forms.TextBox();
            this.QuestNameTextBox = new System.Windows.Forms.TextBox();
            this.QuestGoalTextBox = new System.Windows.Forms.TextBox();
            this.DialogBeforeTextBox = new System.Windows.Forms.TextBox();
            this.DialogAfterTextBox = new System.Windows.Forms.TextBox();
            this.RewardTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AddPictureBtn = new System.Windows.Forms.Button();
            this.PadhTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuesterTextBox
            // 
            this.QuesterTextBox.Location = new System.Drawing.Point(12, 12);
            this.QuesterTextBox.Name = "QuesterTextBox";
            this.QuesterTextBox.Size = new System.Drawing.Size(112, 20);
            this.QuesterTextBox.TabIndex = 0;
            this.QuesterTextBox.Text = "Дает квест";
            // 
            // QuestNameTextBox
            // 
            this.QuestNameTextBox.Location = new System.Drawing.Point(11, 44);
            this.QuestNameTextBox.Name = "QuestNameTextBox";
            this.QuestNameTextBox.Size = new System.Drawing.Size(247, 20);
            this.QuestNameTextBox.TabIndex = 1;
            this.QuestNameTextBox.Text = "Название квеста";
            // 
            // QuestGoalTextBox
            // 
            this.QuestGoalTextBox.Location = new System.Drawing.Point(11, 70);
            this.QuestGoalTextBox.Multiline = true;
            this.QuestGoalTextBox.Name = "QuestGoalTextBox";
            this.QuestGoalTextBox.Size = new System.Drawing.Size(247, 93);
            this.QuestGoalTextBox.TabIndex = 2;
            this.QuestGoalTextBox.Text = "Цели";
            // 
            // DialogBeforeTextBox
            // 
            this.DialogBeforeTextBox.Location = new System.Drawing.Point(11, 169);
            this.DialogBeforeTextBox.Multiline = true;
            this.DialogBeforeTextBox.Name = "DialogBeforeTextBox";
            this.DialogBeforeTextBox.Size = new System.Drawing.Size(247, 93);
            this.DialogBeforeTextBox.TabIndex = 3;
            this.DialogBeforeTextBox.Text = "Диалог до";
            // 
            // DialogAfterTextBox
            // 
            this.DialogAfterTextBox.Location = new System.Drawing.Point(264, 169);
            this.DialogAfterTextBox.Multiline = true;
            this.DialogAfterTextBox.Name = "DialogAfterTextBox";
            this.DialogAfterTextBox.Size = new System.Drawing.Size(247, 93);
            this.DialogAfterTextBox.TabIndex = 4;
            this.DialogAfterTextBox.Text = "Диалог после";
            // 
            // RewardTextBox
            // 
            this.RewardTextBox.Location = new System.Drawing.Point(264, 70);
            this.RewardTextBox.Multiline = true;
            this.RewardTextBox.Name = "RewardTextBox";
            this.RewardTextBox.Size = new System.Drawing.Size(247, 93);
            this.RewardTextBox.TabIndex = 5;
            this.RewardTextBox.Text = "Награда";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(517, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Location = new System.Drawing.Point(10, 268);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(98, 28);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Location = new System.Drawing.Point(114, 268);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(98, 28);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddPictureBtn
            // 
            this.AddPictureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPictureBtn.Location = new System.Drawing.Point(517, 268);
            this.AddPictureBtn.Name = "AddPictureBtn";
            this.AddPictureBtn.Size = new System.Drawing.Size(98, 28);
            this.AddPictureBtn.TabIndex = 9;
            this.AddPictureBtn.Text = "AddPicture";
            this.AddPictureBtn.UseVisualStyleBackColor = true;
            this.AddPictureBtn.Click += new System.EventHandler(this.AddPictureBtn_Click);
            // 
            // PadhTextBox
            // 
            this.PadhTextBox.Enabled = false;
            this.PadhTextBox.Location = new System.Drawing.Point(517, 44);
            this.PadhTextBox.Name = "PadhTextBox";
            this.PadhTextBox.Size = new System.Drawing.Size(337, 20);
            this.PadhTextBox.TabIndex = 10;
            this.PadhTextBox.Text = "Путь";
            // 
            // AddQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 305);
            this.Controls.Add(this.PadhTextBox);
            this.Controls.Add(this.AddPictureBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RewardTextBox);
            this.Controls.Add(this.DialogAfterTextBox);
            this.Controls.Add(this.DialogBeforeTextBox);
            this.Controls.Add(this.QuestGoalTextBox);
            this.Controls.Add(this.QuestNameTextBox);
            this.Controls.Add(this.QuesterTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuest";
            this.Load += new System.EventHandler(this.AddQuest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuesterTextBox;
        private System.Windows.Forms.TextBox QuestNameTextBox;
        private System.Windows.Forms.TextBox QuestGoalTextBox;
        private System.Windows.Forms.TextBox DialogBeforeTextBox;
        private System.Windows.Forms.TextBox DialogAfterTextBox;
        private System.Windows.Forms.TextBox RewardTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button AddPictureBtn;
        private System.Windows.Forms.TextBox PadhTextBox;
    }
}