using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatSheetHandler
{
    public partial class Form1 : Form
    {
        string xlsPath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                InitialDirectory = "D://",
                Filter = "Excel File(97-2003) (*.xls)|*.xls",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (fileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(fileDialog.FileName))
            {
                textBox1.Text = fileDialog.FileName;
                xlsPath = fileDialog.FileName;
            }
        }
    }
}
