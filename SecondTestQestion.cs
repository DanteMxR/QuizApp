using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Курсовая_Прод
{
    public class SecondTestQestion
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public bool IsAnswer1Correct { get; set; }
        public bool IsAnswer2Correct { get; set; }
        public bool IsAnswer3Correct { get; set; }

        private static readonly Random Random = new Random();
        public static readonly SecondTestQestion[] Questions =
        {
            new SecondTestQestion
            {
                QuestionText = "Видами компьютерных сетей является",
                Answers = new[] { "Личные, локальные, корпоративные, территориальные, глобальные", "Персональные, спутниковые, 4-G", "Персональные, локальные, корпоративные, городские, глобальные"},
                IsAnswer3Correct = true
            },
            new SecondTestQestion
            {
                QuestionText = "Размер пакетов? которыми передаются данные в сети",
                Answers = new[] { "1,5 Кб", "1,5 Гб", "1,5 Байт"},
                IsAnswer1Correct = true
            },
            new SecondTestQestion
            {
                QuestionText = "Видами компьютерных сетей является",
                Answers = new[] { "Персональные, локальные, корпоративные, городские, глобальные", "Личные, локальные, корпоративные, территориальные, глобальные", "Персональные, спутниковые, 4-G"},
                IsAnswer1Correct = true
            },
                 new SecondTestQestion
            {
                QuestionText = "Два типа линии связи",
                Answers = new[] { "Спутниковые и Глонасс", "Беспроводные и проводные", "Беспроводные и глобальные"},
                IsAnswer2Correct = true
            },
                 new SecondTestQestion
            {
                QuestionText = "Максимальное количество компьютеров соединяемых ЛВС",
                Answers = new[] { "20 компьютеров", "100 компьютеров", "1000 компьютеров"},
                IsAnswer3Correct = true
            },
                 new SecondTestQestion
            {
                QuestionText = "Для каких целей применяют коммутаторы или свитчи?",
                Answers = new[] { "объединения компьютеров в единую сеть", "усиления сигнала", "для выбора маршрута"},
                IsAnswer1Correct = true
            },
                 new SecondTestQestion
            {
                QuestionText = "Единица измерения пропускной способности канала информации",
                Answers = new[] { "Герцах", "Мбит/с", "Секундах"},
                IsAnswer2Correct = true
            },
                 new SecondTestQestion
            {
                QuestionText = "Чем должен обладать компьютер, подключенный к локальной сети",
                Answers = new[] { "принтер", "сканер", "модем"},
                IsAnswer3Correct = true
            },
                 new SecondTestQestion
            {
                QuestionText = "Название системы связанных между собой компьютеров, которые расположены на большом удалении друг от друга",
                Answers = new[] { "глобальной сетью", "локальной сетью", "провайдерами"},
                IsAnswer1Correct = true
            },
                 new SecondTestQestion
            {
                QuestionText = "Что такое система технических средств и среда распространения сигналов для передачи сообщений от источника к приемнику?",
                Answers = new[] { "компьютерная сеть", "канал связи", "сообщение"},
                 IsAnswer2Correct = true
            },
        };

        private static int _currentQuestionIndex = -1;

        public static SecondTestQestion GetNextQuestion()
        {
            _currentQuestionIndex = (_currentQuestionIndex + 1) % Questions.Length;
            return Questions[_currentQuestionIndex];
        }
    }

    public partial class SecondTest : Window, INotifyPropertyChanged
    {
        private SecondTestQestion _currentQuestion;
        public SecondTestQestion CurrentQuestion
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
            get { return CurrentQuestion.Answers[2]; }
        }
        public string Answer5
        {
            get { return CurrentQuestion.Answers[2]; }
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
                if (_answeredQuestionsCount == SecondTestQestion.Questions.Length)
                {
                    MessageBox.Show($"Вы ответили правильно на {CorrectAnswersCount} из {SecondTestQestion.Questions.Length} вопросов!");
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
                        MessageBox.Show("Надо подучить оценка 3");
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
