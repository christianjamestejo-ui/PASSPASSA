namespace Student_Registration_form
{
    partial class Sign_in
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 449);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(413, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 25);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(262, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 10;
            textBox2.Text = "Make your password";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(261, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "Make your name";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // button2
            // 
            button2.Location = new Point(266, 181);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 7;
            button2.Text = "Sign in ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(309, 18);
            label6.Name = "label6";
            label6.Size = new Size(133, 45);
            label6.TabIndex = 6;
            label6.Text = "Sign In ";
            // 
            // Sign_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Sign_in";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}