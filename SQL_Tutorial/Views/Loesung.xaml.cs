using SQL_Tutorial.Properties;
using System.Windows;

namespace SQL_Tutorial.Views
{
    /// <summary>
    /// Interaktionslogik für Lektion1.xaml
    /// </summary>
    public partial class Loesung : Window
    {
        private string _lektion;

        public Loesung(string lektion)
        {
            InitializeComponent();
            _lektion = lektion;

            Header.Text = "Lösung " + _lektion.Substring(1, 1);

            switch (lektion)
            {
                case "l1":
                    L1.Text = Settings.Default.L1_Loesung1;
                    L2.Text = Settings.Default.L1_Loesung2;
                    L3.Text = Settings.Default.L1_Loesung3;
                    L4.Text = Settings.Default.L1_Loesung4;
                    break;
                case "l2":
                    L1.Text = Settings.Default.L2_Loesung1;
                    L2.Text = Settings.Default.L2_Loesung2;
                    L3.Text = Settings.Default.L2_Loesung3;
                    L4.Text = Settings.Default.L2_Loesung4;
                    break;
                case "l3":
                    L1.Text = Settings.Default.L3_Loesung1;
                    L2.Text = Settings.Default.L3_Loesung2;
                    L3.Text = Settings.Default.L3_Loesung3;
                    L4.Text = Settings.Default.L3_Loesung4;
                    break;
                case "l4":
                    L1.Text = Settings.Default.L4_Loesung1;
                    L2.Text = Settings.Default.L4_Loesung2;
                    L3.Text = Settings.Default.L4_Loesung3;
                    L4.Text = Settings.Default.L4_Loesung4;
                    break;
                case "l5":
                    L1.Text = Settings.Default.L5_Loesung1;
                    L2.Text = Settings.Default.L5_Loesung2;
                    L3.Text = Settings.Default.L5_Loesung3;
                    L4.Text = Settings.Default.L5_Loesung4;
                    break;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Lektion lektion = new Lektion(_lektion);
            lektion.Show();
            Close();
        }
    }
}
