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
using WPFDllTestHarness.Services;

namespace WPFDllTestHarness
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ComService _ComService;
        AsynchronousSocketListener SocketListener;
        public MainWindow()
        {
            InitializeComponent();
            _ComService = ComService.Instance();
        }

        private void Inject_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("injecting");
            ComService.Instance().StartService();
            Console.WriteLine("injecting Complete");
        }

        private void SocketServerButton_Click(object sender, RoutedEventArgs e)
        {
            SocketListener =  new AsynchronousSocketListener();
            SocketListener.StartListening();

        }
    }
}
