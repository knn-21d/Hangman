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
            this.FormClosing += Confirmation; // вызывает форму подтверждения*
            this.FormClosed += HangMain_FormClosed; // закрытие формы вызывает выход из приложения*
        }

        private void HangMain_FormClosed(object sender, FormClosedEventArgs e) // *закрытие формы вызывает выход из приложения
        {
            Application.Exit();
        }

        private void Confirmation(object sender, CancelEventArgs e)
        {   
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo); // *подтверждение выхода
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
    }

}
