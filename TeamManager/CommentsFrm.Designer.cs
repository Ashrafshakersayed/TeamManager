
namespace TeamManager
{
    partial class CommentsFrm
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
            this.BTNback = new DevExpress.XtraEditors.SimpleButton();
            this.BTNsend = new DevExpress.XtraEditors.SimpleButton();
            this.XSCcommentsContainer = new DevExpress.XtraEditors.XtraScrollableControl();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BTNback
            // 
            this.BTNback.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNback.Appearance.Options.UseFont = true;
            this.BTNback.Location = new System.Drawing.Point(12, 418);
            this.BTNback.Name = "BTNback";
            this.BTNback.Size = new System.Drawing.Size(106, 29);
            this.BTNback.TabIndex = 7;
            this.BTNback.Text = "Back";
            this.BTNback.Click += new System.EventHandler(this.BTNback_Click);
            // 
            // BTNsend
            // 
            this.BTNsend.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsend.Appearance.Options.UseFont = true;
            this.BTNsend.Enabled = false;
            this.BTNsend.Location = new System.Drawing.Point(575, 418);
            this.BTNsend.Name = "BTNsend";
            this.BTNsend.Size = new System.Drawing.Size(113, 36);
            this.BTNsend.TabIndex = 6;
            this.BTNsend.Text = "send";
            this.BTNsend.Click += new System.EventHandler(this.BTNsend_Click);
            // 
            // XSCcommentsContainer
            // 
            this.XSCcommentsContainer.Appearance.BackColor = System.Drawing.Color.White;
            this.XSCcommentsContainer.Appearance.Options.UseBackColor = true;
            this.XSCcommentsContainer.Location = new System.Drawing.Point(12, 12);
            this.XSCcommentsContainer.Name = "XSCcommentsContainer";
            this.XSCcommentsContainer.Size = new System.Drawing.Size(676, 368);
            this.XSCcommentsContainer.TabIndex = 5;
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Font = new System.Drawing.Font("Tahoma", 12F);
            this.richTextBoxComment.Location = new System.Drawing.Point(135, 404);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(434, 58);
            this.richTextBoxComment.TabIndex = 4;
            this.richTextBoxComment.Text = "";
            this.richTextBoxComment.TextChanged += new System.EventHandler(this.richTextBoxComment_TextChanged);
            // 
            // CommentsFrm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.BTNback);
            this.Controls.Add(this.BTNsend);
            this.Controls.Add(this.XSCcommentsContainer);
            this.Controls.Add(this.richTextBoxComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CommentsFrm";
            this.Text = "CommentsFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BTNback;
        private DevExpress.XtraEditors.SimpleButton BTNsend;
        private DevExpress.XtraEditors.XtraScrollableControl XSCcommentsContainer;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
    }
}