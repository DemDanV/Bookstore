using System.Data.OleDb;

namespace Bookstore
{
    internal static class Program
    {
        static Form1 MainPage = new Form1();
        static Reg RegPage;
        static LogIn LoginPage;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(MainPage);
        }

        public static void StartRegForm()
        {
            if(LoginPage != null)
            {
                LoginPage.Visible = false;
                LoginPage.Close();
            }

            RegPage = new Reg();
            RegPage.Show();
        }

        internal static void StartLoginForm()
        {
            if(RegPage != null)
            {
                RegPage.Visible = false;
                RegPage.Close();
            }

            LoginPage = new LogIn();
            LoginPage.Show();
        }

        internal static void StartSubForm()
        {
            if (RegPage != null)
            {
                RegPage.Visible = false;
                RegPage.Close();
            }

            LoginPage = new LogIn();
            LoginPage.Show();
        }
    }
}