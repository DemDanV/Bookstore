using System.Data;
using System.Data.OleDb;

namespace Bookstore
{
    public partial class RegPage : Form
    {
        bool[] validated;
        public RegPage()
        {
            InitializeComponent();
            this.FormClosed += RegPage_FormClosed;

            reg_button.Validating += email_textBox_Validating;
            reg_button.Validating += name_textBox_Validating;
            reg_button.Validating += password_textBox_Validating;
            reg_button.Validating += repPassword_textBox_Validating;

            validated = new bool[4];
        }

        private void RegPage_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.FormClosed -= RegPage_FormClosed;

            Program.ShowForm<MainPage>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validate();
            bool valid = validated[0] && validated[1] && validated[2] && validated[3];
            if (valid == false)
                return;

            string name = name_textBox.Text;
            string query = "INSERT INTO [clientsAcc_table] ([Name], [Email], [Password]) VALUES ('" + name + "', '" + email_textBox.Text + "', '" + password_textBox.Text + "')";
            using (OleDbConnection DBConnection = new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;
                        Data Source=" + Environment.CurrentDirectory + "\\Books.accdb"
                    ))
            {
                OleDbCommand sqlcmd = new OleDbCommand(query, DBConnection);

                DBConnection.Open();

                if (sqlcmd.ExecuteNonQuery() == 1)
                {
                    query = "SELECT * FROM clientsAcc_table where Name = '" + name + "'";
                    sqlcmd = new OleDbCommand(query, DBConnection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(sqlcmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    string g = table.Rows[0][0].ToString();

                    AccountInfo.SignIn(int.Parse(table.Rows[0][0].ToString()), table.Rows[0][1].ToString());
                    Close();
                }
                else
                {
                    MessageBox.Show("Error. You are not registered");
                }
                DBConnection.Close();
            }
        }


        //Email
        private void email_textBox_Validating(object sender,
                System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(email_textBox.Text, out errorMsg))
            {
                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(email_textBox, errorMsg);
                validated[0] = false;
            }
        }

        private void email_textBox_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(email_textBox, "");
            validated[0] = true;
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "email address is required";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") == -1)
            {
                errorMessage = "email address must be valid email address format.\n" +
                                "For example 'someone@example.com' ";
                return false;
            }
            else if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) < emailAddress.IndexOf("@"))
            {
                errorMessage = "email address must be valid email address format.\n" +
                                "For example 'someone@example.com' ";
                return false;
            }

            bool Valid = CheckDBValue(emailAddress, "Email");
            if (Valid == false)
            {
                errorMessage = "e-mail is alredy taken";
                return false;
            }

            errorMessage = "";
            return true;
        }


        //Name
        private void name_textBox_Validating(object sender,
        System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidName(name_textBox.Text, out errorMsg))
            {
                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(name_textBox, errorMsg);
                validated[1] = false;
            }
        }

        private void name_textBox_Validated(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(name_textBox, "");
            validated[1] = true;
        }

        public bool ValidName(string name, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "name is required";
                return false;
            }

            bool Valid = CheckDBValue(name, "Name");
            if (Valid == false)
            {
                errorMessage = "name is alredy taken";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private static bool CheckDBValue(string name, string field)
        {
            string query = $"SELECT * FROM clientsAcc_table where {field} = '{name}'";
            bool Rezerve;
            using (OleDbConnection DBConnection = new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source=" + Environment.CurrentDirectory + "\\Books.accdb"
                    ))
            {
                using (OleDbCommand sqlcmd = new OleDbCommand(query, DBConnection))
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(sqlcmd);

                    DataTable table = new DataTable();
                    da.Fill(table);
                    Rezerve = table.Rows.Count > 0;
                }
            }

            return !Rezerve;
        }


        //Password
        private void password_textBox_Validating(object sender,
System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidPassword(password_textBox.Text, out errorMsg))
            {
                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(password_textBox, errorMsg);
                validated[2] = false;
            }
        }

        private void password_textBox_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(password_textBox, "");
            validated[2] = true;
        }

        public bool ValidPassword(string pass, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (string.IsNullOrWhiteSpace(pass))
            {
                errorMessage = "password is required";
                return false;
            }

            if (pass.Length < 6)
            {
                errorMessage = "password can't be so short";
                return false;
            }

            errorMessage = "";
            return true;
        }


        //RepPassword
        private void repPassword_textBox_Validating(object sender,
System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidRepPassword(repPassword_textBox.Text, out errorMsg))
            {
                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(repPassword_textBox, errorMsg);
                validated[3] = false;
            }
        }

        private void repPassword_textBox_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(repPassword_textBox, "");
            validated[3] = true;
        }

        public bool ValidRepPassword(string pass, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (pass != password_textBox.Text)
            {
                errorMessage = "passwords doesn't match";
                return false;
            }
            else if(pass.Length == 0)
            {
                errorMessage = "password is required";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.StartLoginForm();
        }
    }
}
