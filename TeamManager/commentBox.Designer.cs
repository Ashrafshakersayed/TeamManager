
namespace TeamManager
{
    partial class commentBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControlBorder = new DevExpress.XtraEditors.PanelControl();
            this.commentTextLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBorder)).BeginInit();
            this.panelControlBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControlBorder
            // 
            this.panelControlBorder.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControlBorder.Appearance.Options.UseBackColor = true;
            this.panelControlBorder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControlBorder.Controls.Add(this.commentTextLabel);
            this.panelControlBorder.Location = new System.Drawing.Point(285, 23);
            this.panelControlBorder.Name = "panelControlBorder";
            this.panelControlBorder.Size = new System.Drawing.Size(318, 80);
            this.panelControlBorder.TabIndex = 4;
            // 
            // commentTextLabel
            // 
            this.commentTextLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.commentTextLabel.Appearance.Options.UseFont = true;
            this.commentTextLabel.Location = new System.Drawing.Point(73, 21);
            this.commentTextLabel.Name = "commentTextLabel";
            this.commentTextLabel.Size = new System.Drawing.Size(106, 30);
            this.commentTextLabel.TabIndex = 1;
            this.commentTextLabel.Text = "Comment";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(50, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(145, 24);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Employee Name";
            // 
            // commentBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControlBorder);
            this.Controls.Add(this.labelControl1);
            this.Name = "commentBox";
            this.Size = new System.Drawing.Size(642, 128);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBorder)).EndInit();
            this.panelControlBorder.ResumeLayout(false);
            this.panelControlBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlBorder;
        private DevExpress.XtraEditors.LabelControl commentTextLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
