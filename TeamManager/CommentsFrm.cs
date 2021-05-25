using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamManager
{
    public partial class CommentsFrm : DevExpress.XtraEditors.XtraForm
    {
        Form prevForm;
        Task task;
        public CommentsFrm(Form prevForm, Task task)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.task = task;

            drawComments();
        }

        private void drawComments()
        {
            XSCcommentsContainer.Controls.Clear();
            int commentsCount = 0;
            commentBox comment = new commentBox("");
            foreach (string commentText in task.Comments)
            {
                comment = new commentBox(commentText);
                comment.Top = commentsCount * comment.Height;
                XSCcommentsContainer.Controls.Add(comment);

                commentsCount++;
            }

            //scroll to last comment
            XSCcommentsContainer.ScrollControlIntoView(comment);

        }

        private void BTNsend_Click(object sender, EventArgs e)
        {
            task.Comments.Add(richTextBoxComment.Text);
            drawComments();
            richTextBoxComment.Text = string.Empty;
        }

        private void BTNback_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            Close();
        }

        private void richTextBoxComment_TextChanged(object sender, EventArgs e)
        {
            BTNsend.Enabled = !(richTextBoxComment.Text.Trim() == string.Empty);
        }
    }
}
