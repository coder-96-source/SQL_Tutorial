using SQL_Tutorial.Properties;
using System;
using System.Windows;

namespace SQL_Tutorial.Views.Admin
{
    /// <summary>
    /// Interaktionslogik für Admin_login.xaml
    /// </summary>
    public partial class Admin_login : Window
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Username.Text) && Password != null && Password.Password != "")
            {
                if (Username.Text == Settings.Default.Username && Password.Password == Settings.Default.Password)
                {
                    var Admin_Session = new Admin_Einstellungen();
                    Admin_Session.Show();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            Close();
        }
    }
}
