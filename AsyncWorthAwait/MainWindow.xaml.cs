using System;
using System.Windows;
using System.Windows.Input;

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


        private async void action2_Click_1(object sender, RoutedEventArgs e)
        {
            label2.Content = DateTime.Now.ToString("hh:mm:ss:ff");
            label2A.Content = await Action2.ExecuteA();
            label2B.Content = await  Action2.ExecuteB();
            label2C.Content = DateTime.Now.ToString("hh:mm:ss:ff");



        }
    }
}
 