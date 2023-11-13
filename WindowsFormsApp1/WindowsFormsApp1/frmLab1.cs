using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class frmLab1 : Form
    {
        public frmLab1()
        {
            InitializeComponent();
        }
        private void btnCrate_Click(object sender, EventArgs e)
        {
            frmFileName fileName = new frmFileName();
            fileName.ShowDialog();

            string getInput = txtInput.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine(docPath);
            using (StreamWriter outputFile  = new StreamWriter(Path.Combine(docPath, frmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }
    }
}
