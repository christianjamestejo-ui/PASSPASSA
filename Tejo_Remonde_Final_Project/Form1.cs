namespace Student_Registration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)


        {
            panel1.SuspendLayout();


            panel1.Controls.Clear(); // the panels is like using to gather all up the tools from the tool box  
                                     // And then the controls is like using it to command  the variable name or command it to "Clear" the entire thing 
            Login l1 = new Login(); // Converting Login to another variable = New Login 

            l1.TopLevel = false; // it add the Login.cs and be part of  

            l1.FormBorderStyle = FormBorderStyle.None; // the FormBorderStyle.None it means that to remove the the form format like to prevent the ui to be inside in Ui
            l1.Dock = DockStyle.Fill;
            //   l1.Dock = DockStyle.Fill; // It automatically fill the panel in form 2 in the whole area of it ui 

            panel1.Controls.Add(l1); //to add another tool from Login.cs like buttons labels etc to form 1

            l1.Show(); // then it show the content of Login.cs 
            panel1.ResumeLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel1.SuspendLayout();

            panel1.Controls.Clear();
            Sign_in s1 = new Sign_in();

            s1.TopLevel = false;

            s1.FormBorderStyle = FormBorderStyle.None;

            s1.Dock = DockStyle.Fill;

            panel1.Controls.Add(s1);

            s1.Show();

            panel1.ResumeLayout();


        }


    }
}
