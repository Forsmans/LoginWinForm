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
            signInButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            signInButton.BackColor = Color.FromArgb(255, 255, 192);
            signInButton.Location = new Point(170, 390);
            signInButton.Margin = new Padding(2);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(260, 45);
            signInButton.TabIndex = 21;
            signInButton.Text = "Aldready have an account? Sign in";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            signUpButton.BackColor = Color.FromArgb(192, 255, 192);
            signUpButton.Location = new Point(170, 329);
            signUpButton.Margin = new Padding(2);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(260, 45);
            signUpButton.TabIndex = 20;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Rubik", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(223, 25);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 44);
            label5.TabIndex = 19;
            label5.Text = "Sign Up";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(265, 263);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 18;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.Location = new Point(130, 280);
            passwordBox.Margin = new Padding(2);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(327, 23);
            passwordBox.TabIndex = 17;
            passwordBox.TextAlign = HorizontalAlignment.Center;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(265, 211);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 16;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // usernameBox
            // 
            usernameBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usernameBox.Location = new Point(130, 228);
            usernameBox.Margin = new Padding(2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(327, 23);
            usernameBox.TabIndex = 15;
            usernameBox.TextAlign = HorizontalAlignment.Center;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(262, 152);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 14;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // lastNameBox
            // 
            lastNameBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lastNameBox.Location = new Point(130, 169);
            lastNameBox.Margin = new Padding(2);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(327, 23);
            lastNameBox.TabIndex = 13;
            lastNameBox.TextAlign = HorizontalAlignment.Center;
            lastNameBox.TextChanged += lastNameBox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(262, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 12;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // firstNameBox
            // 
            firstNameBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            firstNameBox.Location = new Point(130, 112);
            firstNameBox.Margin = new Padding(2);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(327, 23);
            firstNameBox.TabIndex = 11;
            firstNameBox.TextAlign = HorizontalAlignment.Center;
            firstNameBox.TextChanged += firstNameBox_TextChanged;
            // 
            // SignUpForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(584, 461);
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
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(2);
            Name = "SignUpForms";
            StartPosition = FormStartPosition.CenterScreen;
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