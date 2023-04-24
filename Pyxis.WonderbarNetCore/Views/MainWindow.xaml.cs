using WPFAndUWPDemo.MyWPFApp.ViewModels;
using System.Windows;

namespace WPFAndUWPDemo.MyWPFApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            this.InitializeComponent();
            base.Loaded += (s, e) =>
            {
                ((MainWindowViewModel)base.DataContext).PassiveLoading();
            };
        }
    }
}