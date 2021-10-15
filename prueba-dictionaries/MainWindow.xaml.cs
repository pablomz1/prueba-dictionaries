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

namespace prueba_dictionaries
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            var alumnos = new Dictionary<int, string>()
            {
                { 1,"pablo"},
                {2,"juan" },

            };
            for (int c = 1; c < 2; c++)
            {
                 Tbx_add.Text = alumnos[c];
                

            }
           // MessageBox.Show (alumnos[2]);
        }

       
    }
}
