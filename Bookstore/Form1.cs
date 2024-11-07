using System.Data;
using System.Data.OleDb;

namespace Bookstore
{
    public partial class Form1 : Form
    {
        DataTable shop = new DataTable();
        DataTable subs = new DataTable();
        DataTable cart = new DataTable();

        public Form1()
        {
            InitializeComponent();
            SetupLayout();

            AcoountInfo.AccountChanged += reloadAccountInfo;

            RefreshShopDataTable();
            LoadAllFrom(shop);
        }

        private void SetupLayout()
        {
            this.Controls.Add(dataGridView1);

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Name = "dataGridView1";
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void RefreshShopDataTable()
        {
            shop = new DataTable();
            OleDbConnection DBConnection = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;
                Data Source = " + Environment.CurrentDirectory + "\\Books.accdb"
                );

            OleDbCommand cmd = new OleDbCommand("select * from tbl_data", DBConnection);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            da.Fill(shop);

            SetupSelectedRowUI();
        }

        OleDbConnection DBConnection = new OleDbConnection(
        @"Provider=Microsoft.ACE.OLEDB.12.0;
                        Data Source=" + Environment.CurrentDirectory + "\\Books.accdb"
        );
        private void FillTableFromDB(string query, DataTable fill)
        {
            OleDbCommand sqlcmd = new OleDbCommand(query, DBConnection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlcmd);
            adapter.Fill(fill);
        }

        private bool MakeChangesInDB(string query)
        {
            OleDbCommand sqlcmd = new OleDbCommand(query, DBConnection);
            DBConnection.Open();
            bool needToRefreshData = sqlcmd.ExecuteNonQuery() > 0;
            DBConnection.Close();
            return needToRefreshData;
        }

        private void RefreshSubsDataTable()
        {
            DataTable subsID = new DataTable();

            string query = "SELECT ID_Books FROM clientsSubs_table WHERE [ID_Client] = " + AcoountInfo.ID;
            FillTableFromDB(query, subsID);

            subs = new DataTable();
            if (subsID.Rows.Count > 0)
            {
                foreach (DataRow sub in subsID.Rows)
                {
                    query = "SELECT * FROM tbl_data WHERE [ID] = " + sub[0];
                    FillTableFromDB(query, subs);
                }
            }

            SetupSelectedRowUI();
        }

        private void RefreshCartDataTable()
        {
            DataTable booksID = new DataTable();
            string query = "SELECT ID, ID_Book, Order_Amount FROM clientsCart_table WHERE [ID_Client] = " + AcoountInfo.ID;
            FillTableFromDB(query, booksID);

            cart = new DataTable();

            if (booksID.Rows.Count > 0)
            {
                foreach (DataRow b in booksID.Rows)
                {
                    query = "SELECT * FROM tbl_data WHERE [ID] = " + b["ID_Book"];
                    FillTableFromDB(query, cart);
                }
                cart.Columns["ID"].ColumnName = "ID_Book";

                /* You created a DataColumn here which is the first thing to do when you want to add a column to a DataTable */
                cart.Columns.Add("Order amount", typeof(int));
                cart.Columns.Add("ID", typeof(int));

                /* You then added the created column to your DataTable, so it should be working */
                DataRow drowItem;
                for (int i = 0; i < cart.Rows.Count; i++)
                {
                    drowItem = cart.NewRow();
                    drowItem["Order amount"] = booksID.Rows[i]["Order_Amount"];
                    drowItem["ID"] = booksID.Rows[i]["ID"];

                    cart.Rows[i]["Order amount"] = drowItem["Order amount"];
                    cart.Rows[i]["ID"] = drowItem["ID"];
                }
            }

            SetupSelectedRowUI();
        }


        private void AddToSubDataTable(int ID_Book)
        {
            DataRow row = shop.Select("ID = " + ID_Book)[0];
            object[] toAdd = new object[]{ row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4], row.ItemArray[5], row.ItemArray[6] };
            subs.Rows.Add(toAdd);

            SetupSelectedRowUI();
        }

        private void RemoveFromSubDataTable(int ID_Book)
        {
            subs.Rows.Remove(subs.Select("ID = " + ID_Book)[0]);

            SetupSelectedRowUI();
        }

        private void LoadAllFrom(DataTable from)
        {
            sub_button.Enabled = false;
            unsub_button.Enabled = false;
            addToCard_button.Enabled = false;

            dataGridView1.DataSource = from;
            if(from.Rows.Count>0)
            dataGridView1.Columns["ID"].Visible = false;
        }


        private void search_button_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void search_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void Search()
        {
            BindingSource source1 = new BindingSource();
            source1.DataSource = dataGridView1.DataSource;
            dataGridView1.DataSource = source1;


            if (search_textBox.Text.Length == 0)
            {
                source1.RemoveFilter();

                return;
            }

            string[] words = search_textBox.Text.Split(' ');

            if (words.Length > 20)
            {
                string[] tmp = new string[20];
                words.CopyTo(tmp, 0);
                words = tmp;
                MessageBox.Show("The request is too large. It was cut down to 20 words");
            }

            string megaString = "";
            foreach (string word in words)
            {
                megaString += "Name LIKE '%" + word + "%' OR Author LIKE '%" + word + "%' OR ";
            }
            megaString = megaString.Remove(megaString.Length - 4);
            source1.Filter = megaString;
        }


        private void notify_button_Click(object sender, EventArgs e)
        {
            Program.StartSubForm();
        }


        private void reg_button_Click(object sender, EventArgs e)
        {
            Program.StartRegForm();
        }

        private void reloadAccountInfo()
        {
            //LogOut
            if (AcoountInfo.ID == -1)
            {
                SetLogginedInfoActive(false);
                if (dataGridView1.DataSource.Equals(shop) == false)
                GoToMainPage();
                return;
            }

            RefreshSubsDataTable();
            RefreshCartDataTable();
            Random random = new Random();
            string[] WelcomePhrases = new string[] { "Welcome", "Hello", "Nice to see you" };
            authorized_label.Text = WelcomePhrases[random.Next(0,3)] +", "+ AcoountInfo.Name;

            SetLogginedInfoActive(true);
        }

        private void SetLogginedInfoActive(bool state)
        {
            authorized_label.Visible = state;
            signOut_button.Visible = state;
            subs_linkLabel.Visible = state;
            cart_button.Enabled = true;
;
            signIn_button.Visible = !state;
            reg_button.Visible = !state;

            unsub_button.Enabled = false;
            sub_button.Enabled = false;
            addToCard_button.Enabled = false;
        }

        private void signOut_button_Click(object sender, EventArgs e)
        {
            AcoountInfo.SignOut();
        }

        private void signIn_button_Click(object sender, EventArgs e)
        {
            Program.StartLoginForm();
        }


        private void subs_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            subs_linkLabel.Visible = false;
            showAllBooks_linkLabel.Visible = true;
            search_textBox.PlaceholderText = "Поиск подписок по названию и автору литературы";

            LoadAllFrom(subs);
        }

        private void showAllBooks_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            subs_linkLabel.Visible = true;
            showAllBooks_linkLabel.Visible = false;
            search_textBox.PlaceholderText = "Поиск литературы по названию и автору";

            LoadAllFrom(shop);
        }


        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SetupSelectedRowUI();
        }

        private void SetupSelectedRowUI()
        {
            if (AcoountInfo.ID == -1)
                return;

            if (dataGridView1.SelectedRows.Count == 0)
                return;

            if (dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Amount"].Value == null ||(int)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Amount"].Value == 0)
            {
                addToCard_button.Enabled = false;
                buy_button.Enabled = false;
            }
            else
            {
                addToCard_button.Enabled = true;
                buy_button.Enabled = true;
            }
            if (dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Amount"].Value == null)
                return;

            int bookID = (int)(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ID"].Value);
            var dr = subs.AsEnumerable()
               .SingleOrDefault(r => r.Field<int>("ID") == bookID);

            bool bookInSubs = dr != null;
            if (bookInSubs)
            {
                sub_button.Enabled = false;
                unsub_button.Enabled = true;
            }
            else
            {
                sub_button.Enabled = true;
                unsub_button.Enabled = false;
            }
        }

        private void sub_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int bookID = (int)(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ID"].Value);
            string query = "INSERT INTO clientsSubs_table VALUES (" + AcoountInfo.ID + "," + bookID + ")";
            bool needToRefreshData = MakeChangesInDB(query);

            if (needToRefreshData)
            {
                AddToSubDataTable(bookID);
            }
        }

        private void unsub_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int bookID = (int)(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ID"].Value);
            string query = "DELETE FROM clientsSubs_table WHERE ID_Client = " + AcoountInfo.ID + " AND ID_BOOKS = " + bookID;
            bool needToRefreshData = MakeChangesInDB(query);

            if (needToRefreshData)
            {
                RemoveFromSubDataTable(bookID);
            }
        }

        private void cart_button_Click(object sender, EventArgs e)
        {
            LoadCartPage();
        }

        private void LoadCartPage()
        {
            subs_linkLabel.Visible = false;
            showAllBooks_linkLabel.Visible = false;
            mainPage_linkLabel.Visible = true;
            addToCard_button.Visible = false;
            buy_button.Visible = true;
            search_textBox.PlaceholderText = "Поиск литературы по названию и автору";

            RefreshCartDataTable();

            LoadAllFrom(cart);

            if (cart.Rows.Count > 0)
            {
                dataGridView1.Columns["Order amount"].ReadOnly = false;
                dataGridView1.Columns["ID_Book"].Visible = false;
            }
        }

        private void RemoveFromCart(object? sender, DataGridViewRowCancelEventArgs e)
        {
            int bookID = (int)(dataGridView1.Rows[e.Row.Index].Cells["ID_Book"].Value);
            string query = "DELETE * FROM clientsCart_table WHERE [ID_Client] = " + AcoountInfo.ID + " AND [ID_Book] = " + bookID;
            bool needToRefreshData = MakeChangesInDB(query);

            if (needToRefreshData)
            {
                RemoveFromCartDataTable(bookID);
            }
        }

        private void RemoveFromCartDataTable(int ID_Book)
        {
            cart.Rows.Remove(cart.Select("ID_Book = " + ID_Book)[0]);

            SetupSelectedRowUI();
        }

        private void mainPage_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoToMainPage();
        }

        private void GoToMainPage()
        {
            subs_linkLabel.Visible = true;
            showAllBooks_linkLabel.Visible = false;
            mainPage_linkLabel.Visible = false;
            addToCard_button.Visible = true;
            buy_button.Visible = false;
            dataGridView1.AllowUserToDeleteRows = false;

            LoadAllFrom(shop);
        }

        private void addToCard_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int bookID = (int)(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ID"].Value);

            string query = "SELECT Order_Amount FROM clientsCart_table WHERE [ID_Client] = " + AcoountInfo.ID + " AND [ID_Book] = " + bookID;
            DataTable dt = new DataTable();

            FillTableFromDB(query, dt);
            if(dt.Rows.Count == 0)
            {
                query = "INSERT INTO clientsCart_table (ID_Client, ID_Book, Order_Amount) VALUES (" + AcoountInfo.ID + "," + bookID + ", 1)";
                MakeChangesInDB(query);
            }
        }

        private void buy_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int bookID = (int)(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["ID_Book"].Value);

            string query = "SELECT Order_Amount FROM clientsCart_table WHERE [ID_Client] = " + AcoountInfo.ID + " AND [ID_Book] = " + bookID;
            DataTable dt = new DataTable();
            FillTableFromDB(query, dt);
            if (dt.Rows.Count != 0)
            {
                query = "INSERT INTO clientsOrders_table (ID_Client, ID_Book, Amount, Price) VALUES (" + AcoountInfo.ID + "," + bookID + ", " + dt.Rows[0]["Order_Amount"] + ", " + (int)(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["Price"].Value)+")";

                MakeChangesInDB(query);

                query = "UPDATE tbl_data SET Amount = Amount - "+ dt.Rows[0]["Order_Amount"]+" WHERE [ID] = "+bookID;

                MakeChangesInDB(query);

                RefreshShopDataTable();
                RefreshSubsDataTable();
                RefreshCartDataTable();

                LoadCartPage();
            }
        }
    }
}