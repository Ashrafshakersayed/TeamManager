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
    public partial class WordViewerFrm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public WordViewerFrm(string path)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            richEditControl1.LoadDocument(path);
        }
    }
}