using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShowRTF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            try
            {
                if (txtInput.Text.Trim() != "") txtOutput.Rtf = txtInput.Text.Trim();

                Clipboard.Clear();
                Clipboard.SetData(DataFormats.Rtf, txtInput.Text.Trim());
                txtOutput.Text = Clipboard.GetData(DataFormats.Html).ToString();
            }
            catch { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";

        }

        private void txtInput_DoubleClick(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }
    }
}
