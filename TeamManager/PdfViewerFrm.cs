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
    public partial class PdfViewerFrm : DevExpress.XtraEditors.XtraForm
    {
        public PdfViewerFrm(string path)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            pdfViewer1.LoadDocument(path);
        }
    }
}