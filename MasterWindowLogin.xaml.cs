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
    /// Логика взаимодействия для MasterWindowLogin.xaml
    /// </summary>
    public partial class MasterWindowLogin : Window
    {
        public MasterWindowLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mistake = "Неправельный логин или пороль";

            string login = LoginBox.Text;

            string password = PasswordBox.Password;

            string fileName = "MasterAcounts.txt";

            string filePath = System.IO.Path.Combine(Environment.CurrentDirectory, fileName);
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Имя,Пароль");
                }
            }
            bool isAuthorized = false;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    if (values[0] == login && values[1] == password)
                    {
                        isAuthorized = true;
                        break;
                    }
                }
            }

            if (isAuthorized)
            {
                MasterWindow masterWindow = new MasterWindow();
                masterWindow.Show();
                this.Close();
            }
            else
            {
                Mistake.Content = mistake;
            }
        }
    }
}