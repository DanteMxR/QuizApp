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

namespace Курсовая_Прод
{
    /// <summary>
    /// Логика взаимодействия для StudentTestWindow.xaml
    /// </summary>
    public partial class StudentTestWindow : Window
    {
        public StudentTestWindow()
        {
            InitializeComponent();
        }

        private void FirstTest_Click(object sender, RoutedEventArgs e)
        {
            FirstTest first= new FirstTest();
            first.Show();
        }

        private void SecondTest_Click(object sender, RoutedEventArgs e)
        {
            SecondTest second= new SecondTest();
            second.Show();
        }

        private void ThirdTest_Click(object sender, RoutedEventArgs e)
        {
            ThirdTest third= new ThirdTest();
            third.Show();
        }
    }
}
