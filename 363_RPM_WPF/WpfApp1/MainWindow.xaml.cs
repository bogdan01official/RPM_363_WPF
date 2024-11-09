using System.Text;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private int NumderNow = 0;

        private void addNum(object sender, MouseButtonEventArgs e)
        {
            NumList.Items.Add(NumderNow);
            NumderNow++;
        }

        private void delNum(object sender, MouseButtonEventArgs e)
        {
           if (NumList.SelectedItem != null) {
                NumList.Items.Remove(NumList.SelectedItem);
            }
        }

        private void clearNumList(object sender, MouseButtonEventArgs e)
        {
            NumList.Items.Clear();
            NumderNow = 0;
        }
    }
}