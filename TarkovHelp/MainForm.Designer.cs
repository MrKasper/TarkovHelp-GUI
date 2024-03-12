namespace TarkovHelp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonQuests = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonShelter = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFleaMarket = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAssemblys = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AdminPanelBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelQuests = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonQuests
            // 
            this.buttonQuests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuests.FlatAppearance.BorderSize = 0;
            this.buttonQuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonQuests.ForeColor = System.Drawing.Color.White;
            this.buttonQuests.Location = new System.Drawing.Point(-1, 50);
            this.buttonQuests.Name = "buttonQuests";
            this.buttonQuests.Size = new System.Drawing.Size(199, 50);
            this.buttonQuests.TabIndex = 0;
            this.buttonQuests.Text = "Задания";
            this.buttonQuests.UseVisualStyleBackColor = true;
            this.buttonQuests.Click += new System.EventHandler(this.buttonQuests_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonItems.FlatAppearance.BorderSize = 0;
            this.buttonItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonItems.ForeColor = System.Drawing.Color.White;
            this.buttonItems.Location = new System.Drawing.Point(0, 106);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(199, 50);
            this.buttonItems.TabIndex = 1;
            this.buttonItems.Text = "Предметы";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // buttonShelter
            // 
            this.buttonShelter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShelter.Enabled = false;
            this.buttonShelter.FlatAppearance.BorderSize = 0;
            this.buttonShelter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShelter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonShelter.ForeColor = System.Drawing.Color.White;
            this.buttonShelter.Location = new System.Drawing.Point(0, 162);
            this.buttonShelter.Name = "buttonShelter";
            this.buttonShelter.Size = new System.Drawing.Size(199, 50);
            this.buttonShelter.TabIndex = 2;
            this.buttonShelter.Text = "Убежище";
            this.buttonShelter.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.Enabled = false;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(0, 386);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(199, 50);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonFleaMarket);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonAssemblys);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.AdminPanelBtn);
            this.panel1.Controls.Add(this.buttonQuests);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonItems);
            this.panel1.Controls.Add(this.buttonShelter);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 551);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // buttonFleaMarket
            // 
            this.buttonFleaMarket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFleaMarket.FlatAppearance.BorderSize = 0;
            this.buttonFleaMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFleaMarket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFleaMarket.ForeColor = System.Drawing.Color.White;
            this.buttonFleaMarket.Location = new System.Drawing.Point(0, 330);
            this.buttonFleaMarket.Name = "buttonFleaMarket";
            this.buttonFleaMarket.Size = new System.Drawing.Size(199, 50);
            this.buttonFleaMarket.TabIndex = 13;
            this.buttonFleaMarket.Text = "Барахолка";
            this.buttonFleaMarket.UseVisualStyleBackColor = true;
            this.buttonFleaMarket.Click += new System.EventHandler(this.buttonFleaMarket_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 50);
            this.button2.TabIndex = 12;
            this.button2.Text = "Карты";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonAssemblys
            // 
            this.buttonAssemblys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAssemblys.FlatAppearance.BorderSize = 0;
            this.buttonAssemblys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssemblys.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAssemblys.ForeColor = System.Drawing.Color.White;
            this.buttonAssemblys.Location = new System.Drawing.Point(0, 218);
            this.buttonAssemblys.Name = "buttonAssemblys";
            this.buttonAssemblys.Size = new System.Drawing.Size(199, 50);
            this.buttonAssemblys.TabIndex = 11;
            this.buttonAssemblys.Text = "Сборки";
            this.buttonAssemblys.UseVisualStyleBackColor = true;
            this.buttonAssemblys.Click += new System.EventHandler(this.buttonAssemblys_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(0, 499);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(198, 50);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.Text = "Выход";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AdminPanelBtn
            // 
            this.AdminPanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminPanelBtn.FlatAppearance.BorderSize = 0;
            this.AdminPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminPanelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AdminPanelBtn.ForeColor = System.Drawing.Color.White;
            this.AdminPanelBtn.Location = new System.Drawing.Point(0, 442);
            this.AdminPanelBtn.Name = "AdminPanelBtn";
            this.AdminPanelBtn.Size = new System.Drawing.Size(199, 50);
            this.AdminPanelBtn.TabIndex = 9;
            this.AdminPanelBtn.Text = "Админка";
            this.AdminPanelBtn.UseVisualStyleBackColor = true;
            this.AdminPanelBtn.Click += new System.EventHandler(this.AdminPanelBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelQuests);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(206, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 100);
            this.panel2.TabIndex = 5;
            // 
            // labelQuests
            // 
            this.labelQuests.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuests.Location = new System.Drawing.Point(3, 42);
            this.labelQuests.Name = "labelQuests";
            this.labelQuests.Size = new System.Drawing.Size(230, 42);
            this.labelQuests.TabIndex = 1;
            this.labelQuests.Text = "0/340";
            this.labelQuests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выполненые задания";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Green;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(206, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(728, 95);
            this.label9.TabIndex = 8;
            this.label9.Text = "Wipe Update\r\n\r\nАктуально для версии Escape From Tarkov 0.14.0.0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(206, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(726, 330);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 551);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(942, 551);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(942, 551);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TarkovTracker v0.2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuests;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.Button buttonShelter;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelQuests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AdminPanelBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button buttonAssemblys;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonFleaMarket;
    }
}

