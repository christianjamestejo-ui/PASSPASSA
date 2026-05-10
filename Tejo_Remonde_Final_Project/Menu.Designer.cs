namespace Student_Registration_form
{
    partial class Menu
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
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 30F);
            button3.Location = new Point(12, 222);
            button3.Name = "button3";
            button3.Size = new Size(67, 65);
            button3.TabIndex = 11;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(85, 235);
            label3.Name = "label3";
            label3.Size = new Size(68, 42);
            label3.TabIndex = 12;
            label3.Text = "Add \nStudent";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 30F);
            button4.Location = new Point(12, 314);
            button4.Name = "button4";
            button4.Size = new Size(67, 62);
            button4.TabIndex = 13;
            button4.Text = "≡";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(85, 325);
            label4.Name = "label4";
            label4.Size = new Size(72, 42);
            label4.TabIndex = 14;
            label4.Text = "Student \nList";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 537);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 10F);
            IsMdiContainer = true;
            Name = "Menu";
            Text = "Insert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label3;
        private Button button4;
        private Label label4;
    }
}