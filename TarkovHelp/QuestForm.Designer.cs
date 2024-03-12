using System;

namespace TarkovHelp
{
    partial class QuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.CaretakerBtn = new System.Windows.Forms.Button();
            this.HuntsmanBtn = new System.Windows.Forms.Button();
            this.FleaDealerBtn = new System.Windows.Forms.Button();
            this.MechanicBtn = new System.Windows.Forms.Button();
            this.PeacemakerBtn = new System.Windows.Forms.Button();
            this.SkierBtn = new System.Windows.Forms.Button();
            this.BuyerBtn = new System.Windows.Forms.Button();
            this.TherapistBtn = new System.Windows.Forms.Button();
            this.EnsingBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.CaretakerBtn);
            this.panel1.Controls.Add(this.HuntsmanBtn);
            this.panel1.Controls.Add(this.FleaDealerBtn);
            this.panel1.Controls.Add(this.MechanicBtn);
            this.panel1.Controls.Add(this.PeacemakerBtn);
            this.panel1.Controls.Add(this.SkierBtn);
            this.panel1.Controls.Add(this.BuyerBtn);
            this.panel1.Controls.Add(this.TherapistBtn);
            this.panel1.Controls.Add(this.EnsingBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 522);
            this.panel1.TabIndex = 0;
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
            this.CloseBtn.Location = new System.Drawing.Point(0, 472);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(169, 50);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Text = "Назад";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CaretakerBtn
            // 
            this.CaretakerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.CaretakerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CaretakerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaretakerBtn.FlatAppearance.BorderSize = 0;
            this.CaretakerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaretakerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaretakerBtn.ForeColor = System.Drawing.Color.White;
            this.CaretakerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CaretakerBtn.Location = new System.Drawing.Point(0, 400);
            this.CaretakerBtn.Name = "CaretakerBtn";
            this.CaretakerBtn.Size = new System.Drawing.Size(169, 50);
            this.CaretakerBtn.TabIndex = 10;
            this.CaretakerBtn.Text = "Смотритель";
            this.CaretakerBtn.UseVisualStyleBackColor = false;
            // 
            // HuntsmanBtn
            // 
            this.HuntsmanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.HuntsmanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HuntsmanBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HuntsmanBtn.FlatAppearance.BorderSize = 0;
            this.HuntsmanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HuntsmanBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HuntsmanBtn.ForeColor = System.Drawing.Color.White;
            this.HuntsmanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HuntsmanBtn.Location = new System.Drawing.Point(0, 350);
            this.HuntsmanBtn.Name = "HuntsmanBtn";
            this.HuntsmanBtn.Size = new System.Drawing.Size(169, 50);
            this.HuntsmanBtn.TabIndex = 9;
            this.HuntsmanBtn.Text = "Егерь";
            this.HuntsmanBtn.UseVisualStyleBackColor = false;
            // 
            // FleaDealerBtn
            // 
            this.FleaDealerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.FleaDealerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FleaDealerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.FleaDealerBtn.FlatAppearance.BorderSize = 0;
            this.FleaDealerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FleaDealerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FleaDealerBtn.ForeColor = System.Drawing.Color.White;
            this.FleaDealerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FleaDealerBtn.Location = new System.Drawing.Point(0, 300);
            this.FleaDealerBtn.Name = "FleaDealerBtn";
            this.FleaDealerBtn.Size = new System.Drawing.Size(169, 50);
            this.FleaDealerBtn.TabIndex = 8;
            this.FleaDealerBtn.Text = "Барахольщик";
            this.FleaDealerBtn.UseVisualStyleBackColor = false;
            // 
            // MechanicBtn
            // 
            this.MechanicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.MechanicBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MechanicBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MechanicBtn.FlatAppearance.BorderSize = 0;
            this.MechanicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MechanicBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MechanicBtn.ForeColor = System.Drawing.Color.White;
            this.MechanicBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MechanicBtn.Location = new System.Drawing.Point(0, 250);
            this.MechanicBtn.Name = "MechanicBtn";
            this.MechanicBtn.Size = new System.Drawing.Size(169, 50);
            this.MechanicBtn.TabIndex = 7;
            this.MechanicBtn.Text = "Механик";
            this.MechanicBtn.UseVisualStyleBackColor = false;
            // 
            // PeacemakerBtn
            // 
            this.PeacemakerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.PeacemakerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PeacemakerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.PeacemakerBtn.FlatAppearance.BorderSize = 0;
            this.PeacemakerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeacemakerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeacemakerBtn.ForeColor = System.Drawing.Color.White;
            this.PeacemakerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PeacemakerBtn.Location = new System.Drawing.Point(0, 200);
            this.PeacemakerBtn.Name = "PeacemakerBtn";
            this.PeacemakerBtn.Size = new System.Drawing.Size(169, 50);
            this.PeacemakerBtn.TabIndex = 6;
            this.PeacemakerBtn.Text = "Миротворец";
            this.PeacemakerBtn.UseVisualStyleBackColor = false;
            // 
            // SkierBtn
            // 
            this.SkierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.SkierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkierBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SkierBtn.FlatAppearance.BorderSize = 0;
            this.SkierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkierBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkierBtn.ForeColor = System.Drawing.Color.White;
            this.SkierBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SkierBtn.Location = new System.Drawing.Point(0, 150);
            this.SkierBtn.Name = "SkierBtn";
            this.SkierBtn.Size = new System.Drawing.Size(169, 50);
            this.SkierBtn.TabIndex = 5;
            this.SkierBtn.Text = "Лыжник";
            this.SkierBtn.UseVisualStyleBackColor = false;
            // 
            // BuyerBtn
            // 
            this.BuyerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.BuyerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuyerBtn.FlatAppearance.BorderSize = 0;
            this.BuyerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyerBtn.ForeColor = System.Drawing.Color.White;
            this.BuyerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyerBtn.Location = new System.Drawing.Point(0, 100);
            this.BuyerBtn.Name = "BuyerBtn";
            this.BuyerBtn.Size = new System.Drawing.Size(169, 50);
            this.BuyerBtn.TabIndex = 4;
            this.BuyerBtn.Text = "Скупщик";
            this.BuyerBtn.UseVisualStyleBackColor = false;
            // 
            // TherapistBtn
            // 
            this.TherapistBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.TherapistBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TherapistBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TherapistBtn.FlatAppearance.BorderSize = 0;
            this.TherapistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TherapistBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TherapistBtn.ForeColor = System.Drawing.Color.White;
            this.TherapistBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TherapistBtn.Location = new System.Drawing.Point(0, 50);
            this.TherapistBtn.Name = "TherapistBtn";
            this.TherapistBtn.Size = new System.Drawing.Size(169, 50);
            this.TherapistBtn.TabIndex = 3;
            this.TherapistBtn.Text = "Терапевт";
            this.TherapistBtn.UseVisualStyleBackColor = false;
            // 
            // EnsingBtn
            // 
            this.EnsingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.EnsingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnsingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnsingBtn.FlatAppearance.BorderSize = 0;
            this.EnsingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnsingBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnsingBtn.ForeColor = System.Drawing.Color.White;
            this.EnsingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnsingBtn.Location = new System.Drawing.Point(0, 0);
            this.EnsingBtn.Name = "EnsingBtn";
            this.EnsingBtn.Size = new System.Drawing.Size(169, 50);
            this.EnsingBtn.TabIndex = 2;
            this.EnsingBtn.Text = "Прапор";
            this.EnsingBtn.UseVisualStyleBackColor = false;

            this.CaretakerBtn.Click += new System.EventHandler((s, e) => this.LoadQuests(s, e, "Смотритель"));
            this.HuntsmanBtn.Click += new System.EventHandler((s, e) => this.LoadQuests(s, e, "Егерь"));
            this.FleaDealerBtn.Click += new System.EventHandler((s, e) => this.LoadQuests(s, e, "Барахольщик"));
            this.MechanicBtn.Click += new System.EventHandler((s, e) => this.LoadQuests(s, e, "Механик"));
            this.PeacemakerBtn.Click += new System.EventHandler((s, e) => this.LoadQuests(s, e, "Миротворец"));
            this.SkierBtn.Click += new System.EventHandler((s, e) => this.LoadQuests(s, e, "Лыжник"));
            this.BuyerBtn.Click += new System.EventHandler((s, e) => this.LoadQuests(s, e, "Скупщик"));
            this.TherapistBtn.Click += new System.EventHandler((s, e) => this.LoadQuests(s, e, "Терапевт"));
            this.EnsingBtn.Click += new System.EventHandler((s, e) => this.LoadQuests(s, e, "Прапор"));
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(175, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(693, 451);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.SearchBtn);
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 50);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(9, 12);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(200, 27);
            this.textBoxSearch.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBtn.Location = new System.Drawing.Point(215, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(95, 27);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 522);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(880, 522);
            this.Name = "QuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список квестов";
            this.Load += new System.EventHandler(this.QuestForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TherapistBtn;
        private System.Windows.Forms.Button EnsingBtn;
        private System.Windows.Forms.Button CaretakerBtn;
        private System.Windows.Forms.Button HuntsmanBtn;
        private System.Windows.Forms.Button FleaDealerBtn;
        private System.Windows.Forms.Button MechanicBtn;
        private System.Windows.Forms.Button PeacemakerBtn;
        private System.Windows.Forms.Button SkierBtn;
        private System.Windows.Forms.Button BuyerBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button SearchBtn;
    }
}