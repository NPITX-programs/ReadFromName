using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFromName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string folder = @"H:\Students_Folder\Charlie Hatch\Semesters\Multi-Semester\App Dev\Projects\App Dev 2\ReadFromName\";
        string fileName = "file";
        string fileExtension = ".txt";
        private void btn_readAllText_Click(object sender, EventArgs e)
        {
            File.ReadAllText(folder+fileName+fileExtension);
        }

        private void btn_readAllLine_Click(object sender, EventArgs e)
        {

        }
    }
}
