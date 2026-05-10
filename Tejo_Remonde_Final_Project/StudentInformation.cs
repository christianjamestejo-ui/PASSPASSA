using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Registration_form
{
    public partial class StudentInformation : Form
    {
        StudentData student;

        public StudentInformation(StudentData data)
        {
            InitializeComponent();
            student = data;

            label1.Text = student.Name1 + " " + student.Name2 + " " + student.Name3;
            label2.Text = student.Birthdate;
            label3.Text = student.Age;
            label4.Text = student.Gender;
            label5.Text = student.Address;
            label6.Text = student.Course;
            label7.Text = student.Year;

            LoadImage();

        }


        private void LoadImage()
        {
            MessageBox.Show(student.ImagePath);
            MessageBox.Show(File.Exists(student.ImagePath).ToString());
            if (!string.IsNullOrEmpty(student.ImagePath) && File.Exists(student.ImagePath))
            {
                pictureBox1.Image = Image.FromFile(student.ImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StudentList f4 = new StudentList();
            f4.TopLevel = false;   // <---- this is exit
            f4.FormBorderStyle = FormBorderStyle.None;
            f4.Dock = DockStyle.Fill;
            panel1.Controls.Add(f4);
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            StudentEditInformation f6 = new StudentEditInformation(student); // <---- this is edit
            
            f6.TopLevel = false;
            f6.FormBorderStyle = FormBorderStyle.None;
            f6.Dock = DockStyle.Fill;
            panel1.Controls.Add(f6);
            f6.Show();
        }
    }
}