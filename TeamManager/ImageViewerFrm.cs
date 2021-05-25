using DevExpress.XtraEditors;
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
    public partial class ImageViewerFrm : DevExpress.XtraEditors.XtraForm
    {
        public ImageViewerFrm(string path)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pictureEdit1.Image = Image.FromFile(path);
        }
    }
}