using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Student_Registration_form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
    private void button1_Click(object sender, EventArgs e)
       
         
        {
            panel1.Controls.Clear();
            Form1 f1 = new Form1();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            
            panel1.Controls.Add(f1);
            f1.Show();
        }

        


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Enter your name")
            {
                textBox4.Text = ""; // making the name dissapear 
                textBox4.ForeColor = Color.Black; // making the cursor into Black
            }
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Enter your name"; // Making the appear 
                textBox4.ForeColor = Color.Gray; // making the color gray
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter your Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Enter your Password";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "user.json"); // pin pointing the location in the file  

            try
            {
                
                string json = File.ReadAllText(path); // this read all the text in the file  

                
                List<UserData> users = JsonSerializer.Deserialize<List<UserData>>(json); // Collecting the data from json file and store in it the list in which this list will go to users

                
                if (users != null && users.Count == 0) // the count is counting the storage data in your JSON file and if not found 
                {
                    MessageBox.Show("No users found!");
                    return; // this go back to the application 
                }

                string inputName = textBox4.Text; // Converting it into another variable 
                string inputPassword = textBox3.Text; // Converting it into another variable 

                bool invalid = false;

                foreach (var user in users) // this make user to be part of Users 
                {
                    if (user.Name == inputName && user.Password == inputPassword) 
                    {
                        invalid = true;
                        break;
                    }
                }

                if (invalid)
                {
                    MessageBox.Show("Login succrssfully");
                    
                    panel1.Controls.Clear();
                    Menu f2 = new Menu();
                    f2.TopLevel = false;
                    f2.FormBorderStyle = FormBorderStyle.None;
                    f2.Dock = DockStyle.Fill;
                   
                    panel1.Controls.Add(f2);
                    f2.Show();
                }

                else
                {
                    MessageBox.Show("Invalid name or password!"); 
                }
            }
         
            
            catch (Exception ex) // It catch the whole error like null or empty space or skip inputs 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
            
           




        }









    }



}

