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
    /// Логика взаимодействия для MasterList.xaml
    /// </summary>
    public partial class MasterList : Window
    {
        public MasterList()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("Authorized.txt"))
            {
                // Создаем таблицу
                System.Data.DataTable table = new System.Data.DataTable();
                table.Columns.Add("Имя");
                table.Columns.Add("Фамилия");
                table.Columns.Add("Группа");
                table.Columns.Add("1 Тест");
                table.Columns.Add("2 Тест");
                table.Columns.Add("3 Тест");

                // Читаем данные из файла и добавляем их в таблицу
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    table.Rows.Add(values);
                }

                // Устанавливаем источник данных для таблицы
                dataGrid.ItemsSource = table.DefaultView;
            }
        }
    }
}
