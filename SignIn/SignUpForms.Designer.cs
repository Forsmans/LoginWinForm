namespace SignIn
{
    partial class SignUpForms
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
            signInButton = new Button();
            signUpButton = new Button();
            label5 = new Label();
            label4 = new Label();
            passwordBox = new TextBox();
            label3 = new Label();
            usernameBox = new TextBox();
            label2 = new Label();
            lastNameBox = new TextBox();
            label1 = new Label();
            firstNameBox = new TextBox();
            SuspendLayout();
            // 
            // signInButton
            // 
            signInButton.BackColor = Color.FromArgb(255, 255, 192);
            signInButton.Location = new Point(293, 341);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(228, 75);
            signInButton.TabIndex = 21;
            signInButton.Text = "Aldready have an account? Sign in";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FromArgb(192, 255, 192);
            signUpButton.Location = new Point(40, 341);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(228, 75);
            signUpButton.TabIndex = 20;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(213, 31);
            label5.Name = "label5";
            label5.Size = new Size(158, 48);
            label5.TabIndex = 19;
            label5.Text = "Sign Up";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 262);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 18;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(111, 262);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(410, 31);
            passwordBox.TabIndex = 17;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 209);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 16;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(111, 209);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(410, 31);
            usernameBox.TabIndex = 15;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 153);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 14;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(111, 153);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(410, 31);
            lastNameBox.TabIndex = 13;
            lastNameBox.TextChanged += lastNameBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 97);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 12;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(111, 97);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(410, 31);
            firstNameBox.TabIndex = 11;
            firstNameBox.TextChanged += firstNameBox_TextChanged;
            // 
            // SignUpForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 466);
            Controls.Add(signInButton);
            Controls.Add(signUpButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(passwordBox);
            Controls.Add(label3);
            Controls.Add(usernameBox);
            Controls.Add(label2);
            Controls.Add(lastNameBox);
            Controls.Add(label1);
            Controls.Add(firstNameBox);
            Name = "SignUpForms";
            Text = "SignUpForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signInButton;
        private Button signUpButton;
        private Label label5;
        private Label label4;
        private TextBox passwordBox;
        private Label label3;
        private TextBox usernameBox;
        private Label label2;
        private TextBox lastNameBox;
        private Label label1;
        private TextBox firstNameBox;
    }
}