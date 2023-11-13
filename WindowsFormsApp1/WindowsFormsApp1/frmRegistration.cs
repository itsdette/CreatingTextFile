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

namespace WindowsFormsApp1
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfPrograms = new string[]
           {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information System",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
           };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfPrograms[i].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string [] details =
            {
                $"Student Number: {txtboxStudNo.Text}",
                $"Full Name: {txtboxLast.Text}, {txtboxFirst.Text} {txtboxMI.Text}",
                $"Program: {cbPrograms.Text}",
                $"Gender: {cbGender.Text}",
                $"Age: {txtboxAge.Text}",
                $"Birthday: {dateTimePickerBirthday.Value.ToString("yyyy-MM-dd")}",
                $"Contact Number: {txtboxContact.Text}"
            };

            using (StreamWriter writer = new StreamWriter($"{docPath}\\{txtboxStudNo.Text}.txt"))
            {
                foreach(var item in details)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
