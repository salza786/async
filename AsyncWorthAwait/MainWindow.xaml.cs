using System.Windows;

namespace AsyncWorthAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void action1_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Action 1 started...";
            var actionResult = await Action1.Execute();
            label1.Content = actionResult;
        }
    }
}
 