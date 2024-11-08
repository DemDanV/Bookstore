namespace Bookstore
{
    partial class LogInPage
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
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            login_button = new Button();
            password_textBox = new TextBox();
            login_textBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            banner = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(370, 206);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 15);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registration";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 206);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 23;
            label5.Text = "Don't have an account yet?";
            // 
            // login_button
            // 
            login_button.Location = new Point(240, 170);
            login_button.Margin = new Padding(3, 2, 3, 2);
            login_button.Name = "login_button";
            login_button.Size = new Size(180, 34);
            login_button.TabIndex = 22;
            login_button.Text = "Subscribe";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_textBox.Location = new Point(256, 122);
            password_textBox.Margin = new Padding(3, 2, 3, 2);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(238, 29);
            password_textBox.TabIndex = 20;
            // 
            // login_textBox
            // 
            login_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            login_textBox.Location = new Point(256, 86);
            login_textBox.Margin = new Padding(3, 2, 3, 2);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(238, 29);
            login_textBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(166, 126);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 16;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(136, 88);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 14;
            label2.Text = "E-mail/Name:";
            // 
            // banner
            // 
            banner.AutoSize = true;
            banner.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            banner.Location = new Point(256, 21);
            banner.Name = "banner";
            banner.Size = new Size(101, 41);
            banner.TabIndex = 13;
            banner.Text = "Log In";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(login_button);
            Controls.Add(password_textBox);
            Controls.Add(login_textBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(banner);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label5;
        private Button login_button;
        private TextBox password_textBox;
        private TextBox login_textBox;
        private Label label3;
        private Label label2;
        private Label banner;
    }
}