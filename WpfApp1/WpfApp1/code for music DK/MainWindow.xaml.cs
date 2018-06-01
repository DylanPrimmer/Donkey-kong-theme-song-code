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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer musicPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent(); musicPlayer.Open(new Uri("//HHSDC/181345$/My Documents/ICS3U/Programs/donkey kong/WpfApp1/WpfApp1/bin/Debug/01 - Donkey Kong Main Theme.mp3"));
            musicPlayer.Play();
            
            musicPlayer.MediaEnded += MusicPlayer_MediaEnded;


        }

        private void MusicPlayer_MediaEnded(object sender, EventArgs e)
        {
           
            musicPlayer.Position = new TimeSpan();
            musicPlayer.Play();
        }
    }
}
