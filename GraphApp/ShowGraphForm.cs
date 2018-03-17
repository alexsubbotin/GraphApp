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
    public partial class ShowGraphForm : Form
    {
        public ShowGraphForm()
        {
            InitializeComponent();

            MatrixForm matrixForm = (MatrixForm)this.Owner; // Форма матрицы – хозяин этой
        }
        private void ShowGraphForm_Load(object sender, EventArgs e)
        {
            ParallelPicBox.Visible = false; // Скрыли пикчербокс с ЯПФ

            UpdateButton.Visible = false; // Скрываем кнопку обнов ЯПФ
            UpdateButton.Enabled = false; // Блокируем кнопку обнов ЯПФ

            ShowParallelLabel.Visible = false; // Скрываем подпись к кнопке "Обновить"
        }

        private void GoToMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            Hide();
        }

        private void ShowParallelGraphCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowParallelGraphCheckBox.Checked)
            {
                ParallelPicBox.Visible = true; // Отобразили ЯПФ

                UpdateButton.Visible = true; // Показываем кнопку обнов ЯПФ
                UpdateButton.Enabled = true; // Разблокируем кнопку обнов ЯПФ

                ShowParallelLabel.Visible = true; // Показываем подпись к кнопке "Обновить"
            }

            if (!ShowParallelGraphCheckBox.Checked)
            {
                ParallelPicBox.Visible = false; // Скрываем ЯПФ

                UpdateButton.Visible = false; // Скрываем кнопку обнов ЯПФ
                UpdateButton.Enabled = false; // Блокируем кнопку обнов ЯПФ

                ShowParallelLabel.Visible = false; // Скрываем подпись к кнопке "Обновить"
            }
        }

        public int numberOfApexes; // Кол-во вершин (передается из хозяина)
        public bool[,] adjMatrix; // МАтрица смежности (передается из хозяина)

        Random rnd = new Random(); // Датчик случайных чисел
        private void CasualPicBox_Paint(object sender, PaintEventArgs e) // РИСУЕМ ОБЫЧНЫЙ ГРАФ
        {
            Graphics g = e.Graphics; // Переменная, отвечающая за рисование

            Pen apPen = new Pen(Color.DarkBlue); // Ручка для вершин
            Brush apBrush = new SolidBrush(Color.DarkBlue); // Заливка вершин

            Pen linePen = new Pen(Color.Black, 5); // Ручка для дуги
            linePen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor; // На конце – указатель

            Brush textBrush = new SolidBrush(Color.White); // Цвет названия вершины
            Font textFont = new Font("Arial", 10, FontStyle.Bold); // Шрифт названия вершины

            ApexPos[] apexPosArr = new ApexPos[numberOfApexes]; // Массив вершин


            int k = 0; // Номер вершины
            int picBoxBorder = 510; // Длина стороны квадратного пикчербокса (смещено, на самом деле 716х660)
            // Идем по координате х с безопасным для 9 вершин шагом
            for (int x = 0; x <= picBoxBorder; x += picBoxBorder/((numberOfApexes + 1)/2)) 
            {
                // Значение коорд у выражается из формулы круга (x-255)^2 + (y-255)^2 = 255^2

                double y1 = Math.Sqrt(Math.Pow(picBoxBorder/2, 2) - Math.Pow(x - picBoxBorder/2, 2)); // Считаем первый у (+)
                y1 += picBoxBorder/2;

                g.DrawEllipse(apPen, x, Convert.ToInt32(y1), 20, 20); // Нарисовали вершину
                g.FillEllipse(apBrush, x, Convert.ToInt32(y1), 20, 20); // Залили вершину
                g.DrawString((k + 1).ToString(), textFont, textBrush, x + 4, Convert.ToInt32(y1) + 3); // Вставили текст (номер вершины)
                apexPosArr[k] = new ApexPos(k, x, Convert.ToInt32(y1)); // Записали вершину в массив
                k++;
                if (k == numberOfApexes)
                    break;

                if (x != 0 && x != picBoxBorder) // Если х не на границе (на границе будет одна вершина)
                {
                    double y2 = -Math.Sqrt(Math.Pow(picBoxBorder/2, 2) - Math.Pow(x - picBoxBorder/2, 2)); // Считаем второй у (-)
                    y2 += picBoxBorder/2;

                    g.DrawEllipse(apPen, x, Convert.ToInt32(y2), 20, 20); // Нарисовали вершину
                    g.FillEllipse(apBrush, x, Convert.ToInt32(y2), 20, 20); // Залили вершину
                    g.DrawString((k + 1).ToString(), textFont, textBrush, x + 4, Convert.ToInt32(y2) + 3); // Вставили текст (номер вершины)
                    apexPosArr[k] = new ApexPos(k, x, Convert.ToInt32(y2)); // Записали вершину в массив
                    k++;
                    if (k == numberOfApexes)
                        break;
                }
            }


            for(int i = 0; i < numberOfApexes; i++) // Соединяем вершины
            {
                for(int j = 0; j < numberOfApexes; j++)
                {
                    if (adjMatrix[i, j])
                    {
                        if(apexPosArr[i].X < apexPosArr[j].X && apexPosArr[i].Y < apexPosArr[j].Y) // Если первый выше левее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X + 20, apexPosArr[i].Y + 20,
                                apexPosArr[j].X, apexPosArr[j].Y);
                        }

                        if (apexPosArr[i].X == apexPosArr[j].X && apexPosArr[i].Y < apexPosArr[j].Y) // Если первый над вторым
                        {
                            g.DrawLine(linePen, apexPosArr[i].X + 10, apexPosArr[i].Y + 20,
                                apexPosArr[j].X + 10, apexPosArr[j].Y);
                        }

                        if (apexPosArr[i].X > apexPosArr[j].X && apexPosArr[i].Y < apexPosArr[j].Y) // Если первый выше правее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X, apexPosArr[i].Y + 20,
                                apexPosArr[j].X + 20, apexPosArr[j].Y);
                        }

                        if (apexPosArr[i].X > apexPosArr[j].X && apexPosArr[i].Y == apexPosArr[j].Y) // Если первый правее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X, apexPosArr[i].Y + 10,
                                apexPosArr[j].X + 20, apexPosArr[j].Y + 10);
                        }

                        if (apexPosArr[i].X > apexPosArr[j].X && apexPosArr[i].Y > apexPosArr[j].Y) // Если первый ниже правее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X, apexPosArr[i].Y,
                                apexPosArr[j].X + 20, apexPosArr[j].Y + 20);
                        }

                        if (apexPosArr[i].X == apexPosArr[j].X && apexPosArr[i].Y > apexPosArr[j].Y) // Если первый ниже второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X + 10, apexPosArr[i].Y,
                                apexPosArr[j].X + 10, apexPosArr[j].Y + 20);
                        }

                        if (apexPosArr[i].X < apexPosArr[j].X && apexPosArr[i].Y > apexPosArr[j].Y) // Если первый ниже левее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X + 20, apexPosArr[i].Y,
                                apexPosArr[j].X, apexPosArr[j].Y + 20);
                        }

                        if (apexPosArr[i].X < apexPosArr[j].X && apexPosArr[i].Y == apexPosArr[j].Y) // Если первый левее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X + 20, apexPosArr[i].Y + 10,
                                apexPosArr[j].X, apexPosArr[j].Y + 10);
                        }
                    }
                }
            }
        }

        private void ParallelPicBox_Paint(object sender, PaintEventArgs e) // РИСУЕМ ЯПФ
        {
            Graphics g = e.Graphics; // Переменная, отвечающая за рисование

            Pen apPen = new Pen(Color.DarkBlue); // Ручка для вершин
            Brush apBrush = new SolidBrush(Color.DarkBlue); // Заливка вершин

            Pen linePen = new Pen(Color.Black, 5); // Ручка для дуги
            linePen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor; // На конце – указатель

            Brush textBrush = new SolidBrush(Color.White); // Цвет названия вершины
            Font textFont = new Font("Arial", 10, FontStyle.Bold); // Шрифт названия вершины

            ApexPos[] apexPosArr = new ApexPos[numberOfApexes]; // Массив вершин

            string[] floors = Controller.Floors(adjMatrix); // Получаем массив с ярусами

            int picBoxBorder = 530; // Длина стороны квадратного пикчербокса (смещено, на самом деле 716х660)

            for(int i = 0; i < floors.Length; i++) // Идем по ярусам и рисуем вершины
            {
                string[] apNames = floors[i].Split('&');
                apNames = Controller.Mas(apNames); // Получили массив названий вершин на i ярусе

                int Y = Convert.ToInt32((picBoxBorder / floors.Length) * i); // Получили координату Y для i яруса

                Brush floorsBrush = new SolidBrush(Color.DarkBlue); // Заливка для подписей ярусов
                Font floorsFont = new Font("Arial", 12, FontStyle.Bold);
                g.DrawString(i + " яр.", floorsFont, floorsBrush, 0, Y); // Подписали ярус

                int move = rnd.Next(-picBoxBorder / apNames.Length / 2 + 50, picBoxBorder / apNames.Length / 2 - 20); // Рандомный коэфф сдвига вершины (для избежания наслоения дуг)

                for (int j = 0; j < apNames.Length; j++) // Идем по вершинам
                {
                    
                    int X = Convert.ToInt32((picBoxBorder / apNames.Length) * (j + 0.5)) + move; // Получили координату X для j вершины

                    g.DrawEllipse(apPen, X, Y, 20, 20); // Нарисовали вершину
                    g.FillEllipse(apBrush, X, Y, 20, 20); // Залили вершину
                    g.DrawString(apNames[j], textFont, textBrush, X + 4, Y + 3); // Вставили название вершины

                    apexPosArr[Convert.ToInt32(apNames[j]) - 1] = new ApexPos(Convert.ToInt32(apNames[j]), X, Y); // Записали вершину в массив
                }
            }

            for (int i = 0; i < numberOfApexes; i++) // Соединяем вершины
            {
                for (int j = 0; j < numberOfApexes; j++)
                {
                    if (adjMatrix[i, j])
                    {
                        if (apexPosArr[i].X < apexPosArr[j].X && apexPosArr[i].Y < apexPosArr[j].Y) // Если первый выше левее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X + 20, apexPosArr[i].Y + 20,
                                apexPosArr[j].X, apexPosArr[j].Y);
                        }

                        if (apexPosArr[i].X == apexPosArr[j].X && apexPosArr[i].Y < apexPosArr[j].Y) // Если первый над вторым
                        {
                            g.DrawLine(linePen, apexPosArr[i].X + 10, apexPosArr[i].Y + 20,
                                apexPosArr[j].X + 10, apexPosArr[j].Y);
                        }

                        if (apexPosArr[i].X > apexPosArr[j].X && apexPosArr[i].Y < apexPosArr[j].Y) // Если первый выше правее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X, apexPosArr[i].Y + 20,
                                apexPosArr[j].X + 20, apexPosArr[j].Y);
                        }

                        if (apexPosArr[i].X > apexPosArr[j].X && apexPosArr[i].Y == apexPosArr[j].Y) // Если первый правее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X, apexPosArr[i].Y + 10,
                                apexPosArr[j].X + 20, apexPosArr[j].Y + 10);
                        }

                        if (apexPosArr[i].X > apexPosArr[j].X && apexPosArr[i].Y > apexPosArr[j].Y) // Если первый ниже правее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X, apexPosArr[i].Y,
                                apexPosArr[j].X + 20, apexPosArr[j].Y + 20);
                        }

                        if (apexPosArr[i].X == apexPosArr[j].X && apexPosArr[i].Y > apexPosArr[j].Y) // Если первый ниже второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X + 10, apexPosArr[i].Y,
                                apexPosArr[j].X + 10, apexPosArr[j].Y + 20);
                        }

                        if (apexPosArr[i].X < apexPosArr[j].X && apexPosArr[i].Y > apexPosArr[j].Y) // Если первый ниже левее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X + 20, apexPosArr[i].Y,
                                apexPosArr[j].X, apexPosArr[j].Y + 20);
                        }

                        if (apexPosArr[i].X < apexPosArr[j].X && apexPosArr[i].Y == apexPosArr[j].Y) // Если первый левее второго
                        {
                            g.DrawLine(linePen, apexPosArr[i].X + 20, apexPosArr[i].Y + 10,
                                apexPosArr[j].X, apexPosArr[j].Y + 10);
                        }
                    }
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ParallelPicBox.Refresh();
        }

        private void ShowGraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Выход из программы
        }
    }
}
