namespace Student_Registration_form
{
    partial class Login
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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 449);
            panel1.TabIndex = 8;
            panel1.Enter += textBox1_Enter;
            panel1.Leave += textBox1_Leave;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.Gray;
            textBox3.Location = new Point(227, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 23);
            textBox3.TabIndex = 13;
            textBox3.Text = "Enter your Password";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.Gray;
            textBox4.Location = new Point(227, 64);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 23);
            textBox4.TabIndex = 11;
            textBox4.Text = "Enter your name";
            textBox4.Enter += textBox1_Enter;
            textBox4.Leave += textBox1_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(290, 7);
            label4.Name = "label4";
            label4.Size = new Size(113, 45);
            label4.TabIndex = 9;
            label4.Text = "Login ";
            // 
            // button1
            // 
            button1.Location = new Point(388, 187);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(232, 186);
            button3.Name = "button3";
            button3.Size = new Size(75, 26);
            button3.TabIndex = 7;
            button3.Text = "Login ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}