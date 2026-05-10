using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Registration_form
{



    public partial class StudentEditInformation : Form
    {
        StudentData student;
        List<StudentData> users;
        string path = "students.json";
        string selectedImagepath = "";


        public StudentEditInformation(StudentData data)
        {
            InitializeComponent();
            student = data;

            selectedImagepath = student.ImagePath;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Clear();
            comboBox2.Items.Add("1st Year");
            comboBox2.Items.Add("2nd Year");
            comboBox2.Items.Add("3rd Year");
            comboBox2.Items.Add("4th Year");

            textBox1.Text = student.Name1;
            textBox2.Text = student.Name2;
            textBox3.Text = student.Name3;

            dateTimePicker1.Text = student.Birthdate;

            int age;
            if (int.TryParse(student.Age, out age))
            {
                numericUpDown1.Value = age;
            }
            comboBox1.Text = student.Gender;
            textBox4.Text = student.Address;
            textBox5.Text = student.Course;

            comboBox2.Text = student.Year;

            LoadImage();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                users = JsonSerializer.Deserialize<List<StudentData>>(json)
                        ?? new List<StudentData>();
            }
            else
            {
                users = new List<StudentData>();
            }

            // 2. Find THIS student in the list
            var existing = users.FirstOrDefault(u => u.Name2 == student.Name2);

            // 3. Update it
            if (existing != null)
            {
                existing.Name1 = textBox1.Text;
                existing.Name2 = textBox2.Text;
                existing.Name3 = textBox3.Text;
                existing.Birthdate = dateTimePicker1.Text;
                existing.Age = numericUpDown1.Text;
                existing.Gender = comboBox1.Text;
                existing.Address = textBox4.Text;
                existing.Course = textBox5.Text;
                existing.Year = comboBox2.Text;
            }
            if (!string.IsNullOrEmpty(selectedImagepath))
            {
                existing.ImagePath = selectedImagepath;
            }
            // 4. Save back to JSON
            string newJson = JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(path, newJson);

            MessageBox.Show("Updated successfully!");

            panel1.Controls.Clear();
            Menu f2 = new Menu();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;

            f2.Dock = DockStyle.Fill;
            panel1.Controls.Add(f2);
            f2.Show();
        }
        private void LoadImage()
        {

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

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                Directory.CreateDirectory(imagesFolder);

                string fileName = Path.GetFileName(dialog.FileName);
                string newPath = Path.Combine(imagesFolder, fileName);

                File.Copy(dialog.FileName, newPath, true);

                selectedImagepath = newPath;

                pictureBox1.Image = Image.FromFile(newPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Menu f2 = new Menu();
            f2.TopLevel = false;
            f2.FormBorderStyle = FormBorderStyle.None;


            f2.Dock = DockStyle.Fill;


            panel1.Controls.Add(f2);
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
