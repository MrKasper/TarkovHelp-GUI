namespace TarkovHelp
{
    partial class FleaMarketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FleaMarketForm));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.LogoIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BasePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AvgPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 314);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(246, 35);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(264, 314);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(108, 35);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // LogoIcon
            // 
            this.LogoIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoIcon.Location = new System.Drawing.Point(12, 12);
            this.LogoIcon.Name = "LogoIcon";
            this.LogoIcon.Size = new System.Drawing.Size(128, 128);
            this.LogoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoIcon.TabIndex = 2;
            this.LogoIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название предмета";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameItem
            // 
            this.NameItem.Enabled = false;
            this.NameItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameItem.Location = new System.Drawing.Point(146, 38);
            this.NameItem.Multiline = true;
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(226, 35);
            this.NameItem.TabIndex = 4;
            this.NameItem.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(146, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Базовая цена";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BasePrice
            // 
            this.BasePrice.Enabled = false;
            this.BasePrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BasePrice.Location = new System.Drawing.Point(146, 105);
            this.BasePrice.Multiline = true;
            this.BasePrice.Name = "BasePrice";
            this.BasePrice.Size = new System.Drawing.Size(226, 35);
            this.BasePrice.TabIndex = 6;
            this.BasePrice.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(146, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Средняя цена";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AvgPrice
            // 
            this.AvgPrice.Enabled = false;
            this.AvgPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvgPrice.Location = new System.Drawing.Point(146, 169);
            this.AvgPrice.Multiline = true;
            this.AvgPrice.Name = "AvgPrice";
            this.AvgPrice.Size = new System.Drawing.Size(226, 35);
            this.AvgPrice.TabIndex = 8;
            this.AvgPrice.TabStop = false;
            // 
            // FleaMarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.AvgPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BasePrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoIcon);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FleaMarketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Барахолка v0.1";
            this.Load += new System.EventHandler(this.FleaMarketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox LogoIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BasePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AvgPrice;
    }
}