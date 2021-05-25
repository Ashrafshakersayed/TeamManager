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
    public partial class commentBox : UserControl
    {
        public commentBox(string MSG)
        {
            InitializeComponent();
            commentTextLabel.Text = MSG;
            // panelControlBorder.Width = commentTextLabel.Width + 20;
            commentTextLabel.Left = panelControlBorder.Width / 2 - commentTextLabel.Width / 2;
        }
    }
}
