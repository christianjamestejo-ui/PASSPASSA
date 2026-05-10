using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Student_Registration_form
{
    public partial class Menu : Form
    {
        public Menu()
        {

            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            StudentRegistration f3 = new StudentRegistration();
            f3.TopLevel = false;
            f3.FormBorderStyle = FormBorderStyle.None;
            f3.Dock = DockStyle.Fill;

            this.AutoScaleMode = AutoScaleMode.None;
            //panel1.Controls.Add(f3);
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            StudentList f3 = new StudentList();
            f3.TopLevel = false;
            f3.FormBorderStyle = FormBorderStyle.None;

          
            f3.Dock = DockStyle.Fill;
            //panel1.Controls.Add(f3);
            f3.Show();
        }
    }
}
