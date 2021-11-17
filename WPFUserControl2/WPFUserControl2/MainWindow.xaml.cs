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
using WPFDogLibrary;

namespace WPFUserControl2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IMammal mam;

        public MainWindow()
        {
            InitializeComponent();
            mam = new Dog();
            UpdateMammalUI();
        }

        public void UpdateMammalUI()
        {
            tbName.Text = mam.Name;
            tbAge.Text = mam.Age.ToString();
            tbWeight.Text = mam.Weight.ToString();
        }

        private void btnFeed_Click(object sender, RoutedEventArgs e)
        {
            mam.Weight++;
            UpdateMammalUI();
        }

        private void btnWalk_Click(object sender, RoutedEventArgs e)
        {
            mam.Weight--;
            UpdateMammalUI();
        }
    }
}
