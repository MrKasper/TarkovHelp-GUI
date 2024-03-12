namespace TarkovHelp
{
    partial class ItemsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.comboBoxFilterShelter = new System.Windows.Forms.ComboBox();
            this.ShelterBtn = new System.Windows.Forms.Button();
            this.QuestsBtn = new System.Windows.Forms.Button();
            this.AllItemsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(175, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(716, 451);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.comboBoxFilterShelter);
            this.panel1.Controls.Add(this.ShelterBtn);
            this.panel1.Controls.Add(this.QuestsBtn);
            this.panel1.Controls.Add(this.AllItemsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 462);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(0, 412);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(169, 50);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "Назад";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // comboBoxFilterShelter
            // 
            this.comboBoxFilterShelter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFilterShelter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterShelter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFilterShelter.FormattingEnabled = true;
            this.comboBoxFilterShelter.Items.AddRange(new object[] {
            "Все компоненты",
            "Безопасность",
            "Освещение",
            "Вентиляция",
            "Генератор",
            "Пищеблок",
            "Обогрев",
            "Зона Отдыха",
            "Медблок",
            "Водосборник",
            "Склад",
            "Санузел",
            "Верстак",
            "Тир",
            "Разведцентр",
            "Биткоин ферма",
            "Самогонный аппарат",
            "Воздушный фильтратор",
            "Библиотека",
            "Солнечная батарея",
            "Ящик Диких"});
            this.comboBoxFilterShelter.Location = new System.Drawing.Point(0, 156);
            this.comboBoxFilterShelter.Name = "comboBoxFilterShelter";
            this.comboBoxFilterShelter.Size = new System.Drawing.Size(169, 24);
            this.comboBoxFilterShelter.TabIndex = 5;
            this.comboBoxFilterShelter.Visible = false;
            this.comboBoxFilterShelter.TextChanged += new System.EventHandler(this.comboBoxFilterShelter_TextChanged);
            // 
            // ShelterBtn
            // 
            this.ShelterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ShelterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShelterBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShelterBtn.FlatAppearance.BorderSize = 0;
            this.ShelterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShelterBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShelterBtn.ForeColor = System.Drawing.Color.White;
            this.ShelterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShelterBtn.Location = new System.Drawing.Point(0, 100);
            this.ShelterBtn.Name = "ShelterBtn";
            this.ShelterBtn.Size = new System.Drawing.Size(169, 50);
            this.ShelterBtn.TabIndex = 4;
            this.ShelterBtn.Text = "Убежище";
            this.ShelterBtn.UseVisualStyleBackColor = false;
            this.ShelterBtn.Click += new System.EventHandler(this.ShelterBtn_Click);
            // 
            // QuestsBtn
            // 
            this.QuestsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.QuestsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestsBtn.Enabled = false;
            this.QuestsBtn.FlatAppearance.BorderSize = 0;
            this.QuestsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestsBtn.ForeColor = System.Drawing.Color.White;
            this.QuestsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuestsBtn.Location = new System.Drawing.Point(0, 50);
            this.QuestsBtn.Name = "QuestsBtn";
            this.QuestsBtn.Size = new System.Drawing.Size(169, 50);
            this.QuestsBtn.TabIndex = 3;
            this.QuestsBtn.Text = "Квестовые";
            this.QuestsBtn.UseVisualStyleBackColor = false;
            this.QuestsBtn.Click += new System.EventHandler(this.QuestsBtn_Click);
            // 
            // AllItemsBtn
            // 
            this.AllItemsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.AllItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllItemsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllItemsBtn.FlatAppearance.BorderSize = 0;
            this.AllItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllItemsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllItemsBtn.ForeColor = System.Drawing.Color.White;
            this.AllItemsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllItemsBtn.Location = new System.Drawing.Point(0, 0);
            this.AllItemsBtn.Name = "AllItemsBtn";
            this.AllItemsBtn.Size = new System.Drawing.Size(169, 50);
            this.AllItemsBtn.TabIndex = 2;
            this.AllItemsBtn.Text = "Все предметы";
            this.AllItemsBtn.UseVisualStyleBackColor = false;
            this.AllItemsBtn.Click += new System.EventHandler(this.AllItemsBtn_Click);
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 462);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 462);
            this.Name = "ItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список предметов";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShelterBtn;
        private System.Windows.Forms.Button QuestsBtn;
        private System.Windows.Forms.Button AllItemsBtn;
        private System.Windows.Forms.ComboBox comboBoxFilterShelter;
        private System.Windows.Forms.Button CloseBtn;
    }
}