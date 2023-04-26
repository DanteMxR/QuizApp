using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.WebRequestMethods;

namespace Курсовая_Прод
{
    public class TestQuestion
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public bool IsAnswer1Correct { get; set; }
        public bool IsAnswer2Correct { get; set; }
        public bool IsAnswer3Correct { get; set; }

        private static readonly Random Random = new Random();
        public static readonly TestQuestion[] Questions =
        {
            new TestQuestion
            {
                QuestionText = "Что такое глобальная сеть?",
                Answers = new[] { "система, связанных между собой локальных сетей", "система, связанных между собой компьютеров", "система, связанных между собой локальных сетей и компьютеров отдельных пользователей"},
                IsAnswer3Correct = true
            },
            new TestQuestion
            {
                QuestionText = "Что необходимо для соединения двух компьютеров по телефонным линиям связи?",
                Answers = new[] { "телефон, модем и специальное программное обеспечение", "Модем", "по модему на каждом компьютере и специальное программное обеспечение"},
                IsAnswer1Correct = true
            },
            new TestQuestion
            {
                QuestionText = "Какая из приведенных схем соединения компьютеров представляет собой замкнутую цепочку",
                Answers = new[] { "Шина", "Кольцо", "Звезда"},
                IsAnswer2Correct = true
            },
                 new TestQuestion
            {
                QuestionText = "Кабель, обеспечивающий скорость передачи данных до 10 Мбит/с",
                Answers = new[] { "Коаксиальный", "оптоволокно", "витая пара"},
                IsAnswer3Correct = true
            },
                 new TestQuestion
            {
                QuestionText = "Топология самого большого размер сети",
                Answers = new[] { "Звезда", "Кольцо", "Шина"},
                IsAnswer2Correct = true
            },
                 new TestQuestion
            {
                QuestionText = "Топология самого маленького размера сети",
                Answers = new[] { "Звезда", "Кольцо", "Шина"},
                IsAnswer3Correct = true
            },
                 new TestQuestion
            {
                QuestionText = "Название топологии компьютерной сети, в которой все компьютеры сети присоединены к центральному узлу",
                Answers = new[] { "Звезда", "Шина", "Кольцо"},
                IsAnswer1Correct = true
            },
                 new TestQuestion
            {
                QuestionText = "Что такое протокол?",
                Answers = new[] { "способность компьютера посылать файлы через каналы передачи информации", "устройство для работы локальной сети", "стандарт передачи данных через компьютерную сеть"},
                IsAnswer3Correct = true
            },
                 new TestQuestion
            {
                QuestionText = "Самым высоким уровнем безопасности обладает",
                Answers = new[] { "Звезда", "Кольцо", "Шина"},
                IsAnswer1Correct = true
            },
                 new TestQuestion
            {
                QuestionText = "Что используют для общего доступа пользователей сети?",
                Answers = new[] { "рабочая станция", "сервер", "клиент"},
                 IsAnswer2Correct = true
            },
        };

        private static int _currentQuestionIndex = -1;

        public static TestQuestion GetNextQuestion()
        {
            _currentQuestionIndex = (_currentQuestionIndex + 1) % Questions.Length;
            return Questions[_currentQuestionIndex];
        }
    }

    public partial class FirstTest : Window, INotifyPropertyChanged
    {
        private TestQuestion _currentQuestion;
        public TestQuestion CurrentQuestion
        {
            get { return _currentQuestion; }
            set
            {
                _currentQuestion = value;
                OnPropertyChanged("Question");
                OnPropertyChanged("Answer1");
                OnPropertyChanged("Answer2");
                OnPropertyChanged("Answer3");
                OnPropertyChanged("Answer4");
                OnPropertyChanged("Answer5");
                OnPropertyChanged("Answer6");
                OnPropertyChanged("Answer7");
                OnPropertyChanged("Answer8");
                OnPropertyChanged("Answer9");
                OnPropertyChanged("Answer10");
            }
        }

        public string Question
        {
            get { return CurrentQuestion.QuestionText; }
        }

        public string Answer1
        {
            get { return CurrentQuestion.Answers[0]; }
        }

        public string Answer2
        {
            get { return CurrentQuestion.Answers[1]; }
        }

        public string Answer3
        {
            get { return CurrentQuestion.Answers[2]; }
        }

        public string Answer4
        {
            get { return CurrentQuestion.Answers[0]; }
        }
        public string Answer5
        {
            get { return CurrentQuestion.Answers[1]; }
        }
        public string Answer6
        {
            get { return CurrentQuestion.Answers[2]; }
        }
        public string Answer7
        {
            get { return CurrentQuestion.Answers[2]; }
        }
        public string Answer8
        {
            get { return CurrentQuestion.Answers[2]; }
        }

        public string Answer9
        {
            get { return CurrentQuestion.Answers[2]; }
        }
        public string Answer10
        {
            get { return CurrentQuestion.Answers[2]; }
        }

        private bool _isAnswer1Checked;
        public bool IsAnswer1Checked
        {
            get { return _isAnswer1Checked; }
            set
            {
                _isAnswer1Checked = value;
                OnPropertyChanged("IsAnswer1Checked");
            }
        }

        private bool _isAnswer2Checked;
        public bool IsAnswer2Checked
        {
            get { return _isAnswer2Checked; }
            set
            {
                _isAnswer2Checked = value;
                OnPropertyChanged("IsAnswer2Checked");
            }
        }

        private bool _isAnswer3Checked;
        public bool IsAnswer3Checked
        {
            get { return _isAnswer3Checked; }
            set
            {
                _isAnswer3Checked = value;
                OnPropertyChanged("IsAnswer3Checked");
            }
        }
        public bool IsAnswer4Checked
        {
            get { return _isAnswer3Checked; }
            set
            {
                _isAnswer3Checked = value;
                OnPropertyChanged("IsAnswer4Checked");
            }
        }

        public bool IsAnswer5Checked
        {
            get { return _isAnswer3Checked; }
            set
            {
                _isAnswer3Checked = value;
                OnPropertyChanged("IsAnswer5Checked");
            }
        }

        public bool IsAnswer6Checked
        {
            get { return _isAnswer3Checked; }
            set
            {
                _isAnswer3Checked = value;
                OnPropertyChanged("IsAnswer6Checked");
            }
        }

        public bool IsAnswer7Checked
        {
            get { return _isAnswer3Checked; }
            set
            {
                _isAnswer3Checked = value;
                OnPropertyChanged("IsAnswer7Checked");
            }
        }
        public bool IsAnswer8Checked
        {
            get { return _isAnswer3Checked; }
            set
            {
                _isAnswer3Checked = value;
                OnPropertyChanged("IsAnswer8Checked");
            }
        }
        public bool IsAnswer9Checked
        {
            get { return _isAnswer3Checked; }
            set
            {
                _isAnswer3Checked = value;
                OnPropertyChanged("IsAnswer9Checked");
            }
        }
        public bool IsAnswer10Checked
        {
            get { return _isAnswer3Checked; }
            set
            {
                _isAnswer3Checked = value;
                OnPropertyChanged("IsAnswer10Checked");
            }
        }

        private int _answeredQuestionsCount;
        public int AnsweredQuestionsCount
        {
            get { return _answeredQuestionsCount; }
            set
            {
                _answeredQuestionsCount = value;
                OnPropertyChanged("AnsweredQuestionsCount");
                if (_answeredQuestionsCount == TestQuestion.Questions.Length)
                {
                    MessageBox.Show($"Вы ответили правильно на {CorrectAnswersCount} из {TestQuestion.Questions.Length} вопросов!");
                    if (CorrectAnswersCount >= 9)
                    {
                        MessageBox.Show("Молодец оценка 5");
                        string newRecord = "5";
                        string[] lines = System.IO.File.ReadAllLines("Authorized.txt");

                        // Получаем последнюю строку
                        string lastLine = lines[lines.Length - 1];

                        // Объединяем последнюю строку и новую запись через запятую
                        string updatedLastLine = $"{lastLine}, {newRecord}";

                        // Заменяем последнюю строку в массиве
                        lines[lines.Length - 1] = updatedLastLine;

                        // Записываем все строки обратно в файл
                        System.IO.File.WriteAllLines("Authorized.txt", lines);
                        this.Close();
                    }
                    else if (CorrectAnswersCount >= 7)
                    {
                        MessageBox.Show("Молодец оценка 4");
                        string newRecord = "4";
                        string[] lines = System.IO.File.ReadAllLines("Authorized.txt");

                        // Получаем последнюю строку
                        string lastLine = lines[lines.Length - 1];

                        // Объединяем последнюю строку и новую запись через запятую
                        string updatedLastLine = $"{lastLine}, {newRecord}";

                        // Заменяем последнюю строку в массиве
                        lines[lines.Length - 1] = updatedLastLine;

                        // Записываем все строки обратно в файл
                        System.IO.File.WriteAllLines("Authorized.txt", lines);
                        this.Close();
                    }
                    else if (CorrectAnswersCount >= 5)
                    {
                        MessageBox.Show("оценка 3, надо подучить");
                        string newRecord = "3";
                        string[] lines = System.IO.File.ReadAllLines("Authorized.txt");

                        // Получаем последнюю строку
                        string lastLine = lines[lines.Length - 1];

                        // Объединяем последнюю строку и новую запись через запятую
                        string updatedLastLine = $"{lastLine}, {newRecord}";

                        // Заменяем последнюю строку в массиве
                        lines[lines.Length - 1] = updatedLastLine;

                        // Записываем все строки обратно в файл
                        System.IO.File.WriteAllLines("Authorized.txt", lines);
                        this.Close();
                    }
                    else if (CorrectAnswersCount >= 3)
                    {
                        MessageBox.Show("Плохо! оценка 2");
                        string newRecord = "2";
                        string[] lines = System.IO.File.ReadAllLines("Authorized.txt");

                        // Получаем последнюю строку
                        string lastLine = lines[lines.Length - 1];

                        // Объединяем последнюю строку и новую запись через запятую
                        string updatedLastLine = $"{lastLine}, {newRecord}";

                        // Заменяем последнюю строку в массиве
                        lines[lines.Length - 1] = updatedLastLine;

                        // Записываем все строки обратно в файл
                        System.IO.File.WriteAllLines("Authorized.txt", lines);
                        this.Close();
                    }
                    else if (CorrectAnswersCount >= 0)
                    {
                        MessageBox.Show("Ужасно!оценка 1");
                        string newRecord = "1";
                        string[] lines = System.IO.File.ReadAllLines("Authorized.txt");

                        // Получаем последнюю строку
                        string lastLine = lines[lines.Length - 1];

                        // Объединяем последнюю строку и новую запись через запятую
                        string updatedLastLine = $"{lastLine}, {newRecord}";

                        // Заменяем последнюю строку в массиве
                        lines[lines.Length - 1] = updatedLastLine;

                        // Записываем все строки обратно в файл
                        System.IO.File.WriteAllLines("Authorized.txt", lines);
                        this.Close();
                    }
                }
            }
        }
        private int _correctAnswersCount;
        public int CorrectAnswersCount
        {
            get { return _correctAnswersCount; }
            set
            {
                _correctAnswersCount = value;
                OnPropertyChanged("CorrectAnswersCount");
            }
        }
    }
}
