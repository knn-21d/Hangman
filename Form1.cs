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
    public partial class Title : Form
    {
        public Title() => InitializeComponent();

        private void Button2_Click(object sender, EventArgs e) // кнопка далее
        {
            HangMain hangMain = new HangMain(); // главное меню
            hangMain.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e) => Application.Exit(); // кнопка закрыть
    }
}
