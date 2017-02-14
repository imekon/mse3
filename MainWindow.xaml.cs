using System.Windows;
using mse.Models;
using mse.ViewModels;

namespace mse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Scene scene;
        private MainViewModel mainViewModel;

        public MainWindow()
        {
            InitializeComponent();

            scene = new Scene();
            mainViewModel = new MainViewModel(scene);

            DataContext = mainViewModel;
        }
    }
}
