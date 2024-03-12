namespace TarkovHelp
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.AddQuestbtn = new System.Windows.Forms.Button();
            this.QuestListbtn = new System.Windows.Forms.Button();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.ItemsListBtn = new System.Windows.Forms.Button();
            this.buttonAssembly = new System.Windows.Forms.Button();
            this.buttonAssemblyList = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuestbtn
            // 
            this.AddQuestbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddQuestbtn.Location = new System.Drawing.Point(12, 12);
            this.AddQuestbtn.Name = "AddQuestbtn";
            this.AddQuestbtn.Size = new System.Drawing.Size(151, 23);
            this.AddQuestbtn.TabIndex = 0;
            this.AddQuestbtn.Text = "Добавить квест";
            this.AddQuestbtn.UseVisualStyleBackColor = true;
            this.AddQuestbtn.Click += new System.EventHandler(this.AddQuestbtn_Click);
            // 
            // QuestListbtn
            // 
            this.QuestListbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestListbtn.Location = new System.Drawing.Point(171, 12);
            this.QuestListbtn.Name = "QuestListbtn";
            this.QuestListbtn.Size = new System.Drawing.Size(151, 23);
            this.QuestListbtn.TabIndex = 2;
            this.QuestListbtn.Text = "Список квестов";
            this.QuestListbtn.UseVisualStyleBackColor = true;
            this.QuestListbtn.Click += new System.EventHandler(this.QuestListbtn_Click);
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItemBtn.Location = new System.Drawing.Point(12, 41);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(151, 23);
            this.AddItemBtn.TabIndex = 3;
            this.AddItemBtn.Text = "Добавить предмет";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // ItemsListBtn
            // 
            this.ItemsListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemsListBtn.Enabled = false;
            this.ItemsListBtn.Location = new System.Drawing.Point(171, 41);
            this.ItemsListBtn.Name = "ItemsListBtn";
            this.ItemsListBtn.Size = new System.Drawing.Size(151, 23);
            this.ItemsListBtn.TabIndex = 4;
            this.ItemsListBtn.Text = "Список предметов";
            this.ItemsListBtn.UseVisualStyleBackColor = true;
            // 
            // buttonAssembly
            // 
            this.buttonAssembly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAssembly.Location = new System.Drawing.Point(12, 70);
            this.buttonAssembly.Name = "buttonAssembly";
            this.buttonAssembly.Size = new System.Drawing.Size(151, 23);
            this.buttonAssembly.TabIndex = 5;
            this.buttonAssembly.Text = "Добавить сборку";
            this.buttonAssembly.UseVisualStyleBackColor = true;
            this.buttonAssembly.Click += new System.EventHandler(this.buttonAssembly_Click);
            // 
            // buttonAssemblyList
            // 
            this.buttonAssemblyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAssemblyList.Enabled = false;
            this.buttonAssemblyList.Location = new System.Drawing.Point(171, 70);
            this.buttonAssemblyList.Name = "buttonAssemblyList";
            this.buttonAssemblyList.Size = new System.Drawing.Size(151, 23);
            this.buttonAssemblyList.TabIndex = 6;
            this.buttonAssemblyList.Text = "Список сборок";
            this.buttonAssemblyList.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Location = new System.Drawing.Point(171, 103);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(151, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 138);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAssemblyList);
            this.Controls.Add(this.buttonAssembly);
            this.Controls.Add(this.ItemsListBtn);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.QuestListbtn);
            this.Controls.Add(this.AddQuestbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuestbtn;
        private System.Windows.Forms.Button QuestListbtn;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Button ItemsListBtn;
        private System.Windows.Forms.Button buttonAssembly;
        private System.Windows.Forms.Button buttonAssemblyList;
        private System.Windows.Forms.Button buttonClose;
    }
}