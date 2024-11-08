namespace Bookstore
{
    internal static class Program
    {
        private static Form? _currentForm;
        private static Dictionary<Type, Form> _formInstances = new Dictionary<Type, Form>();

        public static void ShowForm<T>() where T : Form, new()
        {
            if (_currentForm != null && _currentForm.GetType() != typeof(T))
            {
                _currentForm.Hide();
                _currentForm = null;
            }

            if (_formInstances.ContainsKey(typeof(T)))
            {
                if (_formInstances[typeof(T)].IsDisposed)
                {
                    _formInstances[typeof(T)] = new T(); // Пересоздание формы, если она утилизирована
                }
            }
            else
            {
                _formInstances[typeof(T)] = new T();
            }

            _currentForm = _formInstances[typeof(T)];
            _currentForm.Show();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ShowForm<MainPage>();
            Application.Run();
        }

        public static void StartRegForm()
        {
            ShowForm<RegPage>();
        }

        public static void StartLoginForm()
        {
            ShowForm<LogInPage>();
        }

        public static void StartSubForm()
        {
            //TODO
            //ShowForm<SubscribePage>();
        }
    }
}