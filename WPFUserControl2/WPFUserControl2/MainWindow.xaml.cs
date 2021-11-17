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
        }

        private void ucMammal1_Loaded(object sender, RoutedEventArgs e)
        {
            ucMammal1.mam = new Dog() {Name = "Dog1", Weight = 50, Age = 4 };
            ucMammal1.UpdateMammalUI();
        }

        private void ucMammal2_Loaded(object sender, RoutedEventArgs e)
        {
            ucMammal2.mam = new Cat() { Name = "Cat1", Weight = 5, Age = 1 };
            ucMammal2.UpdateMammalUI();
        }
    }
}
