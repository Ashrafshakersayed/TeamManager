
namespace TeamManager
{
    partial class CreateNewTeamFrm
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
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkedListBoxAllEmployees = new System.Windows.Forms.CheckedListBox();
            this.CheckListTitle = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.addNewEmployeeButton = new System.Windows.Forms.Button();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SuspendLayout();
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamName.ForeColor = System.Drawing.Color.Black;
            this.labelTeamName.Location = new System.Drawing.Point(31, 113);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(78, 29);
            this.labelTeamName.TabIndex = 0;
            this.labelTeamName.Text = "Name";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(14, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(262, 46);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Create Team";
            // 
            // checkedListBoxAllEmployees
            // 
            this.checkedListBoxAllEmployees.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checkedListBoxAllEmployees.CheckOnClick = true;
            this.checkedListBoxAllEmployees.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxAllEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.checkedListBoxAllEmployees.FormattingEnabled = true;
            this.checkedListBoxAllEmployees.Location = new System.Drawing.Point(387, 82);
            this.checkedListBoxAllEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxAllEmployees.Name = "checkedListBoxAllEmployees";
            this.checkedListBoxAllEmployees.Size = new System.Drawing.Size(214, 280);
            this.checkedListBoxAllEmployees.TabIndex = 2;
            // 
            // CheckListTitle
            // 
            this.CheckListTitle.AutoSize = true;
            this.CheckListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckListTitle.ForeColor = System.Drawing.Color.Black;
            this.CheckListTitle.Location = new System.Drawing.Point(382, 44);
            this.CheckListTitle.Name = "CheckListTitle";
            this.CheckListTitle.Size = new System.Drawing.Size(235, 25);
            this.CheckListTitle.TabIndex = 3;
            this.CheckListTitle.Text = "Choose Team Members :";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxTeamName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.textBoxTeamName.Location = new System.Drawing.Point(115, 117);
            this.textBoxTeamName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(228, 28);
            this.textBoxTeamName.TabIndex = 4;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCreateTeam.Location = new System.Drawing.Point(387, 380);
            this.btnCreateTeam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(214, 39);
            this.btnCreateTeam.TabIndex = 10;
            this.btnCreateTeam.Text = "Create";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.BtnCreateTeam_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCancel.Location = new System.Drawing.Point(22, 385);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // addNewEmployeeButton
            // 
            this.addNewEmployeeButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.addNewEmployeeButton.Location = new System.Drawing.Point(80, 226);
            this.addNewEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addNewEmployeeButton.Name = "addNewEmployeeButton";
            this.addNewEmployeeButton.Size = new System.Drawing.Size(212, 47);
            this.addNewEmployeeButton.TabIndex = 16;
            this.addNewEmployeeButton.Text = "Add New Employee";
            this.addNewEmployeeButton.UseVisualStyleBackColor = true;
            this.addNewEmployeeButton.Click += new System.EventHandler(this.addNewEmployeeButton_Click);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // CreateNewTeamFrm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 437);
            this.Controls.Add(this.addNewEmployeeButton);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.CheckListTitle);
            this.Controls.Add(this.checkedListBoxAllEmployees);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTeamName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNewTeamFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckedListBox checkedListBoxAllEmployees;
        private System.Windows.Forms.Label CheckListTitle;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button addNewEmployeeButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    }
}