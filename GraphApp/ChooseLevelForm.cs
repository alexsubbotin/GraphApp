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
    public partial class ChooseLevelForm : Form
    {
        public ChooseLevelForm()
        {
            InitializeComponent();

            MatrixForm matrixForm = (MatrixForm)this.Owner; // Запомнили хозяина
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EasyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EasyCheckBox.Checked)
            {
                MediumCheckBox.Checked = false;
                HardCheckBox.Checked = false;
                OKButton.Enabled = true;
            }
        }

        private void MediumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MediumCheckBox.Checked)
            {
                EasyCheckBox.Checked = false;
                HardCheckBox.Checked = false;
                OKButton.Enabled = true;
            }
        }

        private void HardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HardCheckBox.Checked)
            {
                EasyCheckBox.Checked = false;
                MediumCheckBox.Checked = false;
                OKButton.Enabled = true;
            }
        }

        public bool[,] adjMatrix; // Матрица смежности (передается из хозяина)
        private void OKButton_Click(object sender, EventArgs e)
        {
            int level = 0; // Уровень сложности

            if (EasyCheckBox.Checked)
                level = 0;
            if (MediumCheckBox.Checked)
                level = 1;
            if (HardCheckBox.Checked)
                level = 2;

            Controller.GraphInput(adjMatrix, level); // Записали граф в БД

            MessageBox.Show("Граф успешно добавлен в базу данных практики! \nТеперь этот граф модет встретиться Вам при генерации",
                "Успешное добавление", MessageBoxButtons.OK);

            Close();
        }

        private void ChooseLevelForm_Load(object sender, EventArgs e)
        {
            OKButton.Enabled = false;
        }
    }
}
