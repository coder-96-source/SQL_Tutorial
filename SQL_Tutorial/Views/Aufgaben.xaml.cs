using SQL_Tutorial.Properties;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace SQL_Tutorial.Views
{
    /// <summary>
    /// Interaktionslogik für Lektion1.xaml
    /// </summary>
    public partial class Aufgaben : Window
    {
        private string _lektion;

        public Aufgaben(string lektion)
        {
            InitializeComponent();
            _lektion = lektion;
            InitilizeTextBlocks();

            Header.Text = "Aufgaben " + _lektion.Substring(1, 1);
        }
        public void InitilizeTextBlocks()
        {
            switch (_lektion)
            {
                case "l1":
                    Aufgabe1.Text = Settings.Default.L1_Aufgabe1;
                    Aufgabe2.Text = Settings.Default.L1_Aufgabe2;
                    Aufgabe3.Text = Settings.Default.L1_Aufgabe3;
                    Aufgabe4.Text = Settings.Default.L1_Aufgabe4;
                    break;
                case "l2":
                    Aufgabe1.Text = Settings.Default.L2_Aufgabe1;
                    Aufgabe2.Text = Settings.Default.L2_Aufgabe2;
                    Aufgabe3.Text = Settings.Default.L2_Aufgabe3;
                    Aufgabe4.Text = Settings.Default.L2_Aufgabe4;
                    break;
                case "l3":
                    Aufgabe1.Text = Settings.Default.L3_Aufgabe1;
                    Aufgabe2.Text = Settings.Default.L3_Aufgabe2;
                    Aufgabe3.Text = Settings.Default.L3_Aufgabe3;
                    Aufgabe4.Text = Settings.Default.L3_Aufgabe4;
                    break;
                case "l4":
                    Aufgabe1.Text = Settings.Default.L4_Aufgabe1;
                    Aufgabe2.Text = Settings.Default.L4_Aufgabe2;
                    Aufgabe3.Text = Settings.Default.L4_Aufgabe3;
                    Aufgabe4.Text = Settings.Default.L4_Aufgabe4;
                    break;
                case "l5":
                    Aufgabe1.Text = Settings.Default.L5_Aufgabe1;
                    Aufgabe2.Text = Settings.Default.L5_Aufgabe2;
                    Aufgabe3.Text = Settings.Default.L5_Aufgabe3;
                    Aufgabe4.Text = Settings.Default.L5_Aufgabe4;
                    break;
            }
        }

        private async void B1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sql = new TextRange(T1.Document.ContentStart, T1.Document.ContentEnd).Text;
                var queryruckgabe = await Task.Run(() => DatabaseHelper.DatabaseReader.Read(sql));
                if (queryruckgabe == null) throw new Exception();
                var rueckgabe = new SqlRueckgabe(queryruckgabe);
                rueckgabe.Show();
            }
            catch
            {
                MessageBox.Show("Die SQL Anweisung war Fehlerhaft");
            }
        }

        private async void B2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sql = new TextRange(T2.Document.ContentStart, T2.Document.ContentEnd).Text;
                var queryruckgabe = await Task.Run(() => DatabaseHelper.DatabaseReader.Read(sql));
                if (queryruckgabe == null) throw new Exception();
                var rueckgabe = new SqlRueckgabe(queryruckgabe);
                rueckgabe.Show();
            }
            catch
            {
                MessageBox.Show("Die SQL Anweisung war Fehlerhaft");
            }
        }

        private async void B3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sql = new TextRange(T3.Document.ContentStart, T3.Document.ContentEnd).Text;
                var queryruckgabe = await Task.Run(() => DatabaseHelper.DatabaseReader.Read(sql));
                if (queryruckgabe == null) throw new Exception();
                var rueckgabe = new SqlRueckgabe(queryruckgabe);
                rueckgabe.Show();
            }
            catch
            {
                MessageBox.Show("Die SQL Anweisung war Fehlerhaft");
            }
        }

        private async void B4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sql = new TextRange(T4.Document.ContentStart, T4.Document.ContentEnd).Text;
                var queryruckgabe = await Task.Run(() => DatabaseHelper.DatabaseReader.Read(sql));
                if (queryruckgabe == null) throw new Exception();
                var rueckgabe = new SqlRueckgabe(queryruckgabe);
                rueckgabe.Show();
            }
            catch
            {
                MessageBox.Show("Die SQL Anweisung war Fehlerhaft");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new Lektion(_lektion);
            mainWindow.Show();
            Close();
        }
    }
}
