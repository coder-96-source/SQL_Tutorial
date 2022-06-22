using SQL_Tutorial.Properties;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SQL_Tutorial.Views.Admin
{
    /// <summary>
    /// Interaktionslogik für Admin_Einstellungen.xaml
    /// </summary>
    public partial class Admin_Einstellungen : Window
    {
        public Admin_Einstellungen()
        {
            InitializeComponent();
            initilize();
        }
        public void Intro_Speichern(object sender, RoutedEventArgs e)
        {
            Settings.Default.Intro_Text = IntroText.Text;
            Settings.Default.Save();
        }

        public void Ueberschrift_Speichern(object sender, RoutedEventArgs e)
        {
            Settings.Default.Ueberschrift = Ueberschrift.Text;
            Settings.Default.Save();
        }

        public void initilize()
        {
            //Intotext and database path initilizer
            Ueberschrift.Text = Settings.Default.Ueberschrift;
            IntroText.Text = Settings.Default.Intro_Text;
            FileNameTextBox.Text = Settings.Default.DB_Path;
            
            //Lecture 1 questions
            L1_Frage1.Text = Settings.Default.L1_Aufgabe1;
            L1_Frage2.Text = Settings.Default.L1_Aufgabe2;
            L1_Frage3.Text = Settings.Default.L1_Aufgabe3;
            L1_Frage4.Text = Settings.Default.L1_Aufgabe4;

            //Lecture 2 questions
            L2_Frage1.Text = Settings.Default.L2_Aufgabe1;
            L2_Frage2.Text = Settings.Default.L2_Aufgabe2;
            L2_Frage3.Text = Settings.Default.L2_Aufgabe3;
            L2_Frage4.Text = Settings.Default.L2_Aufgabe4;

            //Lecture 3 questions
            L3_Frage1.Text = Settings.Default.L3_Aufgabe1;
            L3_Frage2.Text = Settings.Default.L3_Aufgabe2;
            L3_Frage3.Text = Settings.Default.L3_Aufgabe3;
            L3_Frage4.Text = Settings.Default.L3_Aufgabe4;

            //Lecture 4 questions
            L4_Frage1.Text = Settings.Default.L4_Aufgabe1;
            L4_Frage2.Text = Settings.Default.L4_Aufgabe2;
            L4_Frage3.Text = Settings.Default.L4_Aufgabe3;
            L4_Frage4.Text = Settings.Default.L4_Aufgabe4;

            //Lecture 5 questions
            L5_Frage1.Text = Settings.Default.L5_Aufgabe1;
            L5_Frage2.Text = Settings.Default.L5_Aufgabe2;
            L5_Frage3.Text = Settings.Default.L5_Aufgabe3;
            L5_Frage4.Text = Settings.Default.L5_Aufgabe4;

            //initilize all Solutions

            L1_Lösung1.Text = Settings.Default.L1_Loesung1;
            L1_Lösung2.Text = Settings.Default.L1_Loesung2;
            L1_Lösung3.Text = Settings.Default.L1_Loesung3;
            L1_Lösung4.Text = Settings.Default.L1_Loesung4;

            L2_Lösung1.Text = Settings.Default.L2_Loesung1;
            L2_Lösung2.Text = Settings.Default.L2_Loesung2;
            L2_Lösung3.Text = Settings.Default.L2_Loesung3;
            L2_Lösung4.Text = Settings.Default.L2_Loesung4;

            L3_Lösung1.Text = Settings.Default.L3_Loesung1;
            L3_Lösung2.Text = Settings.Default.L3_Loesung2;
            L3_Lösung3.Text = Settings.Default.L3_Loesung3;
            L3_Lösung4.Text = Settings.Default.L3_Loesung4;

            L4_Lösung1.Text = Settings.Default.L4_Loesung1;
            L4_Lösung2.Text = Settings.Default.L4_Loesung2;
            L4_Lösung3.Text = Settings.Default.L4_Loesung3;
            L4_Lösung4.Text = Settings.Default.L4_Loesung4;


            L5_Lösung1.Text = Settings.Default.L5_Loesung1;
            L5_Lösung2.Text = Settings.Default.L5_Loesung2;
            L5_Lösung3.Text = Settings.Default.L5_Loesung3;
            L5_Lösung4.Text = Settings.Default.L5_Loesung4;
        }

        private void Speichern(object sender, RoutedEventArgs e)
        {   //Find the pressed Button
            var button = (Button)sender;
            
            //Get the textbox for question
            var textBoxName = button.Name.Substring(0, 9);
            var txtBox = (TextBox)testgrid.FindName(textBoxName);

            //Get the solution for question
            var loeName = button.Name.Substring(0, 3) + "Lösung" + button.Name.Substring(8, 1);
            var loesungBox = (TextBox)testgrid.FindName(loeName);

            //Get the name of Settings variables
            var settingVariableQuestion = button.Name.Substring(0, 3)+"Aufgabe"+ button.Name.Substring(8, 1);
            var settingVariableSolution = button.Name.Substring(0, 3) + "Loesung" + button.Name.Substring(8, 1);
            var a = Settings.Default[settingVariableQuestion];

            //Save the changes
            Settings.Default[settingVariableQuestion] = txtBox.Text;
            Settings.Default[settingVariableSolution] = loesungBox.Text;

            Settings.Default.Save();
            //Message to the user
            MessageBox.Show("Es wurde erfolgreich gespeichert!");

        }
        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openFileDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true)
            {
                FileNameTextBox.Text = openFileDlg.FileName;
                Settings.Default.DB_Path = FileNameTextBox.Text;
                Settings.Default.Save();
            }


        }

        private void DB_Path_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.DB_Path = FileNameTextBox.Text;
            Settings.Default.Save();
        }
    }
}
