using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    internal static class AcoountInfo
    {
        private static int _id = -1;
        public static int ID { get { return _id; } private set { _id = value; } }
        public static string Name { get; private set; }

        public delegate void OnAccountChange();
        public static event OnAccountChange? AccountChanged;


        public static void SignOut()
        {
            ID = -1;
            Name = "N/A";
            AccountChanged?.Invoke();
        }

        public static void SignIn(int id, string accountName)
        {
            ID = id;
            Name = accountName;
            AccountChanged?.Invoke();
        }
    }
}
