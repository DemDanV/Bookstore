namespace Bookstore
{
    public class AccountChangedEventArgs : EventArgs
    {
        public int AccountId { get; }
        public string AccountName { get; }

        public AccountChangedEventArgs(int accountId, string accountName)
        {
            AccountId = accountId;
            AccountName = accountName;
        }
    }

    internal static class AccountInfo
    {
        private static int _id = -1;
        public static int ID
        {
            get { return _id; }
            private set { _id = value; }
        }
        public static string Name { get; private set; } = "N/A";

        public static event EventHandler<AccountChangedEventArgs>? AccountChanged;

        public static void SignOut()
        {
            ID = -1;
            Name = "N/A";
            OnAccountChanged();
        }

        public static void SignIn(int id, string accountName)
        {
            ID = id;
            Name = accountName;
            OnAccountChanged();
        }

        private static void OnAccountChanged()
        {
            AccountChanged?.Invoke(null, new AccountChangedEventArgs(ID, Name));
        }
    }
}
