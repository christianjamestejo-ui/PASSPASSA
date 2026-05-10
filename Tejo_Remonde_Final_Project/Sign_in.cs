using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Student_Registration_form
{
    public partial class Sign_in : Form
    {
        public Sign_in()
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
            if (textBox1.Text == "Make your name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Make your name";
                textBox1.ForeColor = Color.Gray;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Make your password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }


        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Make your password";
                textBox2.ForeColor = Color.Gray;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Make your name" )
            {
                MessageBox.Show("It's Invalid for a name press enter");
                return;
            }
           
            
            if (textBox2.Text == "" || textBox2.Text == "Make your password")
            {
                MessageBox.Show("It's Invalid password press enter");
                return;
            }


            string path = "user.json";
            string json;
            List<UserData> users;


            if (File.Exists(path))
            {
                 json = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<UserData>>(json);

            }

            else
            {
                users = new List<UserData>();


            }

               UserData Newuser = new UserData
                {
                    Name = textBox1.Text,
                    Password = textBox2.Text
                };

            users.Add(Newuser);
               json = JsonSerializer.Serialize(users, new JsonSerializerOptions  //JsonSerializerOptions is a class within the System.Text.Json its a namespace that all obejct will become a json string in serialization and in deserialization  it converts the string into a object  
               {

                WriteIndented = true

            });


            File.WriteAllText("user.json", json);

            MessageBox.Show("Saved!");
            
            panel1.Controls.Clear();
            Menu f2 = new Menu();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            panel1.Controls.Add(f2);
            f2.Show();


        }
    }
}
