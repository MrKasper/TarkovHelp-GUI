namespace TarkovHelp
{
    partial class QuestCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxQuest = new System.Windows.Forms.PictureBox();
            this.labelWho = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelReward = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GoalQuest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DialogAfter = new System.Windows.Forms.TextBox();
            this.DialogBefore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.HowDone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelQuestName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuest)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.pictureBoxQuest);
            this.panel1.Controls.Add(this.labelWho);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 100);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // pictureBoxQuest
            // 
            this.pictureBoxQuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQuest.Location = new System.Drawing.Point(238, 0);
            this.pictureBoxQuest.Name = "pictureBoxQuest";
            this.pictureBoxQuest.Size = new System.Drawing.Size(220, 100);
            this.pictureBoxQuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQuest.TabIndex = 4;
            this.pictureBoxQuest.TabStop = false;
            // 
            // labelWho
            // 
            this.labelWho.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWho.ForeColor = System.Drawing.Color.White;
            this.labelWho.Location = new System.Drawing.Point(3, 0);
            this.labelWho.Name = "labelWho";
            this.labelWho.Size = new System.Drawing.Size(229, 30);
            this.labelWho.TabIndex = 3;
            this.labelWho.Text = "Выдает: ";
            this.labelWho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.labelReward);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(476, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 257);
            this.panel2.TabIndex = 2;
            // 
            // labelReward
            // 
            this.labelReward.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReward.ForeColor = System.Drawing.Color.White;
            this.labelReward.Location = new System.Drawing.Point(3, 30);
            this.labelReward.Name = "labelReward";
            this.labelReward.Size = new System.Drawing.Size(290, 227);
            this.labelReward.TabIndex = 4;
            this.labelReward.Text = "Выдает: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Награда за квест";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel3.Controls.Add(this.GoalQuest);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 150);
            this.panel3.TabIndex = 3;
            // 
            // GoalQuest
            // 
            this.GoalQuest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GoalQuest.Location = new System.Drawing.Point(0, 30);
            this.GoalQuest.Multiline = true;
            this.GoalQuest.Name = "GoalQuest";
            this.GoalQuest.ReadOnly = true;
            this.GoalQuest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GoalQuest.Size = new System.Drawing.Size(458, 120);
            this.GoalQuest.TabIndex = 6;
            this.GoalQuest.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цели квеста";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel4.Controls.Add(this.DialogAfter);
            this.panel4.Controls.Add(this.DialogBefore);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(476, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 400);
            this.panel4.TabIndex = 4;
            // 
            // DialogAfter
            // 
            this.DialogAfter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DialogAfter.Location = new System.Drawing.Point(0, 230);
            this.DialogAfter.Multiline = true;
            this.DialogAfter.Name = "DialogAfter";
            this.DialogAfter.ReadOnly = true;
            this.DialogAfter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DialogAfter.Size = new System.Drawing.Size(296, 170);
            this.DialogAfter.TabIndex = 8;
            this.DialogAfter.TabStop = false;
            // 
            // DialogBefore
            // 
            this.DialogBefore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DialogBefore.Location = new System.Drawing.Point(0, 24);
            this.DialogBefore.Multiline = true;
            this.DialogBefore.Name = "DialogBefore";
            this.DialogBefore.ReadOnly = true;
            this.DialogBefore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DialogBefore.Size = new System.Drawing.Size(296, 170);
            this.DialogBefore.TabIndex = 7;
            this.DialogBefore.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Диалог после выполнения квеста";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Диалог перед началом квеста";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel5.Controls.Add(this.HowDone);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(12, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(458, 444);
            this.panel5.TabIndex = 5;
            // 
            // HowDone
            // 
            this.HowDone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HowDone.Location = new System.Drawing.Point(0, 33);
            this.HowDone.Multiline = true;
            this.HowDone.Name = "HowDone";
            this.HowDone.ReadOnly = true;
            this.HowDone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HowDone.Size = new System.Drawing.Size(458, 411);
            this.HowDone.TabIndex = 7;
            this.HowDone.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(452, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Как выполнить квест?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(476, 714);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(296, 35);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Не выполнено";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(692, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 35);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelQuestName
            // 
            this.labelQuestName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelQuestName.ForeColor = System.Drawing.Color.White;
            this.labelQuestName.Location = new System.Drawing.Point(15, 6);
            this.labelQuestName.Name = "labelQuestName";
            this.labelQuestName.Size = new System.Drawing.Size(671, 30);
            this.labelQuestName.TabIndex = 8;
            this.labelQuestName.Text = "Квест проба пера";
            this.labelQuestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            // 
            // QuestCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.labelQuestName);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestCard";
            this.Load += new System.EventHandler(this.QuestCard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuest)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWho;
        private System.Windows.Forms.Label labelReward;
        private System.Windows.Forms.PictureBox pictureBoxQuest;
        private System.Windows.Forms.TextBox GoalQuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DialogBefore;
        private System.Windows.Forms.TextBox DialogAfter;
        private System.Windows.Forms.TextBox HowDone;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelQuestName;
    }
}