using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM clientsAcc_table where " +
                "( Name = '" + login_textBox.Text + "' " +
                "OR Email = '" + login_textBox.Text + "' " +
                ") AND Password = '" + password_textBox.Text + "'";
            OleDbConnection DBConnection = new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;
                        Data Source=" + Environment.CurrentDirectory + "\\Books.accdb"
                    );
            OleDbCommand sqlcmd = new OleDbCommand(query, DBConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlcmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            bool thereIsAcc = table.Rows.Count > 0;
            if (thereIsAcc)
            {
                AcoountInfo.SignIn(int.Parse(table.Rows[0][0].ToString()), table.Rows[0][1].ToString());
                Close();
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
