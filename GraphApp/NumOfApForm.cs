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
    public partial class NumOfApForm : Form
    {
        public NumOfApForm()
        {
            InitializeComponent();
        }

        private void NumOfApTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) // Вводятся только числа
                e.Handled = true;

            if(e.KeyChar == (char)Keys.Back && NumOfApTextBox.SelectionStart != 0 && 
                NumOfApTextBox.Text != "") // Удаление по нажатию backspace
            {
                NumOfApTextBox.Text = NumOfApTextBox.Text.Substring(0, NumOfApTextBox.Text.Length - 1);
                NumOfApTextBox.SelectionStart = NumOfApTextBox.Text.Length;
            }
        }

        private void NumOfApBackButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show(); // Возвращаемся в главное меню
            Hide();
        }

        private void NumOfApForm_Load(object sender, EventArgs e)
        {
            NumOfApMatrixButton.Enabled = false; // Блокируем кнопку перехода к матрице
        }

        private void NumOfApTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (NumOfApTextBox.Text != "")
                NumOfApMatrixButton.Enabled = true; // Разблокировали кнопку
            else
                NumOfApMatrixButton.Enabled = false; // Заблокировали кнопку

            
        }

        private void NumOfApMatrixButton_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (Convert.ToInt32(NumOfApTextBox.Text) < 2)
            {
                MessageBox.Show("Вы ввели слишком маленькое число! \nНа вход может приниматься от 2 до 9 вершин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }

            if (Convert.ToInt32(NumOfApTextBox.Text) > 9)
            {
                MessageBox.Show("Вы ввели слишком большое число! \nНа вход может приниматься от 2 до 9 вершин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }

            if (ok)
            {
                MatrixForm matrixForm = new MatrixForm();
                matrixForm.Owner = this; // Сделали форму матрицы подчиненной этой
                matrixForm.numberOfApexes = Convert.ToInt32(NumOfApTextBox.Text); // Передали кол-во вершин
                matrixForm.Show();
                Hide();
            }
        }
    }
}
