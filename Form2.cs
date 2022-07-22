using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class HangMain : Form
    {
        public HangMain()
        {
            InitializeComponent();
            this.FormClosing += App_Closing; // вызывает функцию выхода из приложения при закрытии формы
        }
        private void App_Closing(object sender, CancelEventArgs e) => Application.Exit(); // функция выхода из приложения
    }

}
