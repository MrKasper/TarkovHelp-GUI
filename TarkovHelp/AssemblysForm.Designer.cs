namespace TarkovHelp
{
    partial class AssemblysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssemblysForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNog = new System.Windows.Forms.Button();
            this.buttonPistol = new System.Windows.Forms.Button();
            this.buttonKarabin = new System.Windows.Forms.Button();
            this.buttonShot = new System.Windows.Forms.Button();
            this.buttonPP = new System.Windows.Forms.Button();
            this.buttonBolt = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ShturmBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.buttonNog);
            this.panel1.Controls.Add(this.buttonPistol);
            this.panel1.Controls.Add(this.buttonKarabin);
            this.panel1.Controls.Add(this.buttonShot);
            this.panel1.Controls.Add(this.buttonPP);
            this.panel1.Controls.Add(this.buttonBolt);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Controls.Add(this.ShturmBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 462);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // buttonNog
            // 
            this.buttonNog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonNog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNog.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNog.FlatAppearance.BorderSize = 0;
            this.buttonNog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNog.ForeColor = System.Drawing.Color.White;
            this.buttonNog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNog.Location = new System.Drawing.Point(0, 300);
            this.buttonNog.Name = "buttonNog";
            this.buttonNog.Size = new System.Drawing.Size(169, 50);
            this.buttonNog.TabIndex = 12;
            this.buttonNog.Text = "По ногам";
            this.buttonNog.UseVisualStyleBackColor = false;
            this.ShturmBtn.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Штурмовые винтовки"));
            this.buttonBolt.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Болтовые винтовки"));
            this.buttonPP.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Пистолет-пулеметы"));
            this.buttonShot.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Дробовики"));
            this.buttonKarabin.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Карабины"));
            this.buttonPistol.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "Пистолеты"));
            this.buttonNog.Click += new System.EventHandler((s, e) => this.LoadWeapons(s, e, "По ногам"));
            // 
            // buttonPistol
            // 
            this.buttonPistol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonPistol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPistol.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPistol.FlatAppearance.BorderSize = 0;
            this.buttonPistol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPistol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPistol.ForeColor = System.Drawing.Color.White;
            this.buttonPistol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPistol.Location = new System.Drawing.Point(0, 250);
            this.buttonPistol.Name = "buttonPistol";
            this.buttonPistol.Size = new System.Drawing.Size(169, 50);
            this.buttonPistol.TabIndex = 11;
            this.buttonPistol.Text = "Пистолеты";
            this.buttonPistol.UseVisualStyleBackColor = false;
            // 
            // buttonKarabin
            // 
            this.buttonKarabin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonKarabin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKarabin.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKarabin.FlatAppearance.BorderSize = 0;
            this.buttonKarabin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKarabin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKarabin.ForeColor = System.Drawing.Color.White;
            this.buttonKarabin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKarabin.Location = new System.Drawing.Point(0, 200);
            this.buttonKarabin.Name = "buttonKarabin";
            this.buttonKarabin.Size = new System.Drawing.Size(169, 50);
            this.buttonKarabin.TabIndex = 10;
            this.buttonKarabin.Text = "Карабины";
            this.buttonKarabin.UseVisualStyleBackColor = false;
            // 
            // buttonShot
            // 
            this.buttonShot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonShot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShot.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShot.FlatAppearance.BorderSize = 0;
            this.buttonShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShot.ForeColor = System.Drawing.Color.White;
            this.buttonShot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShot.Location = new System.Drawing.Point(0, 150);
            this.buttonShot.Name = "buttonShot";
            this.buttonShot.Size = new System.Drawing.Size(169, 50);
            this.buttonShot.TabIndex = 9;
            this.buttonShot.Text = "Дробовики";
            this.buttonShot.UseVisualStyleBackColor = false;
            // 
            // buttonPP
            // 
            this.buttonPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonPP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPP.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPP.FlatAppearance.BorderSize = 0;
            this.buttonPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPP.ForeColor = System.Drawing.Color.White;
            this.buttonPP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPP.Location = new System.Drawing.Point(0, 100);
            this.buttonPP.Name = "buttonPP";
            this.buttonPP.Size = new System.Drawing.Size(169, 50);
            this.buttonPP.TabIndex = 8;
            this.buttonPP.Text = "Пистолет-пулеметы";
            this.buttonPP.UseVisualStyleBackColor = false;
            // 
            // buttonBolt
            // 
            this.buttonBolt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonBolt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBolt.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBolt.FlatAppearance.BorderSize = 0;
            this.buttonBolt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBolt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBolt.ForeColor = System.Drawing.Color.White;
            this.buttonBolt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBolt.Location = new System.Drawing.Point(0, 50);
            this.buttonBolt.Name = "buttonBolt";
            this.buttonBolt.Size = new System.Drawing.Size(169, 50);
            this.buttonBolt.TabIndex = 7;
            this.buttonBolt.Text = "Болтовые винтовки";
            this.buttonBolt.UseVisualStyleBackColor = false;
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
            // ShturmBtn
            // 
            this.ShturmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ShturmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShturmBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShturmBtn.FlatAppearance.BorderSize = 0;
            this.ShturmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShturmBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShturmBtn.ForeColor = System.Drawing.Color.White;
            this.ShturmBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShturmBtn.Location = new System.Drawing.Point(0, 0);
            this.ShturmBtn.Name = "ShturmBtn";
            this.ShturmBtn.Size = new System.Drawing.Size(169, 50);
            this.ShturmBtn.TabIndex = 2;
            this.ShturmBtn.Text = "Штурмовые винтовки";
            this.ShturmBtn.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(175, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(716, 451);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // AssemblysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 462);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 462);
            this.MinimumSize = new System.Drawing.Size(900, 462);
            this.Name = "AssemblysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сборки";
            this.Load += new System.EventHandler(this.AssemblysForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button ShturmBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonPP;
        private System.Windows.Forms.Button buttonBolt;
        private System.Windows.Forms.Button buttonShot;
        private System.Windows.Forms.Button buttonKarabin;
        private System.Windows.Forms.Button buttonPistol;
        private System.Windows.Forms.Button buttonNog;
    }
}