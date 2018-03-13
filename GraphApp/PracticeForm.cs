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
    public partial class PracticeForm : Form
    {
        public PracticeForm()
        {
            InitializeComponent();

            PracticeChooseForm practiceChooseForm = (PracticeChooseForm)this.Owner; // Запомнили хозяина
        }

        private void GoToMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            Hide();
        }

        public PracticeGraph practiceGraph; // Граф (получили при загрузке формы)
        public bool[,] adjMatrix; // Матрица смежности (переписали из полученного объекта при загрузке формы)
        public string[] floors; // Ярусы (переписали из полученного объекта при загрузке формы)

        public TextBox[] floorTextBoxes = new TextBox[8]; // Создали массив текстбоков
        public Button[] dataButtons = new Button[8]; // Создали массив кнопок с правильными ответами

        public int level; // Уровень сложности (передается из хозяина)
        private void PracticeForm_Load(object sender, EventArgs e)
        {
            practiceGraph = Controller.GetGraph(level); // Получаем случайный граф из БД
            adjMatrix = practiceGraph.AdjMatrix; // Переписали матрицу смежноси
            floors = practiceGraph.Floors; // Переписали ярусы

            // Заполнили массив текстбоксов
            floorTextBoxes[0] = ZeroFloorTextBox;
            floorTextBoxes[1] = FirstFloorTextBox;
            floorTextBoxes[2] = SecondFloorTextBox;
            floorTextBoxes[3] = ThirdFloorTextBox;
            floorTextBoxes[4] = FourthFloorTextBox;
            floorTextBoxes[5] = FifthFloorTextBox;
            floorTextBoxes[6] = SixthFloorTextBox;
            floorTextBoxes[7] = SeventhFloorTextBox;

            // Заполнили массив кнопок с ответами
            dataButtons[0] = ShowZeroFloorDataButton;
            dataButtons[1] = ShowFirstFloorDataButton;
            dataButtons[2] = ShowSecondFloorDataButton;
            dataButtons[3] = ShowThirdFloorDataButton;
            dataButtons[4] = ShowFourthFloorDataButton;
            dataButtons[5] = ShowFifthFloorDataButton;
            dataButtons[6] = ShowSixthFloorDataButton;
            dataButtons[7] = ShowSeventhFloorDataButton;

            for (int i = 0; i < floorTextBoxes.Length; i++)
            {
                floorTextBoxes[i].Enabled = false; // Изначально блокируем все
                dataButtons[i].Enabled = false;
            }

            for (int i = 0; i < floors.Length; i++)
            {
                floorTextBoxes[i].Enabled = true; // Разблокируем столько, сколько ярусов нам пришло из файла
                dataButtons[i].Enabled = true;
            }
        }

        private void ZeroFloorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ZeroFloorTextBox.SelectionStart != 0) // Если это не первый символ в строке
            {
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) // Вводится число
                {
                    if (ZeroFloorTextBox.Text.IndexOf(e.KeyChar) == -1) // Если его не было до этого в строке
                    {
                        if (Char.IsDigit(ZeroFloorTextBox.Text[ZeroFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже число
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Space && ZeroFloorTextBox.SelectionStart != 0) // Пробел
                {
                    if (!Char.IsDigit(ZeroFloorTextBox.Text[ZeroFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже пробел
                        e.Handled = true;
                    else
                        e.Handled = false;
                }

                if (e.KeyChar == (char)Keys.Back && ZeroFloorTextBox.Text != "" &&
                    ZeroFloorTextBox.SelectionStart != 0) // Бакспейс
                {
                    ZeroFloorTextBox.Text = ZeroFloorTextBox.Text.Substring(0, ZeroFloorTextBox.Text.Length - 1);
                    ZeroFloorTextBox.SelectionStart = ZeroFloorTextBox.Text.Length;
                }

            }
            else // Если первый символ
            {
                if (!Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        private void FirstFloorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (FirstFloorTextBox.SelectionStart != 0) // Если это не первый символ в строке
            {
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) // Вводится число
                {
                    if (FirstFloorTextBox.Text.IndexOf(e.KeyChar) == -1) // Если его не было до этого в строке
                    {
                        if (Char.IsDigit(FirstFloorTextBox.Text[FirstFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже число
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Space && FirstFloorTextBox.SelectionStart != 0) // Пробел
                {
                    if (!Char.IsDigit(FirstFloorTextBox.Text[FirstFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже пробел
                        e.Handled = true;
                    else
                        e.Handled = false;
                }

                if (e.KeyChar == (char)Keys.Back && FirstFloorTextBox.Text != "" &&
                    FirstFloorTextBox.SelectionStart != 0) // Бакспейс
                {
                    FirstFloorTextBox.Text = FirstFloorTextBox.Text.Substring(0, FirstFloorTextBox.Text.Length - 1);
                    FirstFloorTextBox.SelectionStart = FirstFloorTextBox.Text.Length;
                }

            }
            else // Если первый символ
            {
                if (!Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void SecondFloorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SecondFloorTextBox.SelectionStart != 0) // Если это не первый символ в строке
            {
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) // Вводится число
                {
                    if (SecondFloorTextBox.Text.IndexOf(e.KeyChar) == -1) // Если его не было до этого в строке
                    {
                        if (Char.IsDigit(SecondFloorTextBox.Text[SecondFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже число
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Space && SecondFloorTextBox.SelectionStart != 0) // Пробел
                {
                    if (!Char.IsDigit(SecondFloorTextBox.Text[SecondFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже пробел
                        e.Handled = true;
                    else
                        e.Handled = false;
                }

                if (e.KeyChar == (char)Keys.Back && SecondFloorTextBox.Text != "" &&
                   SecondFloorTextBox.SelectionStart != 0) // Бакспейс
                {
                    SecondFloorTextBox.Text = SecondFloorTextBox.Text.Substring(0, SecondFloorTextBox.Text.Length - 1);
                    SecondFloorTextBox.SelectionStart = SecondFloorTextBox.Text.Length;
                }

            }
            else // Если первый символ
            {
                if (!Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void ThirdFloorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ThirdFloorTextBox.SelectionStart != 0) // Если это не первый символ в строке
            {
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) // Вводится число
                {
                    if (ThirdFloorTextBox.Text.IndexOf(e.KeyChar) == -1) // Если его не было до этого в строке
                    {
                        if (Char.IsDigit(ThirdFloorTextBox.Text[ThirdFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже число
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Space && ThirdFloorTextBox.SelectionStart != 0) // Пробел
                {
                    if (!Char.IsDigit(ThirdFloorTextBox.Text[ThirdFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже пробел
                        e.Handled = true;
                    else
                        e.Handled = false;
                }

                if (e.KeyChar == (char)Keys.Back && ThirdFloorTextBox.Text != "" &&
                   ThirdFloorTextBox.SelectionStart != 0) // Бакспейс
                {
                    ThirdFloorTextBox.Text = ThirdFloorTextBox.Text.Substring(0, ThirdFloorTextBox.Text.Length - 1);
                    ThirdFloorTextBox.SelectionStart = ThirdFloorTextBox.Text.Length;
                }

            }
            else // Если первый символ
            {
                if (!Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void FourthFloorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FourthFloorTextBox.SelectionStart != 0) // Если это не первый символ в строке
            {
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) // Вводится число
                {
                    if (FourthFloorTextBox.Text.IndexOf(e.KeyChar) == -1) // Если его не было до этого в строке
                    {
                        if (Char.IsDigit(FourthFloorTextBox.Text[FourthFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже число
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Space && FourthFloorTextBox.SelectionStart != 0) // Пробел
                {
                    if (!Char.IsDigit(FourthFloorTextBox.Text[FourthFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже пробел
                        e.Handled = true;
                    else
                        e.Handled = false;
                }

                if (e.KeyChar == (char)Keys.Back && FourthFloorTextBox.Text != "" &&
                   FourthFloorTextBox.SelectionStart != 0) // Бакспейс
                {
                    FourthFloorTextBox.Text = FourthFloorTextBox.Text.Substring(0, FourthFloorTextBox.Text.Length - 1);
                    FourthFloorTextBox.SelectionStart = FourthFloorTextBox.Text.Length;
                }

            }
            else // Если первый символ
            {
                if (!Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void FifthFloorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FifthFloorTextBox.SelectionStart != 0) // Если это не первый символ в строке
            {
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) // Вводится число
                {
                    if (FifthFloorTextBox.Text.IndexOf(e.KeyChar) == -1) // Если его не было до этого в строке
                    {
                        if (Char.IsDigit(FifthFloorTextBox.Text[FifthFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже число
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Space && FifthFloorTextBox.SelectionStart != 0) // Пробел
                {
                    if (!Char.IsDigit(FifthFloorTextBox.Text[FifthFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже пробел
                        e.Handled = true;
                    else
                        e.Handled = false;
                }

                if (e.KeyChar == (char)Keys.Back && FifthFloorTextBox.Text != "" &&
                   FifthFloorTextBox.SelectionStart != 0) // Бакспейс
                {
                    FifthFloorTextBox.Text = FifthFloorTextBox.Text.Substring(0, FifthFloorTextBox.Text.Length - 1);
                    FifthFloorTextBox.SelectionStart = FifthFloorTextBox.Text.Length;
                }

            }
            else // Если первый символ
            {
                if (!Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Space && FifthFloorTextBox.SelectionStart != 0) // Пробел
            {
                if (!Char.IsDigit(FifthFloorTextBox.Text[FifthFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже пробел
                    e.Handled = true;
                else
                    e.Handled = false;
            }

            if (e.KeyChar == (char)Keys.Back && FifthFloorTextBox.Text != "" &&
               FifthFloorTextBox.SelectionStart != 0) // Бакспейс
            {
                FifthFloorTextBox.Text = FifthFloorTextBox.Text.Substring(0, FifthFloorTextBox.Text.Length - 1);
                FifthFloorTextBox.SelectionStart = FifthFloorTextBox.Text.Length;
            }
        }

        private void SixthFloorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SixthFloorTextBox.SelectionStart != 0) // Если это не первый символ в строке
            {
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) // Вводится число
                {
                    if (SixthFloorTextBox.Text.IndexOf(e.KeyChar) == -1) // Если его не было до этого в строке
                    {
                        if (Char.IsDigit(SixthFloorTextBox.Text[SixthFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже число
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Space && SixthFloorTextBox.SelectionStart != 0) // Пробел
                {
                    if (!Char.IsDigit(SixthFloorTextBox.Text[SixthFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже пробел
                        e.Handled = true;
                    else
                        e.Handled = false;
                }

                if (e.KeyChar == (char)Keys.Back && SixthFloorTextBox.Text != "" &&
                   SixthFloorTextBox.SelectionStart != 0) // Бакспейс
                {
                    SixthFloorTextBox.Text = SixthFloorTextBox.Text.Substring(0, SixthFloorTextBox.Text.Length - 1);
                    SixthFloorTextBox.SelectionStart = SixthFloorTextBox.Text.Length;
                }

            }
            else // Если первый символ
            {
                if (!Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void SeventhFloorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (SeventhFloorTextBox.SelectionStart != 0) // Если это не первый символ в строке
            {
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) // Вводится число
                {
                    if (SeventhFloorTextBox.Text.IndexOf(e.KeyChar) == -1) // Если его не было до этого в строке
                    {
                        if (Char.IsDigit(SeventhFloorTextBox.Text[SeventhFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже число
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = true;
                }

                if (e.KeyChar == (char)Keys.Space && SeventhFloorTextBox.SelectionStart != 0) // Пробел
                {
                    if (!Char.IsDigit(SeventhFloorTextBox.Text[SeventhFloorTextBox.SelectionStart - 1])) // Если предыдущий тоже пробел
                        e.Handled = true;
                    else
                        e.Handled = false;
                }

                if (e.KeyChar == (char)Keys.Back && SeventhFloorTextBox.Text != "" &&
                   SeventhFloorTextBox.SelectionStart != 0) // Бакспейс
                {
                    SeventhFloorTextBox.Text = SeventhFloorTextBox.Text.Substring(0, SeventhFloorTextBox.Text.Length - 1);
                    SeventhFloorTextBox.SelectionStart = SeventhFloorTextBox.Text.Length;
                }
            }
            else // Если первый символ
            {
                if (!Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void PracticePicBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Переменная, отвечающая за рисование

            Pen apPen = new Pen(Color.DarkBlue); // Ручка для вершин
            Brush apBrush = new SolidBrush(Color.DarkBlue); // Заливка вершин

            Pen linePen = new Pen(Color.Black, 5); // Ручка для дуги
            linePen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor; // На конце – указатель

            Brush textBrush = new SolidBrush(Color.White); // Цвет названия вершины
            Font textFont = new Font("Arial", 10, FontStyle.Bold); // Шрифт названия вершины

            int numberOfApexes = adjMatrix.GetLength(0); // Кол-во вершин

            ApexPos[] apexPosArr = new ApexPos[numberOfApexes]; // Массив вершин


            int k = 0; // Номер вершины
            int picBoxBorder = 510; // Длина стороны квадратного пикчербокса (смещено, на самом деле 716х660)
            // Идем по координате х с безопасным для 9 вершин шагом
            for (int x = 0; x <= picBoxBorder; x += picBoxBorder / ((numberOfApexes + 1) / 2))
            {
                // Значение коорд у выражается из формулы круга (x-255)^2 + (y-255)^2 = 255^2

                double y1 = Math.Sqrt(Math.Pow(picBoxBorder / 2, 2) - Math.Pow(x - picBoxBorder / 2, 2)); // Считаем первый у (+)
                y1 += picBoxBorder / 2;

                g.DrawEllipse(apPen, x, Convert.ToInt32(y1), 20, 20); // Нарисовали вершину
                g.FillEllipse(apBrush, x, Convert.ToInt32(y1), 20, 20); // Залили вершину
                g.DrawString((k + 1).ToString(), textFont, textBrush, x + 1, Convert.ToInt32(y1) + 1); // Вставили текст (номер вершины)
                apexPosArr[k] = new ApexPos(k, x, Convert.ToInt32(y1)); // Записали вершину в массив
                k++;
                if (k == numberOfApexes)
                    break;

                if (x != 0 && x != picBoxBorder) // Если х не на границе (на границе будет одна вершина)
                {
                    double y2 = -Math.Sqrt(Math.Pow(picBoxBorder / 2, 2) - Math.Pow(x - picBoxBorder / 2, 2)); // Считаем второй у (-)
                    y2 += picBoxBorder / 2;

                    g.DrawEllipse(apPen, x, Convert.ToInt32(y2), 20, 20); // Нарисовали вершину
                    g.FillEllipse(apBrush, x, Convert.ToInt32(y2), 20, 20); // Залили вершину
                    g.DrawString((k + 1).ToString(), textFont, textBrush, x + 1, Convert.ToInt32(y2) + 1); // Вставили текст (номер вершины)
                    apexPosArr[k] = new ApexPos(k, x, Convert.ToInt32(y2)); // Записали вершину в массив
                    k++;
                    if (k == numberOfApexes)
                        break;
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

        private void NewGraphBut_Click(object sender, EventArgs e)
        {
            PracticeForm practiceForm = new PracticeForm();
            practiceForm.level = level;
            practiceForm.Show();
            Close();
        }

        private void ShowZeroFloorDataButton_Click(object sender, EventArgs e)
        {
            string buf = floors[0];
            buf = buf.Replace('&', ' ');

            MessageBox.Show("Правильный ответ (в любом другом порядке): " + buf, "Правильный ответ", MessageBoxButtons.OK);
        }

        private void ShowFirstFloorDataButton_Click(object sender, EventArgs e)
        {
            string buf = floors[1];
            buf = buf.Replace('&', ' ');

            MessageBox.Show("Правильный ответ (в любом другом порядке): " + buf, "Правильный ответ", MessageBoxButtons.OK);
        }

        private void ShowSecondFloorDataButton_Click(object sender, EventArgs e)
        {
            string buf = floors[2];
            buf = buf.Replace('&', ' ');

            MessageBox.Show("Правильный ответ (в любом другом порядке): " + buf, "Правильный ответ", MessageBoxButtons.OK);
        }

        private void ShowThirdFloorDataButton_Click(object sender, EventArgs e)
        {
            string buf = floors[3];
            buf = buf.Replace('&', ' ');

            MessageBox.Show("Правильный ответ (в любом другом порядке): " + buf, "Правильный ответ", MessageBoxButtons.OK);
        }

        private void ShowFourthFloorDataButton_Click(object sender, EventArgs e)
        {
            string buf = floors[4];
            buf = buf.Replace('&', ' ');

            MessageBox.Show("Правильный ответ (в любом другом порядке): " + buf, "Правильный ответ", MessageBoxButtons.OK);
        }

        private void ShowFifthFloorDataButton_Click(object sender, EventArgs e)
        {
            string buf = floors[5];
            buf = buf.Replace('&', ' ');

            MessageBox.Show("Правильный ответ (в любом другом порядке): " + buf, "Правильный ответ", MessageBoxButtons.OK);
        }

        private void ShowSixthFloorDataButton_Click(object sender, EventArgs e)
        {
            string buf = floors[6];
            buf = buf.Replace('&', ' ');

            MessageBox.Show("Правильный ответ (в любом другом порядке): " + buf, "Правильный ответ", MessageBoxButtons.OK);
        }

        private void ShowSeventhFloorDataButton_Click(object sender, EventArgs e)
        {
            string buf = floors[7];
            buf = buf.Replace('&', ' ');

            MessageBox.Show("Правильный ответ (в любом другом порядке): " + buf, "Правильный ответ", MessageBoxButtons.OK);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < floorTextBoxes.Length; i++) // Идем по текстбоксам
            {
                if (floorTextBoxes[i].Enabled)
                    floorTextBoxes[i].BackColor = Color.White; // Изначально красим все в белый 
                else
                    break; // Идти дальше нет смысла
            }

            int allOk = 0; // Проверяет, все ли текстбоксы соотв рельным результатам

            for (int i = 0; i < floorTextBoxes.Length; i++) // Идем по текстбоксам
            {
                if (floorTextBoxes[i].Enabled) // Если текстбокс не заблокирован
                {
                    string[] userData = floorTextBoxes[i].Text.Split(' '); // Массив-результат пользователя с номерами вершин
                    if (userData[userData.Length - 1] == "") // Если пользователь последним символом ввел пробел, то избавляемся от него
                        userData = Controller.Mas(userData);

                    string[] realData = floors[i].Split('&'); // Массив с реальными данными
                    realData = Controller.Mas(realData); // Избавляемся от пустого последнего эл-а

                    bool equal = true; // Отвечает за равенство результатов

                    if (userData.Length != realData.Length) // Проверка на равенство кол-ва элементов
                        equal = false;

                    if (equal)
                    {
                        for (int a = 0; a < realData.Length; a++)
                        {
                            bool ok = false; // Равенство элементов
                            for (int b = 0; b < userData.Length; b++)
                            {
                                if (realData[a] == userData[b])
                                    ok = true; // Нашелся соответствующий элемент
                            }

                            if (!ok) // Соотв элемент не нашелся
                            {
                                equal = false;
                                break;
                            }
                        }
                    }

                    if (!equal)
                    {
                        floorTextBoxes[i].BackColor = Color.Pink; // Указываем на ошибку
                        allOk++; // Увеличиваем кол-во ошибочных строк 
                    }
                }
                else
                    break; // Нет смысла идти дальше, т.к. все дальше заблокировано
            }

            if (allOk == 0) // Если не нашлась ни одна ошибочная строка
            {
                MessageBox.Show("Поздравляем! Поля заполнены верно!", "Успех!", MessageBoxButtons.OK);
            }
        }
    }
}
