using System;
using System.Windows;
using System.Windows.Input;
using System.Configuration;
using System.IO;
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
using Diplom;

namespace Курсовая_Прод
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


        private void StudentButton_Click(object sender, RoutedEventArgs e)
        {
           Student_WindowLogin student_WindowLogin = new Student_WindowLogin();
            student_WindowLogin.Show();
        }

        private void MasterButton_Click(object sender, RoutedEventArgs e)
        {
            MasterWindowLogin masterWindowLogin = new MasterWindowLogin();
            masterWindowLogin.Show();
        }

        private void Lecture_Click(object sender, RoutedEventArgs e)
        {
            LectureWindow lecture_Window = new LectureWindow();
            lecture_Window.Show();
        }
    }
}
