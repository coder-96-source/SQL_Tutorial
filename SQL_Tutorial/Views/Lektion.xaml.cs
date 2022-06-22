using SQL_Tutorial.Properties;
using System.Threading;
using System.Windows;

namespace SQL_Tutorial.Views
{
    /// <summary>
    /// Interaktionslogik für Lektion1.xaml
    /// </summary>
    public partial class Lektion : Window
    {
        private string _lektion;

        public Lektion(string lektion)
        {
            InitializeComponent();
            _lektion = lektion;

            switch (_lektion)
            {
                case "l1":
                    Lektion_Ueberschrift.Text = Settings.Default.Lektion1_Titel;
                    Lektion_Text.Text = Settings.Default.Lektion1_Text;
                    break;
                case "l2":
                    Lektion_Ueberschrift.Text = Settings.Default.Lektion2_Titel;
                    Lektion_Text.Text = Settings.Default.Lektion2_Text;
                    break;
                case "l3":
                    Lektion_Ueberschrift.Text = Settings.Default.Lektion3_Titel;
                    Lektion_Text.Text = Settings.Default.Lektion3_Text;
                    break;
                case "l4":
                    Lektion_Ueberschrift.Text = Settings.Default.Lektion4_Titel;
                    Lektion_Text.Text = Settings.Default.Lektion4_Text;
                    break;
                case "l5":
                    Lektion_Ueberschrift.Text = Settings.Default.Lektion5_Titel;
                    Lektion_Text.Text = Settings.Default.Lektion5_Text;
                    break;
            }
        }

        private void AButton_Click(object sender, RoutedEventArgs e)
        {
            var Aufgaben = new Aufgaben(_lektion);
            Aufgaben.Show();
            Close();
        }

        private void LButton_Click(object sender, RoutedEventArgs e)
        {
            var Loesung = new Loesung(_lektion);
            Loesung.Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var back = new MainWindow();
            back.Show();
            Close();
        }

        private void Database_Click(object sender, RoutedEventArgs e)
        {
            var erDatabase = new DatabasePicture(@"../../Assets/er_nordwind.png");
            erDatabase.Show();
            //Thread.Sleep(2000);
            Focus();
           
        }
    }
}
