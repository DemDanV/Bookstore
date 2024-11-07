namespace Bookstore
{
    partial class Reg
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
            components = new System.ComponentModel.Container();
            banner = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            email_textBox = new TextBox();
            name_textBox = new TextBox();
            password_textBox = new TextBox();
            repPassword_textBox = new TextBox();
            reg_button = new Button();
            errorProvider1 = new ErrorProvider(components);
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // banner
            // 
            banner.AutoSize = true;
            banner.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            banner.Location = new Point(238, 7);
            banner.Name = "banner";
            banner.Size = new Size(166, 41);
            banner.TabIndex = 0;
            banner.Text = "Registation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 76);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 1;
            label2.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(173, 106);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(148, 136);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 166);
            label4.Name = "label4";
            label4.Size = new Size(158, 21);
            label4.TabIndex = 4;
            label4.Text = "Repeat the password:";
            // 
            // email_textBox
            // 
            email_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email_textBox.Location = new Point(238, 72);
            email_textBox.Margin = new Padding(3, 2, 3, 2);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(238, 29);
            email_textBox.TabIndex = 5;
            email_textBox.Validated += email_textBox_Validated;
            // 
            // name_textBox
            // 
            name_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name_textBox.Location = new Point(238, 102);
            name_textBox.Margin = new Padding(3, 2, 3, 2);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new Size(238, 29);
            name_textBox.TabIndex = 6;
            name_textBox.Validated += name_textBox_Validated;
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_textBox.Location = new Point(238, 132);
            password_textBox.Margin = new Padding(3, 2, 3, 2);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(238, 29);
            password_textBox.TabIndex = 7;
            password_textBox.Validated += password_textBox_Validated;
            // 
            // repPassword_textBox
            // 
            repPassword_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            repPassword_textBox.Location = new Point(238, 162);
            repPassword_textBox.Margin = new Padding(3, 2, 3, 2);
            repPassword_textBox.Name = "repPassword_textBox";
            repPassword_textBox.Size = new Size(238, 29);
            repPassword_textBox.TabIndex = 8;
            repPassword_textBox.Validated += repPassword_textBox_Validated;
            // 
            // reg_button
            // 
            reg_button.Location = new Point(238, 217);
            reg_button.Margin = new Padding(3, 2, 3, 2);
            reg_button.Name = "reg_button";
            reg_button.Size = new Size(180, 34);
            reg_button.TabIndex = 9;
            reg_button.Text = "Subscribe";
            reg_button.UseVisualStyleBackColor = true;
            reg_button.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 254);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 11;
            label5.Text = "Already have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(368, 254);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(43, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(reg_button);
            Controls.Add(repPassword_textBox);
            Controls.Add(password_textBox);
            Controls.Add(name_textBox);
            Controls.Add(email_textBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(banner);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reg";
            Text = "Reg";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label banner;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox email_textBox;
        private TextBox name_textBox;
        private TextBox password_textBox;
        private TextBox repPassword_textBox;
        private Button reg_button;
        private ErrorProvider errorProvider1;
        private LinkLabel linkLabel1;
        private Label label5;
    }
}