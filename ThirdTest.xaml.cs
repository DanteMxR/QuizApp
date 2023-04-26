using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для ThirdTest.xaml
    /// </summary>
    public partial class ThirdTest : Window
    {
        public ThirdTest()
        {
            InitializeComponent();
            DataContext = this;
            CurrentQuestion = ThirdTestQuestion.GetNextQuestion();
        }
        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsAnswer1Checked == CurrentQuestion.IsAnswer1Correct &&
                IsAnswer2Checked == CurrentQuestion.IsAnswer2Correct &&
                IsAnswer3Checked == CurrentQuestion.IsAnswer3Correct)
            {
                MessageBox.Show("Правильно!");
                CorrectAnswersCount++;
            }
            else
            {
                MessageBox.Show("Неправильно!");
            }

            AnsweredQuestionsCount++;
            CurrentQuestion = ThirdTestQuestion.GetNextQuestion();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
