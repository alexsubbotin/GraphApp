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
    public partial class PracticeChooseForm : Form
    {
        public PracticeChooseForm()
        {
            InitializeComponent();
        }

        private void PracticeChooseForm_Load(object sender, EventArgs e)
        {
            OKButton.Enabled = false;
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

        private void OKButton_Click(object sender, EventArgs e)
        {
            int level = 0; // Уровень сложности

            if (EasyCheckBox.Checked)
                level = 0;
            if (MediumCheckBox.Checked)
                level = 1;
            if (HardCheckBox.Checked)
                level = 2;

            PracticeForm practiceForm = new PracticeForm();
            practiceForm.Owner = this; // Запомнили хозяина
            practiceForm.level = level;
            practiceForm.Show();

            Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            Hide();
        }
    }
}
