using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Выход из программы
        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            PracticeChooseForm practiceChooseForm = new PracticeChooseForm();
            practiceChooseForm.Show();
            Hide();
        }

        private void WorkButton_Click(object sender, EventArgs e)
        {
            NumOfApForm numOfApForm = new NumOfApForm();
            numOfApForm.Show(); // Переходим к другой форме
            Hide();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Выход из программы
        }
    }
}
