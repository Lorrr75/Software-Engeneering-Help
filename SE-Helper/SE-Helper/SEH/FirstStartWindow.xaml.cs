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
using System.Windows.Shapes;

namespace SEH
{
    /// <summary>
    /// Logica di interazione per FirstStartWindow.xaml
    /// </summary>
    public partial class FirstStartWindow : Window
    {
        public int SelectedOption { get; private set; }

        public FirstStartWindow()
        {
            InitializeComponent();
        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            SelectedOption = 3;
            this.DialogResult = true;
            this.Close();
        }
    }
}
