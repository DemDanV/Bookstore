using System.Data;
using System.Data.OleDb;

namespace Bookstore
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
            this.FormClosed += LogInPage_FormClosed;
        }

        private void LogInPage_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.FormClosed -= LogInPage_FormClosed;

            Program.ShowForm<MainPage>();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            string query = "SELECT * FROM clientsAcc_table where " +
                "( Name = '" + login_textBox.Text + "' " +
                "OR Email = '" + login_textBox.Text + "' " +
                ") AND Password = '" + password_textBox.Text + "'";
            using (OleDbConnection DBConnection = new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;
                        Data Source=" + Environment.CurrentDirectory + "\\Books.accdb"
                    ))
            {
                using (OleDbCommand sqlcmd = new OleDbCommand(query, DBConnection))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(sqlcmd);
                    adapter.Fill(table);
                }
            }


            bool accExists = table.Rows.Count > 0;
            if (accExists)
            {
                AccountInfo.SignIn(int.Parse(table.Rows[0][0].ToString()), table.Rows[0][1].ToString());
                Program.ShowForm<MainPage>();
            }
            else
            {
                MessageBox.Show("Error. You are not registered");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.StartRegForm();
        }
    }
}
