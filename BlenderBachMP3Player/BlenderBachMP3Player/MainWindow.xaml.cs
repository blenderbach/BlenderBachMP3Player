using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
namespace BlenderBachMP3Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Mp3Player mp3Player = new Mp3Player();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = ""; // Default file name
            dlg.DefaultExt = ".mp3"; // Default file extension
            dlg.Filter = "MP3 Files (.mp3)|*.mp3"; // Filter files by extension

            // Show open file dialog box
            bool? result = dlg.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mp3Player.play();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            mp3Player.stop();
        }
    }
}
