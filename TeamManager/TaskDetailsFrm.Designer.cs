namespace TeamManager
{
    partial class TaskDetailsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetailsFrm));
            this.panelContent = new System.Windows.Forms.Panel();
            this.clbSubTasks = new System.Windows.Forms.CheckedListBox();
            this.lsbFiles = new DevExpress.XtraEditors.ListBoxControl();
            this.lsbEmployees = new DevExpress.XtraEditors.ListBoxControl();
            this.btnComment = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateTask = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditSubTask = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditEmp = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditFile = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDeadLine = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsbFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsbEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.clbSubTasks);
            this.panelContent.Controls.Add(this.lsbFiles);
            this.panelContent.Controls.Add(this.lsbEmployees);
            this.panelContent.Controls.Add(this.btnComment);
            this.panelContent.Controls.Add(this.btnUpdateTask);
            this.panelContent.Controls.Add(this.btnEditSubTask);
            this.panelContent.Controls.Add(this.btnEditEmp);
            this.panelContent.Controls.Add(this.btnEditFile);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.dtpDeadLine);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.cmbCategory);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.cmbPriority);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.txtName);
            this.panelContent.Controls.Add(this.label8);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Location = new System.Drawing.Point(30, 11);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1080, 486);
            this.panelContent.TabIndex = 22;
            // 
            // clbSubTasks
            // 
            this.clbSubTasks.BackColor = System.Drawing.Color.White;
            this.clbSubTasks.CheckOnClick = true;
            this.clbSubTasks.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSubTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.clbSubTasks.FormattingEnabled = true;
            this.clbSubTasks.Location = new System.Drawing.Point(653, 114);
            this.clbSubTasks.Name = "clbSubTasks";
            this.clbSubTasks.Size = new System.Drawing.Size(169, 211);
            this.clbSubTasks.TabIndex = 33;
            // 
            // lsbFiles
            // 
            this.lsbFiles.Appearance.BackColor = System.Drawing.Color.White;
            this.lsbFiles.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbFiles.Appearance.Options.UseBackColor = true;
            this.lsbFiles.Appearance.Options.UseFont = true;
            this.lsbFiles.Location = new System.Drawing.Point(852, 116);
            this.lsbFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbFiles.Name = "lsbFiles";
            this.lsbFiles.Size = new System.Drawing.Size(169, 197);
            this.lsbFiles.TabIndex = 31;
            this.lsbFiles.Click += new System.EventHandler(this.lsbFiles_Click);
            // 
            // lsbEmployees
            // 
            this.lsbEmployees.Appearance.BackColor = System.Drawing.Color.White;
            this.lsbEmployees.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbEmployees.Appearance.Options.UseBackColor = true;
            this.lsbEmployees.Appearance.Options.UseFont = true;
            this.lsbEmployees.Location = new System.Drawing.Point(449, 116);
            this.lsbEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbEmployees.Name = "lsbEmployees";
            this.lsbEmployees.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lsbEmployees.Size = new System.Drawing.Size(169, 197);
            this.lsbEmployees.TabIndex = 30;
            // 
            // btnComment
            // 
            this.btnComment.Appearance.BackColor = System.Drawing.Color.White;
            this.btnComment.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnComment.Appearance.Options.UseBackColor = true;
            this.btnComment.Appearance.Options.UseFont = true;
            this.btnComment.Appearance.Options.UseForeColor = true;
            this.btnComment.Location = new System.Drawing.Point(50, 346);
            this.btnComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(169, 44);
            this.btnComment.TabIndex = 28;
            this.btnComment.Text = "Comments";
            this.btnComment.Click += new System.EventHandler(this.BtnComment_Click);
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Appearance.BackColor = System.Drawing.Color.White;
            this.btnUpdateTask.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTask.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnUpdateTask.Appearance.Options.UseBackColor = true;
            this.btnUpdateTask.Appearance.Options.UseFont = true;
            this.btnUpdateTask.Appearance.Options.UseForeColor = true;
            this.btnUpdateTask.Location = new System.Drawing.Point(886, 423);
            this.btnUpdateTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(169, 44);
            this.btnUpdateTask.TabIndex = 27;
            this.btnUpdateTask.Text = "Update";
            this.btnUpdateTask.Click += new System.EventHandler(this.BtnUpdateTask_Click);
            // 
            // btnEditSubTask
            // 
            this.btnEditSubTask.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSubTask.ImageOptions.Image")));
            this.btnEditSubTask.Location = new System.Drawing.Point(774, 67);
            this.btnEditSubTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditSubTask.Name = "btnEditSubTask";
            this.btnEditSubTask.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEditSubTask.Size = new System.Drawing.Size(48, 43);
            this.btnEditSubTask.TabIndex = 26;
            this.btnEditSubTask.Click += new System.EventHandler(this.BtnEditSubTask_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEmp.ImageOptions.Image")));
            this.btnEditEmp.Location = new System.Drawing.Point(580, 65);
            this.btnEditEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEditEmp.Size = new System.Drawing.Size(48, 43);
            this.btnEditEmp.TabIndex = 25;
            this.btnEditEmp.Click += new System.EventHandler(this.BtnEditEmp_Click);
            // 
            // btnEditFile
            // 
            this.btnEditFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditFile.ImageOptions.Image")));
            this.btnEditFile.Location = new System.Drawing.Point(970, 67);
            this.btnEditFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditFile.Name = "btnEditFile";
            this.btnEditFile.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEditFile.Size = new System.Drawing.Size(48, 43);
            this.btnEditFile.TabIndex = 24;
            this.btnEditFile.Click += new System.EventHandler(this.BtnEditFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(45, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // dtpDeadLine
            // 
            this.dtpDeadLine.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dtpDeadLine.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadLine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeadLine.Location = new System.Drawing.Point(183, 169);
            this.dtpDeadLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDeadLine.Name = "dtpDeadLine";
            this.dtpDeadLine.Size = new System.Drawing.Size(231, 28);
            this.dtpDeadLine.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(45, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deadline :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(45, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Priority :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(183, 284);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(231, 29);
            this.cmbCategory.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(45, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category :";
            // 
            // cmbPriority
            // 
            this.cmbPriority.BackColor = System.Drawing.Color.White;
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(183, 228);
            this.cmbPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(231, 29);
            this.cmbPriority.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label6.Location = new System.Drawing.Point(847, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Files";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtName.Location = new System.Drawing.Point(183, 111);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 28);
            this.txtName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label8.Location = new System.Drawing.Point(444, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Employees";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(654, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "SubTasks";
            // 
            // TaskDetailsFrm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 525);
            this.Controls.Add(this.panelContent);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskDetailsFrm";
            this.Text = "TaskDetailsFrm";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsbFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsbEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private DevExpress.XtraEditors.ListBoxControl lsbEmployees;
        private DevExpress.XtraEditors.SimpleButton btnComment;
        private DevExpress.XtraEditors.SimpleButton btnUpdateTask;
        private DevExpress.XtraEditors.SimpleButton btnEditSubTask;
        private DevExpress.XtraEditors.SimpleButton btnEditEmp;
        private DevExpress.XtraEditors.SimpleButton btnEditFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDeadLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clbSubTasks;
        private DevExpress.XtraEditors.ListBoxControl lsbFiles;
    }
}