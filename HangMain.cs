using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Hangman
{
    public partial class HangMain : Form
    {
        int difficulty; // сложность
        int tries; // использовано попыток
        string word; // текущее слово
        List<char> guessed; // список использованных букв
        int winsCount; // счётчик побед
        int lossesCount; // счётчик поражений
        bool gameOver; // состояние завершения игры
        public HangMain()
        {
            this.KeyPreview = true; // включает считывание с клавиатуры
            try // попытка считать файл со счётом
            { 
                string score = File.ReadAllText(@"./score.txt"); // строка из файла
                string[] winsLosses = score.Split('\n'); // обработана в массив
                winsCount = Int32.Parse(winsLosses[0]);
                lossesCount = Int32.Parse(winsLosses[1]);
            }
            catch
            {
                winsCount = 0;
                lossesCount = 0;
                writeScore(); // если файл не удалось считать, он перезаписывается/создаётся функцией writeScore
            }
            InitializeComponent();
            losses.Text = $"Losses: {lossesCount}";
            wins.Text = $"Wins: {winsCount}";
            this.FormClosing += Confirmation; // вызывает форму подтверждения*
            this.FormClosed += HangMain_FormClosed; // закрытие формы вызывает выход из приложения*
        }

        private void HangMain_FormClosed(object sender, FormClosedEventArgs e) // *закрытие формы вызывает выход из приложения
        {
            Application.Exit();
        }

        private void Confirmation(object sender, CancelEventArgs e) // *подтверждение выхода
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close(); // закрывает форму и вызывает соответствующие события, приводящие к выходу

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) // о программе
        {
            About about = new About();
            about.ShowDialog();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) // новая игра
        {
            tries = 0;
            difficulty = 7;
            gameOver = false;
            guessed = new List<char>();
            string[] dictionary = File.ReadAllLines(@"./dictionary.txt"); // словарь
            Random random = new Random();
            word = dictionary[random.Next(0, dictionary.Length)];
            current_line.Text = ""; // сброс лейбла
            display.Image = Image.FromFile($@"./display/{tries}.png"); // сброс дисплея с картинкой
            for (int i = 0; i < word.Length; i++)
            {
                current_line.Text += "*"; // заполнение лейбла неотгаданными буквами
            }
            used.Text = "Used:";
            if (word.Contains('Ё'))
            {
                word = word.Replace('Ё', 'Е');
            }
            
            check(word[0]); // открытие первой буквы
            check(word[word.Length - 1]); // открытие последней буквы
        }
        public bool open(char guess) // функция проверки наличия буквы
        {
            bool found = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (guess == word[i])
                {
                    found = true;
                    break;
                }
            }
            return found;
        }
        public void let(object sender)
        {
            if (word == null || gameOver) // если игра в процессе
            {
                return;
            }
            char guess = char.Parse(((Button)sender).Text); // считывание нажатие кнопки по тексту на ней
            check(guess);
        }

        private void check(char guess) // функция открывает букву
        {
            if (!gameOver)
            {
                if (guessed.Contains(guess))
                {

                }
                else if (open(guess))
                {
                    char[] chars = new char[word.Length]; // промежуточный массив символов главной строки
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == guess)
                        {
                            chars[i] = guess;
                        }
                        else
                        {
                            chars[i] = current_line.Text[i];
                        }
                    }

                    current_line.Text = new string(chars);
                    guessed.Add(guess);
                    used.Text += $" {guess} ";
                }
                else
                {
                    guessed.Add(guess);
                    tries++;
                    display.Image = Image.FromFile($@"./display/{tries}.png"); // смена картинки
                }
                if (current_line.Text == word)
                {
                    winsCount++;
                    writeScore();
                    gameOver = true;
                    Endgame endgame = new Endgame(); // форма с сообщением о победе
                    endgame.label2.Text = "You win!";
                    endgame.ShowDialog();
                }
                else if (tries >= difficulty)
                {
                    lossesCount++;
                    current_line.Text = word;
                    writeScore();
                    gameOver = true;
                    Endgame endgame = new Endgame(); // либо о поражении
                    endgame.label2.Text = "You lose";
                    endgame.ShowDialog();
                }
            }
        }

        private void button_Click(object sender, EventArgs e) // объединённый метод кнопок
        {
            let(sender);
        }

        private void keyPressHandler(object sender, KeyPressEventArgs e) // функция считывания с клавиатуры
        {
            char c = e.KeyChar; // нажатая клавиша
            if (c.CompareTo('А') >= 0 && c.CompareTo('я') <= 0) // проверка букв внутри диапазонов чаркодов
            {

                if (word != null && !gameOver) // если игра в процессе
                {
                    char guess = char.Parse(c.ToString().ToUpper()); // нажатая клавиша
                    if (guess == 'Ё')
                    {
                        check('Е');
                    }
                    else
                    {
                        check(guess); // открыть букву
                    }
                }
            }
        }
        private void resetScoreToolStripMenuItem_Click(object sender, EventArgs e) // функция сброса счёта
        {
            winsCount = 0;
            lossesCount = 0;
            writeScore();
        }

        private void writeScore() // функция записи счёта
        {
            using (StreamWriter writer = new StreamWriter(@".\score.txt", false)) // сохранение счёта для следующих запусков, false для перезаписи
            {
                writer.WriteLine(winsCount);
                writer.WriteLine(lossesCount);
            }
            this.losses.Text = $"Losses: {lossesCount}";
            this.wins.Text = $"Wins: {winsCount}";
        }
    }

}
