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
    public partial class MatrixForm : Form
    {
        public MatrixForm()
        {
            InitializeComponent();
            NumOfApForm numOfApForm = (NumOfApForm)this.Owner; // Запомнили владельца
        }

        public int numberOfApexes; // Кол-во вершин (передается из владельца)

        private void button1_Click(object sender, EventArgs e)
        {
            NumOfApForm numOfApForm = new NumOfApForm();
            numOfApForm.Show(); // Обратно к вводу кол-ва вершин
            Hide();
        }

        private void MatrixForm_Load(object sender, EventArgs e)
        {
            MatrixDGV.RowCount = numberOfApexes; // Задали кол-во строк
            MatrixDGV.ColumnCount = numberOfApexes; // Задали кол-во столбцов
            MatrixDGV.RowHeadersWidth = 50; // Задали ширину столбца с названиями

            MatrixDGV.DefaultCellStyle.Font = new Font("Arial", 90 / numberOfApexes);

            for (int i = 0; i < numberOfApexes; i++)
            {
                MatrixDGV.Columns[i].HeaderText = Convert.ToString(i + 1); // Названия столбцов
                MatrixDGV.Columns[i].Width = 390/numberOfApexes; // Ширина столбцов
                MatrixDGV.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; // Нельзя сортировать

                MatrixDGV.Rows[i].HeaderCell.Value = Convert.ToString(i + 1); // Название строк
                MatrixDGV.Rows[i].Height = 310/numberOfApexes; // Высота строки

                MatrixDGV.Rows[i].Cells[i].Value = "0"; // На главной диагонали нули
                MatrixDGV.Rows[i].Cells[i].ReadOnly = true; // Блокируем главную диагональ
            }
        }

        private void ShowGraphButton_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (ok) // Проверка заполнения матрицы
            {
                for (int i = 0; i < numberOfApexes; i++)
                {
                    for (int j = 0; j < numberOfApexes; j++)
                    {
                        if (Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) == "")
                        {
                            ok = false;
                            break;
                        }

                    }
                }
                if (!ok)
                {
                    MessageBox.Show("Не все ячейки матрицы заполнены!", "Ошибка ввода",
                        MessageBoxButtons.OK);
                }
            }

            if (ok) // Проверка содержимого ячеек
            {
                for (int i = 0; i < numberOfApexes; i++)
                {
                    for (int j = 0; j < numberOfApexes; j++)
                    {
                        if (Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) != "0" &&
                            Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) != "1")
                        {
                            ok = false;

                            break;
                        }

                    }
                }
                if (!ok)
                {
                    MessageBox.Show("Ячейки матрицы могут принимать значения только 0 и 1!", "Ошибка ввода",
                        MessageBoxButtons.OK);
                }
            }

            if (ok) // Анализ на присутствие цикла
            {
                string deleted = ""; // "Удаленные" вершины
                int apCount = numberOfApexes; // Кол-во вершин
                bool flag = true; // Флажок для элементов
                bool cycleFound = true; // Найден ли цикл

                while (apCount > 0) // Пока не просмотрены все вершины
                {
                    cycleFound = true;
                    for (int j = 0; j < numberOfApexes; j++) // Поиск нулевых столбцов
                    {
                        if (!deleted.Contains(j.ToString()))
                        {
                            flag = true; // Флажок поднят
                            for (int i = 0; i < numberOfApexes; i++)
                            {
                                if (!deleted.Contains(i.ToString()))
                                {
                                    if (Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) == "1")
                                    {
                                        flag = false; // Флажок опустился, найдена единица в столбце
                                        break;
                                    }
                                }
                            }
                            if (flag) // Если столбец нулевой
                            {
                                deleted += j + " "; // "Удалили" столбец
                                apCount--; // Уменьшили кол-во вершин
                                cycleFound = false; // Цикла пока не обнаружен
                            }
                        }
                    }

                    if (cycleFound) // Не нашелся ни один нулевой столбец за весь прогон по столбцам
                    {
                        MessageBox.Show("В графе присутствует ориентированный цикл!", "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ok = false;
                        break;
                    }
                }
            }

            if (ok) // Пройдены все проверки
            {
                bool[,] adjMatrix = new bool[numberOfApexes, numberOfApexes]; // Объявили матрицу смежности

                for (int i = 0; i < numberOfApexes; i++) // Заполняем матрицу смежности
                {
                    for (int j = 0; j < numberOfApexes; j++)
                    {
                        if (Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) == "0")
                            adjMatrix[i, j] = false;
                        else
                            adjMatrix[i, j] = true;
                    }
                }

                ShowGraphForm showGraphForm = new ShowGraphForm();
                showGraphForm.Owner = this; // Сделали форму показа графа подчиненной этой
                showGraphForm.numberOfApexes = numberOfApexes; // Передали кол-во вершин
                showGraphForm.adjMatrix = adjMatrix; // Передали матрицу смежности
                showGraphForm.Show();
                Hide();
            }
        }

        private void FillEmtyButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numberOfApexes; i++) // Заполяем пустые ячейки нулями
                for (int j = 0; j < numberOfApexes; j++)
                {
                    if (Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) == "")
                        MatrixDGV.Rows[i].Cells[j].Value = "0";
                }
        }

        private void SaveGraphButton_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (ok) // Проверка заполнения матрицы
            {
                for (int i = 0; i < numberOfApexes; i++)
                {
                    for (int j = 0; j < numberOfApexes; j++)
                    {
                        if (Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) == "")
                        {
                            ok = false;
                            break;
                        }

                    }
                }
                if (!ok)
                {
                    MessageBox.Show("Не все ячейки матрицы заполнены!", "Ошибка ввода",
                        MessageBoxButtons.OK);
                }
            }

            if (ok) // Проверка содержимого ячеек
            {
                for (int i = 0; i < numberOfApexes; i++)
                {
                    for (int j = 0; j < numberOfApexes; j++)
                    {
                        if (Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) != "0" &&
                            Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) != "1")
                        {
                            ok = false;

                            break;
                        }

                    }
                }
                if (!ok)
                {
                    MessageBox.Show("Ячейки матрицы могут принимать значения только 0 и 1!", "Ошибка ввода",
                        MessageBoxButtons.OK);
                }
            }

            if (ok) // Анализ на присутствие цикла
            {
                string deleted = ""; // "Удаленные" вершины
                int apCount = numberOfApexes; // Кол-во вершин
                bool flag = true; // Флажок для элементов
                bool cycleFound = true; // Найден ли цикл

                while (apCount > 0) // Пока не просмотрены все вершины
                {
                    cycleFound = true;
                    for (int j = 0; j < numberOfApexes; j++) // Поиск нулевых столбцов
                    {
                        if (!deleted.Contains(j.ToString()))
                        {
                            flag = true; // Флажок поднят
                            for (int i = 0; i < numberOfApexes; i++)
                            {
                                if (!deleted.Contains(i.ToString()))
                                {
                                    if (Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) == "1")
                                    {
                                        flag = false; // Флажок опустился, найдена единица в столбце
                                        break;
                                    }
                                }
                            }
                            if (flag) // Если столбец нулевой
                            {
                                deleted += j + " "; // "Удалили" столбец
                                apCount--; // Уменьшили кол-во вершин
                                cycleFound = false; // Цикла пока не обнаружен
                            }
                        }
                    }

                    if (cycleFound) // Не нашелся ни один нулевой столбец за весь прогон по столбцам
                    {
                        MessageBox.Show("В графе присутствует ориентированный цикл!", "Ошибка ввода",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ok = false;
                        break;
                    }
                }
            }

            if (ok) // Пройдены все проверки
            {
                bool[,] adjMatrix = new bool[numberOfApexes, numberOfApexes]; // Объявили матрицу смежности

                for (int i = 0; i < numberOfApexes; i++) // Заполняем матрицу смежности
                {
                    for (int j = 0; j < numberOfApexes; j++)
                    {
                        if (Convert.ToString(MatrixDGV.Rows[i].Cells[j].Value) == "0")
                            adjMatrix[i, j] = false;
                        else
                            adjMatrix[i, j] = true;
                    }
                }


                ChooseLevelForm chooseLevelForm = new ChooseLevelForm();
                chooseLevelForm.Owner = this; // Запомнили хозяина
                chooseLevelForm.adjMatrix = adjMatrix; // Передали матрицу смежности
                chooseLevelForm.Show();
            }
        }

        private void MatrixForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Выход из программы
        }
    }
}
