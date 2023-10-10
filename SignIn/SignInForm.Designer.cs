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
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(168, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 84);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(131, 84);
            usernameBox.Margin = new Padding(2);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(222, 23);
            usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(131, 130);
            passwordBox.Margin = new Padding(2);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(222, 23);
            passwordBox.TabIndex = 4;
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.FromArgb(192, 255, 192);
            logInButton.Location = new Point(54, 181);
            logInButton.Margin = new Padding(2);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(137, 57);
            logInButton.TabIndex = 5;
            logInButton.Text = "Sign in";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(255, 255, 192);
            registerButton.Location = new Point(244, 181);
            registerButton.Margin = new Padding(2);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(137, 57);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register new account";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 271);
            Controls.Add(registerButton);
            Controls.Add(logInButton);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "SignInForm";
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