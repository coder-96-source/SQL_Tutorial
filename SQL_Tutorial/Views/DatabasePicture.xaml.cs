using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SQL_Tutorial.Views
{
    /// <summary>
    /// Interaktionslogik für DatabasePicture.xaml
    /// </summary>
    public partial class DatabasePicture : Window
    {
        public DatabasePicture(string db_img_path)
        {
            InitializeComponent();
            ImageBrush imgBrush = new ImageBrush();
            imgBrush.ImageSource = new BitmapImage(new Uri(db_img_path, UriKind.Relative));
            bg.Background = imgBrush;

            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            WindowState = WindowState.Maximized;
        }
    }
}
