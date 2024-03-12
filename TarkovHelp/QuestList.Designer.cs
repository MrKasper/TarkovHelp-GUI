namespace TarkovHelp
{
    partial class QuestList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestList));
            this.dataGridViewQuests = new System.Windows.Forms.DataGridView();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuestGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDialogBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDialogAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuests
            // 
            this.dataGridViewQuests.AllowUserToAddRows = false;
            this.dataGridViewQuests.AllowUserToDeleteRows = false;
            this.dataGridViewQuests.AllowUserToResizeRows = false;
            this.dataGridViewQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnQuester,
            this.ColumnQuestName,
            this.ColumnQuestGoal,
            this.ColumnDialogBefore,
            this.ColumnDialogAfter,
            this.ColumnReward});
            this.dataGridViewQuests.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewQuests.Name = "dataGridViewQuests";
            this.dataGridViewQuests.RowHeadersVisible = false;
            this.dataGridViewQuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuests.Size = new System.Drawing.Size(625, 400);
            this.dataGridViewQuests.TabIndex = 0;
            this.dataGridViewQuests.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewQuests_CellMouseDoubleClick);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(12, 418);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(93, 418);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.Text = "Обновить";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 25;
            // 
            // ColumnQuester
            // 
            this.ColumnQuester.FillWeight = 75F;
            this.ColumnQuester.HeaderText = "Квестер";
            this.ColumnQuester.Name = "ColumnQuester";
            this.ColumnQuester.ReadOnly = true;
            this.ColumnQuester.Width = 80;
            // 
            // ColumnQuestName
            // 
            this.ColumnQuestName.HeaderText = "Имя квеста";
            this.ColumnQuestName.Name = "ColumnQuestName";
            this.ColumnQuestName.ReadOnly = true;
            // 
            // ColumnQuestGoal
            // 
            this.ColumnQuestGoal.HeaderText = "Задачи";
            this.ColumnQuestGoal.Name = "ColumnQuestGoal";
            this.ColumnQuestGoal.ReadOnly = true;
            // 
            // ColumnDialogBefore
            // 
            this.ColumnDialogBefore.HeaderText = "Диалог до";
            this.ColumnDialogBefore.Name = "ColumnDialogBefore";
            this.ColumnDialogBefore.ReadOnly = true;
            // 
            // ColumnDialogAfter
            // 
            this.ColumnDialogAfter.HeaderText = "Диалог после";
            this.ColumnDialogAfter.Name = "ColumnDialogAfter";
            this.ColumnDialogAfter.ReadOnly = true;
            // 
            // ColumnReward
            // 
            this.ColumnReward.HeaderText = "Награда";
            this.ColumnReward.Name = "ColumnReward";
            this.ColumnReward.ReadOnly = true;
            // 
            // QuestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 453);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.dataGridViewQuests);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestList";
            this.Load += new System.EventHandler(this.QuestList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuests;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuestGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDialogBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDialogAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReward;
    }
}