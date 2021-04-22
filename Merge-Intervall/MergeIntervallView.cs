using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merge_Intervall
{
    public partial class MergeIntervallView : Form
    {
        public MergeIntervallView()
        {
            InitializeComponent();
        }

        private void OpenNRun_Click(object sender, EventArgs e)
        {
            pathBox.Text = GetFile();
            Application.DoEvents();
        }

        private string GetFile()
        {
            fileDialog.Filter = "Text|*txt";
            fileDialog.FilterIndex = 1;

            fileDialog.ShowDialog();

            return fileDialog.FileName;
        }
    }
}
