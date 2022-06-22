using SQL_Tutorial.Views;
using SQL_Tutorial.Views.Admin;
using SQL_Tutorial.Properties;
using System.Windows;

namespace SQL_Tutorial
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IntroText.Text = Settings.Default.Intro_Text;
            Überschrift.Text = Settings.Default.Ueberschrift;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var Lektion = new Lektion("l1");

            Lektion.Show();
            Close();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            var Lektion = new Lektion("l2");

            Lektion.Show();
            Close();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            var Lektion = new Lektion("l3");

            Lektion.Show();
            Close();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            var Lektion = new Lektion("l4");

            Lektion.Show();
            Close();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            var Lektion = new Lektion("l5");

            Lektion.Show();
            Close();
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            var admin = new Admin_login();
            admin.Show();
            Close();
        }
    }
}
