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
using StudentMS_BO;
using StudentMS_DAL;
namespace StudentManagement.AdminForms
{
    public partial class AddTeachers : Form
    {

        public AddTeachers()
        {
            InitializeComponent();
        }
        MemoryStream stream = new MemoryStream();
        

        private void lblIntro_Click(object sender, EventArgs e)
        {

        }

        private void btnTchImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openD = new OpenFileDialog();
            if (openD.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openD.FileName);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                pbTchImg.Image = Image.FromFile(openD.FileName);//shtojme foton te pic box
                
            }
        }

        private void btnSaveTch_Click(object sender, EventArgs e)
        {
            TeacherBO tchBO = new TeacherBO(txtEmri.Text, txtMbiemri.Text, txtEmail.Text, txtNrTel.Text,txtOrePune.Text);
        }
    }
}
