namespace SignIn
{
    partial class SignInForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            logInButton = new Button();
            registerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(226, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 44);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(261, 115);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(261, 197);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // usernameBox
            // 
            usernameBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usernameBox.Location = new Point(121, 142);
            usernameBox.Margin = new Padding(2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(345, 23);
            usernameBox.TabIndex = 3;
            usernameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.Location = new Point(121, 225);
            passwordBox.Margin = new Padding(2);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(345, 23);
            passwordBox.TabIndex = 4;
            passwordBox.TextAlign = HorizontalAlignment.Center;
            // 
            // logInButton
            // 
            logInButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logInButton.BackColor = Color.FromArgb(192, 255, 192);
            logInButton.Location = new Point(159, 289);
            logInButton.Margin = new Padding(2);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(260, 57);
            logInButton.TabIndex = 5;
            logInButton.Text = "Sign in";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registerButton.BackColor = Color.FromArgb(255, 255, 192);
            registerButton.Location = new Point(159, 373);
            registerButton.Margin = new Padding(2);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(260, 57);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register new account";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(584, 461);
            Controls.Add(registerButton);
            Controls.Add(logInButton);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Button logInButton;
        private Button registerButton;
    }
}