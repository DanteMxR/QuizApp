using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для NewStudent.xaml
    /// </summary>
    public partial class NewStudent : Window
    {
        public NewStudent()
        {
            InitializeComponent();
        }
        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            // Извлекаем имя, фамилию и номер группы из текстовых полей
            string name = NameTextBox.Text.Trim();
            string surname = SurnameTextBox.Text.Trim();
            string groupNumber = GroupNumberTextBox.Text.Trim();

            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(groupNumber))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Добавляем пользователя в файл
            using (StreamWriter file = new StreamWriter("StudentAcounts.txt", true))
            {
                // Записываем информацию о пользователе в файл, разделяя ее запятой и добавляя новую строку
                file.WriteLine(name + "," + surname + "," + groupNumber + Environment.NewLine);
            }

            // Очищаем текстовые поля и обновляем список пользователей
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            GroupNumberTextBox.Clear();
            UpdateUserList();
        }

        private void UpdateUserList()
        {
            // Очищаем список пользователей
            UsersTextBox.Clear();

            // Читаем все строки из файла и добавляем их в список пользователей
            if (File.Exists("StudentAcounts.txt"))
            {
                using (StreamReader file = new StreamReader("StudentAcounts.txt"))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        UsersTextBox.AppendText(line + Environment.NewLine);
                    }
                }
            }
        }
    }
}

