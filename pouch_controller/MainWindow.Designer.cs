namespace pouch_controller
{
    partial class MainWindow
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
            this.CancelDelete = new System.Windows.Forms.Button();
            this.DeleteButtonOk = new System.Windows.Forms.Button();
            this.DeleteId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TinePanel.SuspendLayout();
            this.AddNewPanel.SuspendLayout();
            this.DeletePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spendingTree
            // 
            this.spendingTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spendingTree.Location = new System.Drawing.Point(0, 0);
            this.spendingTree.Margin = new System.Windows.Forms.Padding(5);
            this.spendingTree.Name = "spendingTree";
            this.spendingTree.Size = new System.Drawing.Size(1672, 821);
            this.spendingTree.TabIndex = 0;
            // 
            // AddNewSpending
            // 
            this.AddNewSpending.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddNewSpending.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddNewSpending.Location = new System.Drawing.Point(30, 33);
            this.AddNewSpending.Margin = new System.Windows.Forms.Padding(5);
            this.AddNewSpending.Name = "AddNewSpending";
            this.AddNewSpending.Size = new System.Drawing.Size(177, 42);
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
            this.TinePanel.Location = new System.Drawing.Point(32, 125);
            this.TinePanel.Margin = new System.Windows.Forms.Padding(5);
            this.TinePanel.Name = "TinePanel";
            this.TinePanel.Size = new System.Drawing.Size(175, 254);
            this.TinePanel.TabIndex = 2;
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(7, 208);
            this.Day.Margin = new System.Windows.Forms.Padding(5);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(85, 33);
            this.Day.TabIndex = 4;
            this.Day.TabStop = true;
            this.Day.Text = "Day";
            this.Day.UseVisualStyleBackColor = true;
            this.Day.CheckedChanged += new System.EventHandler(this.Day_CheckedChanged);
            // 
            // Week
            // 
            this.Week.AutoSize = true;
            this.Week.Location = new System.Drawing.Point(7, 158);
            this.Week.Margin = new System.Windows.Forms.Padding(5);
            this.Week.Name = "Week";
            this.Week.Size = new System.Drawing.Size(106, 33);
            this.Week.TabIndex = 3;
            this.Week.TabStop = true;
            this.Week.Text = "Week";
            this.Week.UseVisualStyleBackColor = true;
            this.Week.CheckedChanged += new System.EventHandler(this.Week_CheckedChanged);
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Location = new System.Drawing.Point(7, 107);
            this.Month.Margin = new System.Windows.Forms.Padding(5);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(110, 33);
            this.Month.TabIndex = 2;
            this.Month.TabStop = true;
            this.Month.Text = "Month";
            this.Month.UseVisualStyleBackColor = true;
            this.Month.CheckedChanged += new System.EventHandler(this.Month_CheckedChanged);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(7, 56);
            this.Year.Margin = new System.Windows.Forms.Padding(5);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(95, 33);
            this.Year.TabIndex = 1;
            this.Year.TabStop = true;
            this.Year.Text = "Year";
            this.Year.UseVisualStyleBackColor = true;
            this.Year.CheckedChanged += new System.EventHandler(this.Year_CheckedChanged);
            // 
            // AllTime
            // 
            this.AllTime.AutoSize = true;
            this.AllTime.Location = new System.Drawing.Point(7, 7);
            this.AllTime.Margin = new System.Windows.Forms.Padding(5);
            this.AllTime.Name = "AllTime";
            this.AllTime.Size = new System.Drawing.Size(127, 33);
            this.AllTime.TabIndex = 0;
            this.AllTime.TabStop = true;
            this.AllTime.Text = "AllTime";
            this.AllTime.UseVisualStyleBackColor = true;
            this.AllTime.CheckedChanged += new System.EventHandler(this.AllTime_CheckedChanged);
            // 
            // TegsText
            // 
            this.TegsText.BackColor = System.Drawing.SystemColors.Menu;
            this.TegsText.Location = new System.Drawing.Point(30, 390);
            this.TegsText.Margin = new System.Windows.Forms.Padding(5);
            this.TegsText.Multiline = true;
            this.TegsText.Name = "TegsText";
            this.TegsText.Size = new System.Drawing.Size(172, 295);
            this.TegsText.TabIndex = 3;
            this.TegsText.Text = "Tags:";
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
            this.AddNewPanel.Location = new System.Drawing.Point(446, 121);
            this.AddNewPanel.Margin = new System.Windows.Forms.Padding(5);
            this.AddNewPanel.Name = "AddNewPanel";
            this.AddNewPanel.Size = new System.Drawing.Size(599, 553);
            this.AddNewPanel.TabIndex = 4;
            this.AddNewPanel.Visible = false;
            // 
            // AddingCancel
            // 
            this.AddingCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingCancel.Location = new System.Drawing.Point(0, 429);
            this.AddingCancel.Margin = new System.Windows.Forms.Padding(5);
            this.AddingCancel.Name = "AddingCancel";
            this.AddingCancel.Size = new System.Drawing.Size(597, 42);
            this.AddingCancel.TabIndex = 9;
            this.AddingCancel.Text = "Cancel";
            this.AddingCancel.UseVisualStyleBackColor = true;
            this.AddingCancel.Click += new System.EventHandler(this.AddingCancel_Click);
            // 
            // AddingAdd
            // 
            this.AddingAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingAdd.Location = new System.Drawing.Point(0, 387);
            this.AddingAdd.Margin = new System.Windows.Forms.Padding(5);
            this.AddingAdd.Name = "AddingAdd";
            this.AddingAdd.Size = new System.Drawing.Size(597, 42);
            this.AddingAdd.TabIndex = 8;
            this.AddingAdd.Text = "Add";
            this.AddingAdd.UseVisualStyleBackColor = true;
            this.AddingAdd.Click += new System.EventHandler(this.AddingAdd_Click);
            // 
            // AddingDateTime
            // 
            this.AddingDateTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingDateTime.Location = new System.Drawing.Point(0, 352);
            this.AddingDateTime.Margin = new System.Windows.Forms.Padding(5);
            this.AddingDateTime.Name = "AddingDateTime";
            this.AddingDateTime.Size = new System.Drawing.Size(597, 35);
            this.AddingDateTime.TabIndex = 7;
            // 
            // AddingCurrentDate
            // 
            this.AddingCurrentDate.AutoSize = true;
            this.AddingCurrentDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingCurrentDate.Location = new System.Drawing.Point(0, 319);
            this.AddingCurrentDate.Margin = new System.Windows.Forms.Padding(5);
            this.AddingCurrentDate.Name = "AddingCurrentDate";
            this.AddingCurrentDate.Size = new System.Drawing.Size(597, 33);
            this.AddingCurrentDate.TabIndex = 6;
            this.AddingCurrentDate.TabStop = true;
            this.AddingCurrentDate.Text = "Current Date?";
            this.AddingCurrentDate.UseVisualStyleBackColor = true;
            this.AddingCurrentDate.CheckedChanged += new System.EventHandler(this.AddingCurrentDate_CheckedChanged);
            // 
            // AddingTegs
            // 
            this.AddingTegs.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingTegs.Location = new System.Drawing.Point(0, 157);
            this.AddingTegs.Margin = new System.Windows.Forms.Padding(5);
            this.AddingTegs.Multiline = true;
            this.AddingTegs.Name = "AddingTegs";
            this.AddingTegs.Size = new System.Drawing.Size(597, 162);
            this.AddingTegs.TabIndex = 5;
            // 
            // Tesfdsfssdf
            // 
            this.Tesfdsfssdf.AutoSize = true;
            this.Tesfdsfssdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tesfdsfssdf.Location = new System.Drawing.Point(0, 128);
            this.Tesfdsfssdf.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Tesfdsfssdf.Name = "Tesfdsfssdf";
            this.Tesfdsfssdf.Size = new System.Drawing.Size(68, 29);
            this.Tesfdsfssdf.TabIndex = 4;
            this.Tesfdsfssdf.Text = "Tags";
            // 
            // AddingDescribtion
            // 
            this.AddingDescribtion.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingDescribtion.Location = new System.Drawing.Point(0, 93);
            this.AddingDescribtion.Margin = new System.Windows.Forms.Padding(5);
            this.AddingDescribtion.Name = "AddingDescribtion";
            this.AddingDescribtion.Size = new System.Drawing.Size(597, 35);
            this.AddingDescribtion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Describtion";
            // 
            // AddingCount
            // 
            this.AddingCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddingCount.Location = new System.Drawing.Point(0, 29);
            this.AddingCount.Margin = new System.Windows.Forms.Padding(5);
            this.AddingCount.Name = "AddingCount";
            this.AddingCount.Size = new System.Drawing.Size(597, 35);
            this.AddingCount.TabIndex = 1;
            this.AddingCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteButton.Location = new System.Drawing.Point(30, 73);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(177, 42);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeletePanel
            // 
            this.DeletePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DeletePanel.Controls.Add(this.CancelDelete);
            this.DeletePanel.Controls.Add(this.DeleteButtonOk);
            this.DeletePanel.Controls.Add(this.DeleteId);
            this.DeletePanel.Controls.Add(this.label4);
            this.DeletePanel.Controls.Add(this.label3);
            this.DeletePanel.Location = new System.Drawing.Point(446, 509);
            this.DeletePanel.Margin = new System.Windows.Forms.Padding(5);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(598, 121);
            this.DeletePanel.TabIndex = 6;
            // 
            // CancelDelete
            // 
            this.CancelDelete.Location = new System.Drawing.Point(306, 74);
            this.CancelDelete.Margin = new System.Windows.Forms.Padding(5);
            this.CancelDelete.Name = "CancelDelete";
            this.CancelDelete.Size = new System.Drawing.Size(287, 42);
            this.CancelDelete.TabIndex = 4;
            this.CancelDelete.Text = "Cancel";
            this.CancelDelete.UseVisualStyleBackColor = true;
            this.CancelDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteButtonOk
            // 
            this.DeleteButtonOk.Location = new System.Drawing.Point(9, 74);
            this.DeleteButtonOk.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteButtonOk.Name = "DeleteButtonOk";
            this.DeleteButtonOk.Size = new System.Drawing.Size(290, 42);
            this.DeleteButtonOk.TabIndex = 3;
            this.DeleteButtonOk.Text = "Delete";
            this.DeleteButtonOk.UseVisualStyleBackColor = true;
            this.DeleteButtonOk.Click += new System.EventHandler(this.DeleteButtonOk_Click);
            // 
            // DeleteId
            // 
            this.DeleteId.Location = new System.Drawing.Point(47, 33);
            this.DeleteId.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteId.Name = "DeleteId";
            this.DeleteId.Size = new System.Drawing.Size(508, 35);
            this.DeleteId.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "DELETE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.TinePanel);
            this.panel1.Controls.Add(this.AddNewSpending);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.TegsText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1432, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 821);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 821);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.AddNewPanel);
            this.Controls.Add(this.spendingTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TinePanel.ResumeLayout(false);
            this.TinePanel.PerformLayout();
            this.AddNewPanel.ResumeLayout(false);
            this.AddNewPanel.PerformLayout();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}

