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
    public partial class EditFilesFrm : DevExpress.XtraEditors.XtraForm
    {
        private List<string> files;
        public EditFilesFrm(List<string> files)
        {
            InitializeComponent();
            this.files = files;
            LoadFiles();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "PDF |*.pdf|doc|*.doc;*.docx|Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //TBfilePath.Text = fileDialog.FileName;
                files.Add(fileDialog.FileName);
                clbFilesList.Items.Add(fileDialog.FileName);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            foreach (var item in clbFilesList.CheckedItems)
            {
                files.Remove(item.ToString());
            }
            LoadFiles();
        }
        private void LoadFiles()
        {

            clbFilesList.Items.Clear();
            foreach (var item in files)
            {
                clbFilesList.Items.Add(item);
            }
        }
    }
}
