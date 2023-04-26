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
    /// Логика взаимодействия для SecondTest.xaml
    /// </summary>
    public partial class SecondTest : Window
    {
        public SecondTest()
        {
            InitializeComponent();
            DataContext = this;
            CurrentQuestion = SecondTestQestion.GetNextQuestion();
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
            CurrentQuestion = SecondTestQestion.GetNextQuestion();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}