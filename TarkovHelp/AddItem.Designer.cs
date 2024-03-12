namespace TarkovHelp
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AddPictureBtn = new System.Windows.Forms.Button();
            this.NameItemTb = new System.Windows.Forms.TextBox();
            this.ForWhatTb = new System.Windows.Forms.TextBox();
            this.CountTb = new System.Windows.Forms.TextBox();
            this.PadhTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TypeItem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemBtn.Location = new System.Drawing.Point(93, 116);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(75, 30);
            this.AddItemBtn.TabIndex = 0;
            this.AddItemBtn.Text = "Добавить";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Location = new System.Drawing.Point(12, 116);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 30);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Отмена";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddPictureBtn
            // 
            this.AddPictureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPictureBtn.Location = new System.Drawing.Point(12, 152);
            this.AddPictureBtn.Name = "AddPictureBtn";
            this.AddPictureBtn.Size = new System.Drawing.Size(156, 30);
            this.AddPictureBtn.TabIndex = 10;
            this.AddPictureBtn.Text = "AddPicture";
            this.AddPictureBtn.UseVisualStyleBackColor = true;
            this.AddPictureBtn.Click += new System.EventHandler(this.AddPictureBtn_Click);
            // 
            // NameItemTb
            // 
            this.NameItemTb.Location = new System.Drawing.Point(12, 12);
            this.NameItemTb.Multiline = true;
            this.NameItemTb.Name = "NameItemTb";
            this.NameItemTb.Size = new System.Drawing.Size(156, 20);
            this.NameItemTb.TabIndex = 11;
            this.NameItemTb.Text = "Название предмета";
            // 
            // ForWhatTb
            // 
            this.ForWhatTb.Location = new System.Drawing.Point(12, 64);
            this.ForWhatTb.Multiline = true;
            this.ForWhatTb.Name = "ForWhatTb";
            this.ForWhatTb.Size = new System.Drawing.Size(156, 20);
            this.ForWhatTb.TabIndex = 12;
            this.ForWhatTb.Text = "Для чего";
            // 
            // CountTb
            // 
            this.CountTb.Location = new System.Drawing.Point(12, 90);
            this.CountTb.Multiline = true;
            this.CountTb.Name = "CountTb";
            this.CountTb.Size = new System.Drawing.Size(156, 20);
            this.CountTb.TabIndex = 13;
            this.CountTb.Text = "Количество";
            // 
            // PadhTextBox
            // 
            this.PadhTextBox.Enabled = false;
            this.PadhTextBox.Location = new System.Drawing.Point(174, 12);
            this.PadhTextBox.Name = "PadhTextBox";
            this.PadhTextBox.Size = new System.Drawing.Size(198, 20);
            this.PadhTextBox.TabIndex = 14;
            this.PadhTextBox.Text = "Путь";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(174, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // TypeItem
            // 
            this.TypeItem.FormattingEnabled = true;
            this.TypeItem.Items.AddRange(new object[] {
            "Тип предмета",
            "Убежище",
            "Задания",
            "Барахолка"});
            this.TypeItem.Location = new System.Drawing.Point(12, 37);
            this.TypeItem.Name = "TypeItem";
            this.TypeItem.Size = new System.Drawing.Size(156, 21);
            this.TypeItem.TabIndex = 17;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 194);
            this.Controls.Add(this.TypeItem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PadhTextBox);
            this.Controls.Add(this.CountTb);
            this.Controls.Add(this.ForWhatTb);
            this.Controls.Add(this.NameItemTb);
            this.Controls.Add(this.AddPictureBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddItemBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button AddPictureBtn;
        private System.Windows.Forms.TextBox NameItemTb;
        private System.Windows.Forms.TextBox ForWhatTb;
        private System.Windows.Forms.TextBox CountTb;
        private System.Windows.Forms.TextBox PadhTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox TypeItem;
    }
}