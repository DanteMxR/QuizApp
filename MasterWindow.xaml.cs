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
    /// Логика взаимодействия для MasterWindow.xaml
    /// </summary>
    public partial class MasterWindow : Window
    {
        public MasterWindow()
        {
            InitializeComponent();
        }

        private void MasterList_Click(object sender, RoutedEventArgs e)
        {
            MasterList masterList = new MasterList();
            masterList.Show();
        }

        private void NewStudent_Click(object sender, RoutedEventArgs e)
        {
            NewStudent student = new NewStudent();
            student.Show();
        }
    }
}
