namespace pouch_controller
{
    partial class Form1
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
            this.spendingTree = new System.Windows.Forms.TreeView();
            this.AddNewSpending = new System.Windows.Forms.Button();
            this.TinePanel = new System.Windows.Forms.Panel();
            this.Day = new System.Windows.Forms.RadioButton();
            this.Week = new System.Windows.Forms.RadioButton();
            this.Month = new System.Windows.Forms.RadioButton();
            this.Year = new System.Windows.Forms.RadioButton();
            this.AllTime = new System.Windows.Forms.RadioButton();
            this.TegsText = new System.Windows.Forms.TextBox();
            this.AddNewPanel = new System.Windows.Forms.Panel();
            this.AddingCancel = new System.Windows.Forms.Button();
            this.AddingAdd = new System.Windows.Forms.Button();
            this.AddingDateTime = new System.Windows.Forms.DateTimePicker();
            this.AddingCurrentDate = new System.Windows.Forms.RadioButton();
            this.AddingTegs = new System.Windows.Forms.TextBox();
            this.Tesfdsfssdf = new System.Windows.Forms.Label();
            this.AddingDescribtion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddingCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteId = new System.Windows.Forms.TextBox();
            this.DeleteButtonOk = new System.Windows.Forms.Button();
            this.CancelDelete = new System.Windows.Forms.Button();
            this.TinePanel.SuspendLayout();
            this.AddNewPanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // spendingTree
            // 
            this.spendingTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spendingTree.Location = new System.Drawing.Point(0, 0);
            this.spendingTree.Name = "spendingTree";
            this.spendingTree.Size = new System.Drawing.Size(882, 453);
            this.spendingTree.TabIndex = 0;
            // 
            // AddNewSpending
            // 
            this.AddNewSpending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewSpending.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddNewSpending.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddNewSpending.Location = new System.Drawing.Point(727, 12);
            this.AddNewSpending.Name = "AddNewSpending";
            this.AddNewSpending.Size = new System.Drawing.Size(101, 23);
            this.AddNewSpending.TabIndex = 1;
            this.AddNewSpending.Text = "ADD";
            this.AddNewSpending.UseVisualStyleBackColor = false;
            this.AddNewSpending.Click += new System.EventHandler(this.AddNewSpending_Click);
            // 
            // TinePanel
            // 
            this.TinePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TinePanel.Controls.Add(this.Day);
            this.TinePanel.Controls.Add(this.Week);
            this.TinePanel.Controls.Add(this.Month);
            this.TinePanel.Controls.Add(this.Year);
            this.TinePanel.Controls.Add(this.AllTime);
            this.TinePanel.Location = new System.Drawing.Point(727, 63);
            this.TinePanel.Name = "TinePanel";
            this.TinePanel.Size = new System.Drawing.Size(101, 141);
            this.TinePanel.TabIndex = 2;
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(4, 115);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(54, 21);
            this.Day.TabIndex = 4;
            this.Day.TabStop = true;
            this.Day.Text = "Day";
            this.Day.UseVisualStyleBackColor = true;
            this.Day.CheckedChanged += new System.EventHandler(this.Day_CheckedChanged);
            // 
            // Week
            // 
            this.Week.AutoSize = true;
            this.Week.Location = new System.Drawing.Point(4, 87);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(65, 21);
            this.Week.TabIndex = 3;
            this.Week.TabStop = true;
            this.Week.Text = "Week";
            this.Week.UseVisualStyleBackColor = true;
            this.Week.CheckedChanged += new System.EventHandler(this.Week_CheckedChanged);
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Location = new System.Drawing.Point(4, 59);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(68, 21);
            this.Month.TabIndex = 2;
            this.Month.TabStop = true;
            this.Month.Text = "Month";
            this.Month.UseVisualStyleBackColor = true;
            this.Month.CheckedChanged += new System.EventHandler(this.Month_CheckedChanged);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(4, 31);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(59, 21);
            this.Year.TabIndex = 1;
            this.Year.TabStop = true;
            this.Year.Text = "Year";
            this.Year.UseVisualStyleBackColor = true;
            this.Year.CheckedChanged += new System.EventHandler(this.Year_CheckedChanged);
            // 
            // AllTime
            // 
            this.AllTime.AutoSize = true;
            this.AllTime.Location = new System.Drawing.Point(4, 4);
            this.AllTime.Name = "AllTime";
            this.AllTime.Size = new System.Drawing.Size(75, 21);
            this.AllTime.TabIndex = 0;
            this.AllTime.TabStop = true;
            this.AllTime.Text = "AllTime";
            this.AllTime.UseVisualStyleBackColor = true;
            this.AllTime.CheckedChanged += new System.EventHandler(this.AllTime_CheckedChanged);
            // 
            // TegsText
            // 
            this.TegsText.BackColor = System.Drawing.SystemColors.Menu;
            this.TegsText.Location = new System.Drawing.Point(727, 210);
            this.TegsText.Multiline = true;
            this.TegsText.Name = "TegsText";
            this.TegsText.Size = new System.Drawing.Size(100, 163);
            this.TegsText.TabIndex = 3;
            this.TegsText.Text = "Tegs:";
            this.TegsText.TextChanged += new System.EventHandler(this.TegsText_TextChanged);
            // 
            // AddNewPanel
            // 
            this.AddNewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddNewPanel.Controls.Add(this.AddingCancel);
            this.AddNewPanel.Controls.Add(this.AddingAdd);
            this.AddNewPanel.Controls.Add(this.AddingDateTime);
            this.AddNewPanel.Controls.Add(this.AddingCurrentDate);
            this.AddNewPanel.Controls.Add(this.AddingTegs);
            this.AddNewPanel.Controls.Add(this.Tesfdsfssdf);
            this.AddNewPanel.Controls.Add(this.AddingDescribtion);
            this.AddNewPanel.Controls.Add(this.label2);
            this.AddNewPanel.Controls.Add(this.AddingCount);
            this.AddNewPanel.Controls.Add(this.label1);
            this.AddNewPanel.Location = new System.Drawing.Point(255, 67);
            this.AddNewPanel.Name = "AddNewPanel";
            this.AddNewPanel.Size = new System.Drawing.Size(343, 306);
            this.AddNewPanel.TabIndex = 4;
            this.AddNewPanel.Visible = false;
            // 
            // AddingCancel
            // 
            this.AddingCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingCancel.Location = new System.Drawing.Point(0, 252);
            this.AddingCancel.Name = "AddingCancel";
            this.AddingCancel.Size = new System.Drawing.Size(341, 23);
            this.AddingCancel.TabIndex = 9;
            this.AddingCancel.Text = "Cancel";
            this.AddingCancel.UseVisualStyleBackColor = true;
            this.AddingCancel.Click += new System.EventHandler(this.AddingCancel_Click);
            // 
            // AddingAdd
            // 
            this.AddingAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingAdd.Location = new System.Drawing.Point(0, 229);
            this.AddingAdd.Name = "AddingAdd";
            this.AddingAdd.Size = new System.Drawing.Size(341, 23);
            this.AddingAdd.TabIndex = 8;
            this.AddingAdd.Text = "Add";
            this.AddingAdd.UseVisualStyleBackColor = true;
            this.AddingAdd.Click += new System.EventHandler(this.AddingAdd_Click);
            // 
            // AddingDateTime
            // 
            this.AddingDateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingDateTime.Location = new System.Drawing.Point(0, 207);
            this.AddingDateTime.Name = "AddingDateTime";
            this.AddingDateTime.Size = new System.Drawing.Size(341, 22);
            this.AddingDateTime.TabIndex = 7;
            // 
            // AddingCurrentDate
            // 
            this.AddingCurrentDate.AutoSize = true;
            this.AddingCurrentDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingCurrentDate.Location = new System.Drawing.Point(0, 186);
            this.AddingCurrentDate.Name = "AddingCurrentDate";
            this.AddingCurrentDate.Size = new System.Drawing.Size(341, 21);
            this.AddingCurrentDate.TabIndex = 6;
            this.AddingCurrentDate.TabStop = true;
            this.AddingCurrentDate.Text = "Current Date?";
            this.AddingCurrentDate.UseVisualStyleBackColor = true;
            this.AddingCurrentDate.CheckedChanged += new System.EventHandler(this.AddingCurrentDate_CheckedChanged);
            // 
            // AddingTegs
            // 
            this.AddingTegs.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingTegs.Location = new System.Drawing.Point(0, 95);
            this.AddingTegs.Multiline = true;
            this.AddingTegs.Name = "AddingTegs";
            this.AddingTegs.Size = new System.Drawing.Size(341, 91);
            this.AddingTegs.TabIndex = 5;
            // 
            // Tesfdsfssdf
            // 
            this.Tesfdsfssdf.AutoSize = true;
            this.Tesfdsfssdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tesfdsfssdf.Location = new System.Drawing.Point(0, 78);
            this.Tesfdsfssdf.Name = "Tesfdsfssdf";
            this.Tesfdsfssdf.Size = new System.Drawing.Size(40, 17);
            this.Tesfdsfssdf.TabIndex = 4;
            this.Tesfdsfssdf.Text = "Tegs";
            // 
            // AddingDescribtion
            // 
            this.AddingDescribtion.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingDescribtion.Location = new System.Drawing.Point(0, 56);
            this.AddingDescribtion.Name = "AddingDescribtion";
            this.AddingDescribtion.Size = new System.Drawing.Size(341, 22);
            this.AddingDescribtion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Describtion";
            // 
            // AddingCount
            // 
            this.AddingCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingCount.Location = new System.Drawing.Point(0, 17);
            this.AddingCount.Name = "AddingCount";
            this.AddingCount.Size = new System.Drawing.Size(341, 22);
            this.AddingCount.TabIndex = 1;
            this.AddingCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteButton.Location = new System.Drawing.Point(727, 34);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeletePanel
            // 
            this.DeletePanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DeletePanel.Controls.Add(this.CancelDelete);
            this.DeletePanel.Controls.Add(this.DeleteButtonOk);
            this.DeletePanel.Controls.Add(this.DeleteId);
            this.DeletePanel.Controls.Add(this.label4);
            this.DeletePanel.Controls.Add(this.label3);
            this.DeletePanel.Location = new System.Drawing.Point(255, 281);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(342, 67);
            this.DeletePanel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "DELETE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // DeleteId
            // 
            this.DeleteId.Location = new System.Drawing.Point(27, 18);
            this.DeleteId.Name = "DeleteId";
            this.DeleteId.Size = new System.Drawing.Size(292, 22);
            this.DeleteId.TabIndex = 2;
            // 
            // DeleteButtonOk
            // 
            this.DeleteButtonOk.Location = new System.Drawing.Point(5, 41);
            this.DeleteButtonOk.Name = "DeleteButtonOk";
            this.DeleteButtonOk.Size = new System.Drawing.Size(166, 23);
            this.DeleteButtonOk.TabIndex = 3;
            this.DeleteButtonOk.Text = "Delete";
            this.DeleteButtonOk.UseVisualStyleBackColor = true;
            this.DeleteButtonOk.Click += new System.EventHandler(this.DeleteButtonOk_Click);
            // 
            // CancelDelete
            // 
            this.CancelDelete.Location = new System.Drawing.Point(175, 41);
            this.CancelDelete.Name = "CancelDelete";
            this.CancelDelete.Size = new System.Drawing.Size(164, 23);
            this.CancelDelete.TabIndex = 4;
            this.CancelDelete.Text = "Cancel";
            this.CancelDelete.UseVisualStyleBackColor = true;
            this.CancelDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddNewPanel);
            this.Controls.Add(this.TegsText);
            this.Controls.Add(this.TinePanel);
            this.Controls.Add(this.AddNewSpending);
            this.Controls.Add(this.spendingTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TinePanel.ResumeLayout(false);
            this.TinePanel.PerformLayout();
            this.AddNewPanel.ResumeLayout(false);
            this.AddNewPanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView spendingTree;
        private System.Windows.Forms.Button AddNewSpending;
        private System.Windows.Forms.Panel TinePanel;
        private System.Windows.Forms.RadioButton Day;
        private System.Windows.Forms.RadioButton Week;
        private System.Windows.Forms.RadioButton Month;
        private System.Windows.Forms.RadioButton Year;
        private System.Windows.Forms.RadioButton AllTime;
        private System.Windows.Forms.TextBox TegsText;
        private System.Windows.Forms.Panel AddNewPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddingCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddingTegs;
        private System.Windows.Forms.Label Tesfdsfssdf;
        private System.Windows.Forms.TextBox AddingDescribtion;
        private System.Windows.Forms.DateTimePicker AddingDateTime;
        private System.Windows.Forms.Button AddingCancel;
        private System.Windows.Forms.Button AddingAdd;
        private System.Windows.Forms.RadioButton AddingCurrentDate;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelDelete;
        private System.Windows.Forms.Button DeleteButtonOk;
        private System.Windows.Forms.TextBox DeleteId;
        private System.Windows.Forms.Label label4;
    }
}

