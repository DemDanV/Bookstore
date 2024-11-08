namespace Bookstore
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addToCard_button = new Button();
            dataGridView1 = new DataGridView();
            search_textBox = new TextBox();
            search_button = new Button();
            pictureBox1 = new PictureBox();
            cart_button = new Button();
            authorized_label = new Label();
            sub_button = new Button();
            signIn_button = new Button();
            reg_button = new Button();
            signOut_button = new Button();
            subs_linkLabel = new LinkLabel();
            unsub_button = new Button();
            showAllBooks_linkLabel = new LinkLabel();
            mainPage_linkLabel = new LinkLabel();
            buy_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addToCard_button
            // 
            addToCard_button.Enabled = false;
            addToCard_button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addToCard_button.Location = new Point(617, 345);
            addToCard_button.Name = "addToCard_button";
            addToCard_button.Size = new Size(124, 35);
            addToCard_button.TabIndex = 0;
            addToCard_button.Text = "Add to cart";
            addToCard_button.UseVisualStyleBackColor = true;
            addToCard_button.Click += addToCard_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 84);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(704, 256);
            dataGridView1.TabIndex = 1;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // search_textBox
            // 
            search_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search_textBox.Location = new Point(133, 36);
            search_textBox.Margin = new Padding(3, 2, 3, 2);
            search_textBox.Name = "search_textBox";
            search_textBox.PlaceholderText = "Поиск литературы по названию и автору";
            search_textBox.Size = new Size(520, 29);
            search_textBox.TabIndex = 2;
            search_textBox.KeyUp += search_textBox_KeyUp;
            // 
            // search_button
            // 
            search_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search_button.Location = new Point(650, 36);
            search_button.Margin = new Padding(3, 2, 3, 2);
            search_button.Name = "search_button";
            search_button.Size = new Size(35, 26);
            search_button.TabIndex = 3;
            search_button.Text = "🔎";
            search_button.UseVisualStyleBackColor = true;
            search_button.Click += search_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bookShopBannerShort;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(31, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 70);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // cart_button
            // 
            cart_button.BackgroundImage = Properties.Resources.shoppingCart228;
            cart_button.BackgroundImageLayout = ImageLayout.Stretch;
            cart_button.Enabled = false;
            cart_button.Location = new Point(704, 36);
            cart_button.Margin = new Padding(3, 2, 3, 2);
            cart_button.Name = "cart_button";
            cart_button.Size = new Size(38, 26);
            cart_button.TabIndex = 5;
            cart_button.UseVisualStyleBackColor = true;
            cart_button.Click += cart_button_Click;
            // 
            // authorized_label
            // 
            authorized_label.Anchor = AnchorStyles.Top;
            authorized_label.AutoSize = true;
            authorized_label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            authorized_label.Location = new Point(325, 7);
            authorized_label.Name = "authorized_label";
            authorized_label.RightToLeft = RightToLeft.Yes;
            authorized_label.Size = new Size(115, 19);
            authorized_label.TabIndex = 6;
            authorized_label.Text = "Hello, Your Name";
            authorized_label.TextAlign = ContentAlignment.MiddleRight;
            authorized_label.Visible = false;
            // 
            // sub_button
            // 
            sub_button.Enabled = false;
            sub_button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sub_button.Location = new Point(38, 347);
            sub_button.Margin = new Padding(3, 2, 3, 2);
            sub_button.Name = "sub_button";
            sub_button.Size = new Size(140, 35);
            sub_button.TabIndex = 7;
            sub_button.Text = "Subscribe";
            sub_button.UseVisualStyleBackColor = true;
            sub_button.Click += sub_button_Click;
            // 
            // signIn_button
            // 
            signIn_button.Location = new Point(592, 5);
            signIn_button.Margin = new Padding(3, 2, 3, 2);
            signIn_button.Name = "signIn_button";
            signIn_button.Size = new Size(101, 22);
            signIn_button.TabIndex = 9;
            signIn_button.Text = "Sign In";
            signIn_button.UseVisualStyleBackColor = true;
            signIn_button.Click += signIn_button_Click;
            // 
            // reg_button
            // 
            reg_button.Location = new Point(698, 5);
            reg_button.Margin = new Padding(3, 2, 3, 2);
            reg_button.Name = "reg_button";
            reg_button.Size = new Size(93, 22);
            reg_button.TabIndex = 10;
            reg_button.Text = "Registration";
            reg_button.UseVisualStyleBackColor = true;
            reg_button.Click += reg_button_Click;
            // 
            // signOut_button
            // 
            signOut_button.Location = new Point(707, 5);
            signOut_button.Margin = new Padding(3, 2, 3, 2);
            signOut_button.Name = "signOut_button";
            signOut_button.Size = new Size(82, 22);
            signOut_button.TabIndex = 11;
            signOut_button.Text = "Sigh Out";
            signOut_button.UseVisualStyleBackColor = true;
            signOut_button.Visible = false;
            signOut_button.Click += signOut_button_Click;
            // 
            // subs_linkLabel
            // 
            subs_linkLabel.AutoSize = true;
            subs_linkLabel.Location = new Point(134, 66);
            subs_linkLabel.Name = "subs_linkLabel";
            subs_linkLabel.Size = new Size(98, 15);
            subs_linkLabel.TabIndex = 12;
            subs_linkLabel.TabStop = true;
            subs_linkLabel.Text = "Show subscrubes";
            subs_linkLabel.Visible = false;
            subs_linkLabel.LinkClicked += subs_linkLabel_LinkClicked;
            // 
            // unsub_button
            // 
            unsub_button.Enabled = false;
            unsub_button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            unsub_button.Location = new Point(184, 347);
            unsub_button.Name = "unsub_button";
            unsub_button.Size = new Size(131, 35);
            unsub_button.TabIndex = 13;
            unsub_button.Text = "Unsubscribe";
            unsub_button.UseVisualStyleBackColor = true;
            unsub_button.Click += unsub_button_Click;
            // 
            // showAllBooks_linkLabel
            // 
            showAllBooks_linkLabel.AutoSize = true;
            showAllBooks_linkLabel.Location = new Point(134, 66);
            showAllBooks_linkLabel.Name = "showAllBooks_linkLabel";
            showAllBooks_linkLabel.Size = new Size(86, 15);
            showAllBooks_linkLabel.TabIndex = 14;
            showAllBooks_linkLabel.TabStop = true;
            showAllBooks_linkLabel.Text = "Show all books";
            showAllBooks_linkLabel.Visible = false;
            showAllBooks_linkLabel.LinkClicked += showAllBooks_linkLabel_LinkClicked;
            // 
            // mainPage_linkLabel
            // 
            mainPage_linkLabel.AutoSize = true;
            mainPage_linkLabel.Location = new Point(134, 12);
            mainPage_linkLabel.Name = "mainPage_linkLabel";
            mainPage_linkLabel.Size = new Size(95, 15);
            mainPage_linkLabel.TabIndex = 15;
            mainPage_linkLabel.TabStop = true;
            mainPage_linkLabel.Text = "Go to main Page";
            mainPage_linkLabel.Visible = false;
            mainPage_linkLabel.LinkClicked += mainPage_linkLabel_LinkClicked;
            // 
            // buy_button
            // 
            buy_button.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buy_button.Location = new Point(618, 345);
            buy_button.Name = "buy_button";
            buy_button.Size = new Size(123, 35);
            buy_button.TabIndex = 16;
            buy_button.Text = "Buy";
            buy_button.UseVisualStyleBackColor = true;
            buy_button.Visible = false;
            buy_button.Click += buy_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buy_button);
            Controls.Add(mainPage_linkLabel);
            Controls.Add(showAllBooks_linkLabel);
            Controls.Add(unsub_button);
            Controls.Add(subs_linkLabel);
            Controls.Add(signOut_button);
            Controls.Add(reg_button);
            Controls.Add(signIn_button);
            Controls.Add(sub_button);
            Controls.Add(authorized_label);
            Controls.Add(cart_button);
            Controls.Add(pictureBox1);
            Controls.Add(search_button);
            Controls.Add(search_textBox);
            Controls.Add(dataGridView1);
            Controls.Add(addToCard_button);
            Name = "Form1";
            Text = "Book Shop";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addToCard_button;
        private DataGridView dataGridView1;
        private TextBox search_textBox;
        private Button search_button;
        private PictureBox pictureBox1;
        private Button cart_button;
        private Label authorized_label;
        private Button sub_button;
        private Button signIn_button;
        private Button reg_button;
        private Button signOut_button;
        private LinkLabel subs_linkLabel;
        private Button unsub_button;
        private LinkLabel showAllBooks_linkLabel;
        private LinkLabel mainPage_linkLabel;
        private Button buy_button;
    }
}