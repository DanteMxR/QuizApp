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
    public class ThirdTestQuestion
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public bool IsAnswer1Correct { get; set; }
        public bool IsAnswer2Correct { get; set; }
        public bool IsAnswer3Correct { get; set; }

        private static readonly Random Random = new Random();
        public static readonly ThirdTestQuestion[] Questions =
        {
            new ThirdTestQuestion
            {
                QuestionText = "Какой будет минимальная скорость, с которой будет передан файл? Передача данных заняла 4 мин. За это время был передан файл размером 256 байт.",
                Answers = new[] { "16 бит/с", "18 бит/с", "8 бит/с"},
                IsAnswer3Correct = true
            },
            new ThirdTestQuestion
            {
                QuestionText = "Название системы связанных между собой компьютеров, которые расположены в одном помещении",
                Answers = new[] { "локальной сетью", "глобальной сетью", "провайдерами"},
                IsAnswer1Correct = true
            },
            new ThirdTestQuestion
            {
                QuestionText = "Переведите двоичное число 1010101 в десятичный вид",
                Answers = new[] { "8510", "5510", "6510"},
                IsAnswer1Correct = true
            },
                 new ThirdTestQuestion
            {
                QuestionText = "При сохранении карты сети в файл, какое она получает расширение?",
                Answers = new[] { ".avi", ".ndf", ".doc"},
                IsAnswer2Correct = true
            },
                 new ThirdTestQuestion
            {
                QuestionText = "Какие носители информации виртуальная машина поддерживает (видит)?",
                Answers = new[] { "только жёсткий диск и компакт диск", "только флоппи-дискету, компакт диск и USB флешку", "флоппи-дискету, жёсткий диск, компакт диск, USB флешку"},
                IsAnswer3Correct = true
            },
                 new ThirdTestQuestion
            {
                QuestionText = "Что быстрее и проще – установить или клонировать ОС Windows",
                Answers = new[] { "клонировать", "время установки ОС и время клонирования ОС одинаково", "установить"},
                IsAnswer1Correct = true
            },
                 new ThirdTestQuestion
            {
                QuestionText = "Какую функциональную клавишу необходимо нажать для входа в BIOS виртуальной машины и установки там загрузки виртуальной машины с CD-ROM, т.е. выполнения в БИОСе команды Boot-CD ROM Drive?",
                Answers = new[] { "F5", "F2", "F3"},
                IsAnswer2Correct = true
            },
                 new ThirdTestQuestion
            {
                QuestionText = "Какой из видов доступа к ресурсам дает более серьёзное разграничение прав пользователей?",
                Answers = new[] { "удаленный доступ", "простой доступ", "расширенный доступ"},
                IsAnswer3Correct = true
            },
                 new ThirdTestQuestion
            {
                QuestionText = "Укажите на неверный ответ",
                Answers = new[] { "учетную запись Гость можно отключить или удалить", "запись Гость не требует ввода пароля и по умолчанию блокирована", "гость не может устанавливать или удалять программы"},
                IsAnswer1Correct = true
            },
                 new ThirdTestQuestion
            {
                QuestionText = "Найдите правильный ответ",
                Answers = new[] { "сетевой диск Z может быть только один", "сетевой диск Z является общим для всех ПК", "сетевой диск Z является общим только для администраторов сети"},
                 IsAnswer2Correct = true
            },
        };

        private static int _currentQuestionIndex = -1;

        public static ThirdTestQuestion GetNextQuestion()
        {
            _currentQuestionIndex = (_currentQuestionIndex + 1) % Questions.Length;
            return Questions[_currentQuestionIndex];
        }
    }

    public partial class ThirdTest : Window, INotifyPropertyChanged
    {
        private ThirdTestQuestion _currentQuestion;
        public ThirdTestQuestion CurrentQuestion
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
                if (_answeredQuestionsCount == ThirdTestQuestion.Questions.Length)
                {
                    MessageBox.Show($"Вы ответили правильно на {CorrectAnswersCount} из {ThirdTestQuestion.Questions.Length} вопросов!");
                    if (CorrectAnswersCount >= 9)
                    {
                        MessageBox.Show("Молодец оценка 5");
                        string newRecord = "5";
                        string[] lines = System.IO.File.ReadAllLines("Authorized.txt");

                        string lastLine = lines[lines.Length - 1];

                        string updatedLastLine = $"{lastLine}, {newRecord}";

                        lines[lines.Length - 1] = updatedLastLine;

                        System.IO.File.WriteAllLines("Authorized.txt", lines);
                        this.Close();
                    }
                    else if (CorrectAnswersCount >= 7)
                    {
                        MessageBox.Show("Молодец оценка 4");
                        string newRecord = "4";
                        string[] lines = System.IO.File.ReadAllLines("Authorized.txt");

                        string lastLine = lines[lines.Length - 1];

                        string updatedLastLine = $"{lastLine}, {newRecord}";

                        lines[lines.Length - 1] = updatedLastLine;

                        System.IO.File.WriteAllLines("Authorized.txt", lines);
                        this.Close();
                    }
                    else if (CorrectAnswersCount >= 5)
                    {
                        MessageBox.Show("оценка 3, надо подучить");
                        string newRecord = "3";
                        string[] lines = System.IO.File.ReadAllLines("Authorized.txt");

                        string lastLine = lines[lines.Length - 1];

                        string updatedLastLine = $"{lastLine}, {newRecord}";

                        lines[lines.Length - 1] = updatedLastLine;

                        System.IO.File.WriteAllLines("Authorized.txt", lines);
                        this.Close();
                    }
                    else if (CorrectAnswersCount >= 3)
                    {
                        MessageBox.Show("Плохо! оценка 2");
                        string newRecord = "2";
                        string[] lines = System.IO.File.ReadAllLines("Authorized.txt");

                        string lastLine = lines[lines.Length - 1];

                        string updatedLastLine = $"{lastLine}, {newRecord}";

                        lines[lines.Length - 1] = updatedLastLine;

                        System.IO.File.WriteAllLines("Authorized.txt", lines);
                        this.Close();
                    }
                    else if (CorrectAnswersCount >= 0)
                    {
                        MessageBox.Show("Ужасно!оценка 1");
                        string newRecord = "1";
                        string[] lines = System.IO.File.ReadAllLines("Authorized.txt");

                        string lastLine = lines[lines.Length - 1];

                        string updatedLastLine = $"{lastLine}, {newRecord}";

                        lines[lines.Length - 1] = updatedLastLine;

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