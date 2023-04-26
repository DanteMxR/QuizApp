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
using System.IO;

namespace Курсовая_Прод
{
    /// <summary>
    /// Логика взаимодействия для Student_WindowLogin.xaml
    /// </summary>
    public partial class Student_WindowLogin : Window
    {
        public Student_WindowLogin()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mistake = "Неправильное ФИО или Группа";

            string name = NameBox.Text ;

            string surname = SureNameBox.Text ;

            string group = GroupBox.Text;

            string fileName = "StudentAcounts.txt";

            string filePath = System.IO.Path.Combine(Environment.CurrentDirectory, fileName);
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Имя,Фамилия,Группа");
                }
            }
            bool isAuthorized = false;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    if (values[0] == name && values[1] == surname && values[2] == group)
                    {
                        using (StreamWriter writer = File.AppendText("Authorized.txt"))
                        {
                            writer.WriteLine($"{name}, {surname}, {group}");
                        }
                    isAuthorized = true;
                        break;
                    }
                }
            }

            if (isAuthorized)
            {
                StudentTestWindow studentTestWindow = new StudentTestWindow();
                studentTestWindow.Show();
                this.Close();
            }
            else
            {
                Mistake.Content = mistake;
            }
        }
    }
}
